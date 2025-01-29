using PersonalComputerConfigurator.Models;
using PersonalComputerConfigurator.Services;
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
    public partial class ProcessorsUserControl : UserControl
    {
        private Processor _processor;

        public event EventHandler ProcessorDeleted;

        public ProcessorsUserControl(Processor processor)
        {
            InitializeComponent();
            _processor = processor;
            UserRightsSegregation userRightsSegregation = new UserRightsSegregation();
            userRightsSegregation.SetButtonsVisibilityAndEnabledState(this);
            setLabelsValue();
        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _processor.Name;
            descriptionValueLabel.Text = _processor.Description;
            tdpValueLabel.Text = _processor.Tdp.ToString();
            socketValueLabel.Text = _processor.Socket;
            frequencyValueLabel.Text = _processor?.Frequency.ToString();
            boostValueLabel.Text = _processor?.Boost.ToString();
            priceValueLabel.Text = _processor.Price.ToString();
            coresValueLabel.Text = _processor.Cores.ToString();
            threadsValueLabel.Text = _processor?.Threads.ToString();
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
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var processorToDelete = Program.context.Processor.FirstOrDefault(p => p.ID == _processor.ID);
                if (processorToDelete != null)
                {
                    Program.context.Processor.Remove(processorToDelete);
                    Program.context.SaveChanges(); // Сохраняем изменения в базе данных

                    // Удаляем этот процессор с панели
                    Controls.Remove(this); // 'this' - это текущий UserControl

                    // Вызываем событие, чтобы родительская форма обновила список
                    ProcessorDeleted?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Товар успешно удален.");
                }
            }
        }
    }
}
