using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalComputerConfigurator.Models;

namespace PersonalComputerConfigurator.CustomControls
{
    public partial class GpuUserControl : UserControl
    {

        private GPU _gpu;
        public GpuUserControl(GPU gpu)
        {
            InitializeComponent();
            _gpu = gpu;
            setLabelsValue();
        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _gpu.Name;
            descriptionValueLabel.Text = _gpu.Description;
            tdpValueLabel.Text = _gpu.Tdp;
            frequencyValueLabel.Text = _gpu.GpuFrequency;
            boostValueLabel.Text = _gpu.GpuBoost;
            memoryValueLabel.Text = _gpu.MemorySize;
            memoryTypeValueLabel.Text = _gpu.MemoryType;
            priceValueLabel.Text = _gpu.Price.ToString();
        }

        private void frequencyLabel_Click(object sender, EventArgs e)
        {

        }

        private void frequencyValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {
            GenericEditFormCreator formCreator = new GenericEditFormCreator();
            Form editForm = formCreator.CreateEditForm(_gpu);

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
                var productToDelete = Program.context.Cooler.FirstOrDefault(p => p.ID == _gpu.ID);
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
    }
}
