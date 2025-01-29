using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using PersonalComputerConfigurator.Services;
using System.Data.Entity;
using PersonalComputerConfigurator.Models;

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
            if (property.Name.Equals("id", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            TextBox textBox = _controls.Find(ctrl => ctrl.Name == property.Name) as TextBox;
            if (textBox != null)
            {
                try
                {
                    object value;

                    // Если свойство называется "Price", конвертируем в int
                    if (property.Name.Equals("Price", StringComparison.OrdinalIgnoreCase) &&
                        property.PropertyType == typeof(int))
                    {
                        value = int.TryParse(textBox.Text, out int intValue) ? intValue : 0;
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
            if (_isNewObject)
            {
                context.Set(_targetObject.GetType()).Add(_targetObject);
            }
            else
            {
                context.Entry(_targetObject).State = EntityState.Modified;
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
        EditFormBuilder builder = new EditFormBuilder(targetObject, isNewObject); // Передаем флаг

        // Получаем все свойства типа targetObject с помощью рефлексии
        PropertyInfo[] properties = targetObject.GetType().GetProperties();

        // Для каждого свойства создаем параметр
        foreach (var property in properties)
        {
            if (property.CanRead)
            {
                string translatedName = TranslateService.translate(property.Name);
                if (isNewObject && property.Name.Equals("id", StringComparison.OrdinalIgnoreCase))
                {
                    continue; // Пропускаем добавление поля id
                }
                // Если свойство - id, отображаем его как Label
                if (property.Name.Equals("id", StringComparison.OrdinalIgnoreCase))
                {
                    builder.AddLabel(translatedName, property.GetValue(targetObject)?.ToString());
                }
                else
                {
                    builder.AddParameter(translatedName, property.Name, property.GetValue(targetObject));
                }
            }
        }

        // Добавляем кнопку сохранения с логикой сохранения
        builder.AddSaveButton(() =>
        {
            builder.SaveChanges();
            MessageBox.Show("Данные сохранены!");
        });

        return builder.Build();
    }
}
