using PersonalComputerConfigurator.CustomControls;
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

namespace PersonalComputerConfigurator.Forms
{
    public partial class MainPageUserForm : Form
    {

        public MainPageUserForm()
        {
            InitializeComponent();
        }
   
        private void MainPageUserForm_Load(object sender, EventArgs e)
        {

            var processors = Program.context.Processor.ToList();

            // Преобразуем в список анонимных объектов
            var processorList = processors.Select(p => new
            {
                p.ID,
                p.FullName, // Метод в модели, который формирует полное название
                p.Socket,
                p.Tdp,
                p.Frequency,
                p.Boost,
                p.Cores,
                p.Threads,
                p.Price
            }).ToList();

            processorComboBox.DataSource = processorList;
            processorComboBox.DisplayMember = "FullName";
            processorComboBox.ValueMember   = "ID";

            var motherboards = Program.context.Motherboard.ToList();
            var motherboardsList = motherboards.Select(m => new
            {
                m.ID,
                m.FullName,
                m.Socket,
                m.Chipset,
                m.FormFactor,
                m.RamType,
                m.Price
            }).ToList();

            motherboardComboBox.DataSource = motherboardsList;
            motherboardComboBox.DisplayMember = "FullName";
            motherboardComboBox.ValueMember = "ID";


            var rams = Program.context.RAM.ToList();
            var ramsList = rams.Select(r => new
            {
                r.ID,
                r.FullName,
                r.Type,
                r.FormFactor,
                r.Capacity,
                r.Frequency,
                r.Price,
            }).ToList();

            ramComboBox.DataSource = ramsList;
            ramComboBox.DisplayMember = "FullName";
            ramComboBox.ValueMember = "ID";

            var coolers = Program.context.Cooler.ToList();
            var coolerList = coolers.Select(c => new
            {
                c.ID,
                c.FullName,
                c.Type,
                c.Socket,
                c.Power,
                c.Material,
                c.Price
            }).ToList();

            coolerComboBox.DataSource = coolerList;
            coolerComboBox.DisplayMember = "FullName";
            coolerComboBox.ValueMember = "ID";


            if (processorComboBox.Items.Count > 0)
                processorComboBox.SelectedIndex = 0;

            if (motherboardComboBox.Items.Count > 0)
                motherboardComboBox.SelectedIndex = 0;

            if (ramComboBox.Items.Count > 0)
                ramComboBox.SelectedIndex = 0;

            if (coolerComboBox.Items.Count > 0)
                coolerComboBox.SelectedIndex = 0;

            // 🟢 ЯВНО ВЫЗЫВАЕМ ОБНОВЛЕНИЕ ЛЕЙБЛОВ
            ProcessorComboBox_SelectedIndexChanged(processorComboBox, EventArgs.Empty);
            MotherboardComboBox_SelectedIndexChanged(motherboardComboBox, EventArgs.Empty);
            ramComboBox_SelectedIndexChanged(ramComboBox, EventArgs.Empty);
            coolerComboBox_SelectedIndexChanged(coolerComboBox, EventArgs.Empty);

            SetupProfileBlock();
        }

        private void coolerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coolerComboBox.SelectedItem == null) return;

            // Получаем выбранный процессор из списка
            var selectedCooler = (dynamic)coolerComboBox.SelectedItem;

            // Обновляем Label внутри GroupBox
            coolerSocketLabel.Text = $"Сокет: {selectedCooler.Socket}";
            coolerPowerLabel.Text = $"TDP: {selectedCooler.Power} Вт";
            coolerMaterialLabel.Text = $"МАТЕРИАЛ: {selectedCooler.Material}";
            coolerTypeLabel.Text = $"ТИП: {selectedCooler.Type}";
            coolerPriceLabel.Text = $"Цена: {MoneyService.ToRubles(selectedCooler.Price)} ₽";
        }

        private void ProcessorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (processorComboBox.SelectedItem == null) return;

            // Получаем выбранный процессор из списка
            var selectedProcessor = (dynamic)processorComboBox.SelectedItem;

            // Обновляем Label внутри GroupBox
            processorSocketLabel.Text = $"Сокет: {selectedProcessor.Socket}";
            processorTDPLabel.Text = $"TDP: {selectedProcessor.Tdp} Вт";
            processorFrequencyLabel.Text = $"Частота: {selectedProcessor.Frequency} ГГц";
            processorBoostLabel.Text = $"Boost: {selectedProcessor.Boost} ГГц";
            processorCoresLabel.Text = $"Ядер: {selectedProcessor.Cores}";
            processorThreadsLabel.Text = $"Потоков: {selectedProcessor.Threads}";
            processorPriceLabel.Text = $"Цена: {MoneyService.ToRubles(selectedProcessor.Price)} ₽";
        }

        private void ramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         if (ramComboBox.SelectedItem == null) return;

            // Получаем выбранный процессор из списка
            var selectedRam = (dynamic)ramComboBox.SelectedItem;

            // Обновляем Label внутри GroupBox
            ramCapacityLabel.Text = $"ОБЪЕМ ПАМЯТИ: {selectedRam.Capacity}";
            ramTypeLabel.Text = $"ТИП ПАМЯТИ: {selectedRam.Type}";
            ramFrequencyLabel.Text = $"Частота: {selectedRam.Frequency} Гц";
            ramFormFactorLabel.Text = $"ФОРМ ФАКТОР: {selectedRam.FormFactor}";
            ramPriceLabel.Text = $"Цена: {MoneyService.ToRubles(selectedRam.Price)} ₽";
        }

        private void MotherboardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motherboardComboBox.SelectedItem == null) return;

            // Получаем выбранный процессор из списка
            var selectedMotherboard = (dynamic)motherboardComboBox.SelectedItem;

            // Обновляем Label внутри GroupBox
            motherboardSocketLabel.Text = $"СОКЕТ: {selectedMotherboard.Socket}";
            motherboardChipsetLabel.Text = $"ЧИПСЕТ: {selectedMotherboard.Chipset}";
            motherboardFormFactorLabel.Text = $"ФОРМ ФАКТОР: {selectedMotherboard.FormFactor}";
            motherboardPriceLabel.Text = $"ЦЕНА: {MoneyService.ToRubles(selectedMotherboard.Price)} ₽";
            motherboardRamTypeLabel.Text = $"ТИП ОПЕРАТИВНОЙ ПАМЯТИ: {selectedMotherboard.RamType}";
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить свой профиль?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var userToDelete = Program.context.User.FirstOrDefault(p => p.ID == UserSession.Id);
                if (userToDelete != null)
                {
                    Program.context.User.Remove(userToDelete);
                    Program.context.SaveChanges();

                    Controls.Remove(this);
                    MessageBox.Show("Ваш профиль удален. Вы будете перенаправлены на страницу аутентификации");
                }

                UserSession.logOut();
                this.Close();
                
                AuthorizationForm form = new AuthorizationForm();
                form.ShowDialog();
            }
        }

        private void SetupProfileBlock()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(profilePictureBox, "Перейти в профиль");
            toolTip.SetToolTip(userFIOLabel, "Перейти в профиль");
            userFIOLabel.Text = $"{UserSession.LastName} {UserSession.Name} {UserSession.MiddleName}";


            lastNameTextBox.Text = UserSession.LastName;
            nameTextBox.Text = UserSession.Name;
            middleNameTextBox.Text = UserSession.MiddleName;
            emailLabel.Text = UserSession.Email;
            loginLabel.Text = UserSession.Login;
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Закрываем текущую форму (MainPageForm)
            this.Hide();

            // Показать форму авторизации
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }


        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            userTabControl.SelectedTab = userProfileTab;
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {

            string lastName = lastNameTextBox.Text;
            string firstName = nameTextBox.Text;
            string middleName = middleNameTextBox.Text;

            // Проверка на заполненность полей
            if (string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Все поля обязательны для заполнения.");
                return;
            }


            var existingUser = Program.context.User.FirstOrDefault(u => u.ID == UserSession.Id);

            // Обновляем данные пользователя
            existingUser.Name = firstName;
            existingUser.MiddleName = middleName;
            existingUser.LastName = lastName;

            // Сохраняем изменения в базе данных
            Program.context.SaveChanges();

            UserSession.Name = firstName;
            UserSession.LastName = lastName;
            UserSession.MiddleName = middleName;

            userFIOLabel.Text = $"{UserSession.LastName} {UserSession.Name} {UserSession.MiddleName}";
            MessageBox.Show("Данные пользователя успешно обновлены!");
        }

        private void processorTDPLabel_Click(object sender, EventArgs e)
        {

        }

        private void processorThreadsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
