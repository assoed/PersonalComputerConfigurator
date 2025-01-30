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
    public partial class SsdUserControl : UserControl
    {
        private SSD _ssd;
        public SsdUserControl(SSD ssd)
        {
            InitializeComponent();
            _ssd = ssd;
            setLabelsValue();
        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _ssd.Name;
            descriptionValueLabel.Text = _ssd.Description;
            readingValueLabel.Text = _ssd.Reading.ToString();
            capacityValueLabel.Text = _ssd.Capacity.ToString();
            writingValueLabel.Text = _ssd.Writing.ToString();
            priceValueLabel.Text = _ssd.Price.ToString();
        }

        private void readLabel_Click(object sender, EventArgs e)
        {

        }

        private void writingLabel_Click(object sender, EventArgs e)
        {

        }

        private void writingValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void readingValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {
            GenericEditFormCreator formCreator = new GenericEditFormCreator();
            Form editForm = formCreator.CreateEditForm(_ssd);

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
                var productToDelete = Program.context.Cooler.FirstOrDefault(p => p.ID == _ssd.ID);
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
