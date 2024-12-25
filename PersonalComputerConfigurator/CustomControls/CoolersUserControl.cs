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
    public partial class CoolersUserControl : UserControl
    {
        private coolers _coolers;
        public CoolersUserControl(coolers coolers)
        {
            InitializeComponent();
            _coolers = coolers;
            UserRightsSegregation userRightsSegregation = new UserRightsSegregation();
            userRightsSegregation.SetButtonsVisibilityAndEnabledState(this);
            setLabelsValue();
        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _coolers.name;
            descriptionValueLabel.Text = _coolers.description;
            powerValueLabel.Text = _coolers.power.ToString();
            typeValueLabel.Text = _coolers.socket;
            materialValueLabel.Text = _coolers?.material.ToString();
            priceValueLabel.Text = _coolers.price.ToString();
        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {
            GenericEditFormCreator formCreator = new GenericEditFormCreator();
            Form editForm = formCreator.CreateEditForm(_coolers);

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
                var productToDelete = Program.context.coolers.FirstOrDefault(p => p.id == _coolers.id);
                if (productToDelete != null)
                {
                    Program.context.coolers.Remove(productToDelete);
                    Program.context.SaveChanges(); // Сохраняем изменения в базе данных

                    // Удаляем этот процессор с панели
                    Controls.Remove(this); // 'this' - это текущий UserControl

                    // Вызываем событие, чтобы родительская форма обновила список
                    //MotherboardDeleted?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Товар успешно удален.");
                }
            }
        }

        private void chipsetValueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
