using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using PersonalComputerConfigurator.Services;
using System.Data.Entity;
using PersonalComputerConfigurator.Models;
using System.Linq;

public class EditFormBuilder
{
    private Form _editForm;
    private List<Control> _controls;
    private object _targetObject;
    private bool _isNewObject;  // Флаг для создания нового объекта
    public event EventHandler DataSaved;

    // Конструктор с флагом для нового объекта
    public EditFormBuilder(object targetObject, bool isNewObject = false)
    {
        _editForm = new Form
        {
            Width = 400,
            Height = 600,
            AutoScroll = true,
            StartPosition = FormStartPosition.CenterScreen
        };
        _controls = new List<Control>();
        _targetObject = targetObject;
        _isNewObject = isNewObject; // Устанавливаем флаг
    }

    // Добавление параметра на форму
    public void AddParameter(string label, string propertyName, object initialValue)
    {
        Label parameterLabel = new Label();
        parameterLabel.Text = label;
        parameterLabel.Location = new Point(10, 10 + _controls.Count * 30); // Устанавливаем позицию

        TextBox textBox = new TextBox();

        if (_isNewObject)
        {
            textBox.Text = string.Empty; // Для нового объекта текстовое поле пустое
        }
        else
        {
            textBox.Text = initialValue?.ToString(); // Для редактирования используем текущее значение
        }

        textBox.Location = new Point(120, 10 + _controls.Count * 30);
        textBox.Name = propertyName;  // Назначаем имя текстовому полю, чтобы идентифицировать его позже
        textBox.Width = 200;

        _controls.Add(parameterLabel);
        _controls.Add(textBox);

        _editForm.Controls.Add(parameterLabel);
        _editForm.Controls.Add(textBox);
    }

    public void AddLabel(string label, string value)
    {
        Label parameterLabel = new Label();
        parameterLabel.Text = $"{label}: {value}";
        parameterLabel.Location = new Point(10, 10 + _controls.Count * 30); // Позиция метки
        parameterLabel.Width = 200;

        _controls.Add(parameterLabel);
        _editForm.Controls.Add(parameterLabel);
    }

    // Добавление кнопки сохранения на форму
    public void AddSaveButton(Action onSave)
    {
        Button saveButton = new Button();
        saveButton.Text = "Сохранить";
        saveButton.Location = new Point(10, 10 + _controls.Count * 30);
        saveButton.Click += (sender, e) => onSave();

        _controls.Add(saveButton);
        _editForm.Controls.Add(saveButton);
    }

    // Получить итоговую форму
    public Form Build()
    {
        return _editForm;
    }

    // Обновление значений в объекте на основе данных из текстовых полей
    public void SaveChanges()
    {
        PropertyInfo[] properties = _targetObject.GetType().GetProperties();

        foreach (var property in properties)
        {
            if (property.Name.Equals("id", StringComparison.OrdinalIgnoreCase) ||
                (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>)))
            {
                continue; // Пропускаем id и коллекции
            }

            TextBox textBox = _controls.Find(ctrl => ctrl.Name == property.Name) as TextBox;
            if (textBox != null)
            {
                try
                {
                    object value;

                    if (property.PropertyType == typeof(int))
                    {
                        value = int.TryParse(textBox.Text, out int intValue) ? intValue : 0;
                    }
                    else if (property.PropertyType == typeof(decimal))
                    {
                        value = decimal.TryParse(textBox.Text, out decimal decValue) ? decValue : 0m;
                    }
                    else
                    {
                        value = Convert.ChangeType(textBox.Text, property.PropertyType);
                    }

                    property.SetValue(_targetObject, value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении значения для {property.Name}: {ex.Message}");
                }
            }
        }

        using (var context = new PCConfiguratorModel())
        {
            var dbSet = context.Set(_targetObject.GetType());
            var keyProperty = _targetObject.GetType().GetProperty("id");
            var key = keyProperty?.GetValue(_targetObject);

            if (_isNewObject)
            {
                dbSet.Add(_targetObject);
            }
            else
            {
                var existingObject = dbSet.Find(key);

                if (existingObject != null)
                {
                    context.Entry(existingObject).CurrentValues.SetValues(_targetObject);
                }
                else
                {
                    // Убираем объект из другого контекста перед повторным добавлением
                    var localObject = context.Set(_targetObject.GetType()).Local.ToList()
                        .FirstOrDefault(e => keyProperty?.GetValue(e).Equals(key) == true);

                    if (localObject != null)
                    {
                        context.Entry(localObject).State = EntityState.Detached;
                    }

                    try
                    {
                        dbSet.Attach(_targetObject);
                        context.Entry(_targetObject).State = EntityState.Modified;
                    }
                    catch (InvalidOperationException)
                    {
                        context.Entry(_targetObject).State = EntityState.Detached;
                        var reloadedObject = dbSet.Find(key);
                        if (reloadedObject != null)
                        {
                            context.Entry(reloadedObject).CurrentValues.SetValues(_targetObject);
                        }
                        else
                        {
                            dbSet.Attach(_targetObject);
                            context.Entry(_targetObject).State = EntityState.Modified;
                        }
                    }
                }
            }

            context.SaveChanges();
        }

    }

    context.SaveChanges();
        }


        DataSaved?.Invoke(this, EventArgs.Empty);
    }
}

public class GenericEditFormCreator
{
    public Form CreateEditForm(object targetObject, bool isNewObject = false)
    {
        EditFormBuilder builder = new EditFormBuilder(targetObject, isNewObject);

        PropertyInfo[] properties = targetObject.GetType().GetProperties();

        foreach (var property in properties)
        {
            if (property.CanRead)
            {
                string translatedName = TranslateService.translate(property.Name);
                if (isNewObject && property.Name.Equals("id", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (property.Name.Equals("id", StringComparison.OrdinalIgnoreCase))
                {
                    builder.AddLabel(translatedName, property.GetValue(targetObject)?.ToString());
                }
                else if (!(property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>)))
                {
                    builder.AddParameter(translatedName, property.Name, property.GetValue(targetObject));
                }
            }
        }

        builder.AddSaveButton(() =>
        {
            builder.SaveChanges();
            MessageBox.Show("Данные сохранены!");
        });

        return builder.Build();
    }
}
