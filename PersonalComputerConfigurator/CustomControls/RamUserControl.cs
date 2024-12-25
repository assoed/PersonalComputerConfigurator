using PersonalComputerConfigurator.Models;
using PersonalComputerConfigurator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalComputerConfigurator.CustomControls
{
    public partial class RamUserControl : UserControl
    {
        private ram _ram;

        public event EventHandler MotherboardDeleted;
        public RamUserControl(ram ram)
        {
            InitializeComponent();
            _ram = ram;

            UserRightsSegregation userRightsSegregation = new UserRightsSegregation();
            userRightsSegregation.SetButtonsVisibilityAndEnabledState(this);
            setLabelsValue();
        }

        private void RamUserControl_Load(object sender, EventArgs e)
        {

        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _ram.name;
            descriptionValueLabel.Text = _ram.description;
            ramTypeValueLabel.Text = _ram.type.ToString();
            formFactorValueLabel.Text = _ram.formFactor;
            priceValueLabel.Text = _ram.price?.ToString() ?? "Цена не установлена";
            frequencyValueLabel.Text = _ram.frequency.ToString();
            capacityValueLabel.Text = _ram.capacity;
        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {
            GenericEditFormCreator formCreator = new GenericEditFormCreator();
            Form editForm = formCreator.CreateEditForm(_ram);

            // Открываем форму для редактирования
            editForm.ShowDialog();
        }

        private void editForm_DataSaved(object sender, EventArgs e)
        {
            // Обработчик события для обновления данных после сохранения
            // Если данные были изменены, обновляем их на UserControl
            setLabelsValue();
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            // Подтверждение удаления
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var productToDelete = Program.context.ram.FirstOrDefault(p => p.id == _ram.id);
                if (productToDelete != null)
                {
                    Program.context.ram.Remove(productToDelete);
                    Program.context.SaveChanges(); // Сохраняем изменения в базе данных

                    // Удаляем этот процессор с панели
                    Controls.Remove(this); // 'this' - это текущий UserControl

                    // Вызываем событие, чтобы родительская форма обновила список
                    MotherboardDeleted?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Товар успешно удален.");
                }
            }
        }

        private void chipsetValueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
