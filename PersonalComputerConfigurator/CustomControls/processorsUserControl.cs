using PersonalComputerConfigurator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalComputerConfigurator.CustomControls
{
    public partial class processorsUserControl : UserControl
    {
        private processors _processor;

        public event EventHandler ProcessorDeleted;

        public processorsUserControl(processors processors)
        {
            InitializeComponent();
            _processor = processors;
            setLabelsValue();
        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _processor.name;
            descriptionValueLabel.Text = _processor.description;
            tdpValueLabel.Text = _processor.tdp.ToString();
            socketValueLabel.Text = _processor.socket;
            frequencyValueLabel.Text = _processor?.frequency.ToString();
            boostValueLabel.Text = _processor?.boost.ToString();
            priceValueLabel.Text = _processor.price.ToString();
            coresValueLabel.Text = _processor.cores.ToString();
            threadsValueLabel.Text = _processor?.threads.ToString();
        }

        private void tdpLabel_Click(object sender, EventArgs e)
        {

        }

        private void tdpValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void socketLabel_Click(object sender, EventArgs e)
        {

        }

        private void socketValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {
            GenericEditFormCreator formCreator = new GenericEditFormCreator();
            Form editForm = formCreator.CreateEditForm(_processor);

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
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этот процессор?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var processorToDelete = Program.context.processors.FirstOrDefault(p => p.id == _processor.id);
                if (processorToDelete != null)
                {
                    Program.context.processors.Remove(processorToDelete);
                    Program.context.SaveChanges(); // Сохраняем изменения в базе данных

                    // Удаляем этот процессор с панели
                    Controls.Remove(this); // 'this' - это текущий UserControl

                    // Вызываем событие, чтобы родительская форма обновила список
                    ProcessorDeleted?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Процессор успешно удален.");
                }
            }
        }
    }
}
