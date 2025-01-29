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
        private Cooler _coolers;
        public CoolersUserControl(Cooler coolers)
        {
            InitializeComponent();
            _coolers = coolers;
            UserRightsSegregation userRightsSegregation = new UserRightsSegregation();
            userRightsSegregation.SetButtonsVisibilityAndEnabledState(this);
            setLabelsValue();
        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _coolers.Name;
            descriptionValueLabel.Text = _coolers.Description;
            powerValueLabel.Text = _coolers.Power.ToString();
            typeValueLabel.Text = _coolers.Socket;
            materialValueLabel.Text = _coolers?.Material.ToString();
            priceValueLabel.Text = _coolers.Price.ToString();
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
                var productToDelete = Program.context.Cooler.FirstOrDefault(p => p.ID == _coolers.ID);
                if (productToDelete != null)
                {
                    Program.context.Cooler.Remove(productToDelete);
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
