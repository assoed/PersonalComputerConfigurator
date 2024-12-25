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
    public partial class MotherboardsUserControl : UserControl
    {
        private motherboards _motherboard;

        public event EventHandler MotherboardDeleted;

        public MotherboardsUserControl(motherboards motherboard)
        {
            InitializeComponent();
            _motherboard = motherboard;
            UserRightsSegregation userRightsSegregation = new UserRightsSegregation();
            userRightsSegregation.SetButtonsVisibilityAndEnabledState(this);
            setLabelsValue();
        }

        private void tdpValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _motherboard.name;
            descriptionValueLabel.Text = _motherboard.description;
            socketValueLabel.Text = _motherboard.socket;
            formFactorValueLabel.Text = _motherboard.formFactor;
            priceValueLabel.Text = _motherboard.price?.ToString() ?? "Цена не установлена";
            chipsetValueLabel.Text = _motherboard.chipset.ToString();
            ramTypeValueLabel.Text= _motherboard.ramType;
        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {
            GenericEditFormCreator formCreator = new GenericEditFormCreator();
            Form editForm = formCreator.CreateEditForm(_motherboard);

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
                var productToDelete = Program.context.motherboards.FirstOrDefault(p => p.id == _motherboard.id);
                if (productToDelete != null)
                {
                    Program.context.motherboards.Remove(productToDelete);
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
