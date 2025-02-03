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

            ConnectComboBoxHandlers();

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

            var gpus = Program.context.GPU.ToList();
            var gpuList = gpus.Select(g => new
            {
                g.ID,
                g.FullName,
                g.GpuFrequency,
                g.GpuBoost,
                g.MemorySize,
                g.MemoryType,
                g.Tdp,
                g.Price
            }).ToList();

            gpuComboBox.DataSource = gpuList;
            gpuComboBox.DisplayMember = "FullName";
            gpuComboBox.ValueMember = "ID";

            var cases = Program.context.Case.ToList();
            var caseList = cases.Select(c => new
            {
                c.ID,
                c.FullName,
                c.FormFaktor,
                c.Size,
                c.Price
            }).ToList();

            caseComboBox.DataSource = caseList;
            caseComboBox.DisplayMember = "FullName";
            caseComboBox.ValueMember = "ID";

            var psus = Program.context.PSU.ToList();
            var psuList = psus.Select(p => new
            {
                p.ID,
                p.FullName,
                p.PowerSupply,
                p.FormFactor,
                p.Certificate,
                p.Price
            }).ToList();

            psuComboBox.DataSource = psuList;
            psuComboBox.DisplayMember = "FullName";
            psuComboBox.ValueMember = "ID";

            var hdds = Program.context.HDD.ToList();
            var hddList = hdds.Select(h => new
            {
                h.ID,
                h.FullName,
                h.Capacity,
                h.Speed,
                h.Price
            }).ToList();

            hddComboBox.DataSource = hddList;
            hddComboBox.DisplayMember = "FullName";
            hddComboBox.ValueMember = "ID";

            var ssds = Program.context.SSD.ToList();
            var ssdList = ssds.Select(s => new
            {
                s.ID,
                s.FullName,
                s.Capacity,
                s.Reading,
                s.Writing,
                s.Price
            }).ToList();

            ssdComboBox.DataSource = ssdList;
            ssdComboBox.DisplayMember = "FullName";
            ssdComboBox.ValueMember = "ID";

            ClearAllLabels();

            SetupProfileBlock();
        }

        private void ConnectComboBoxHandlers()
        {
            gpuComboBox.SelectedIndexChanged += gpuComboBox_SelectedIndexChanged;
            caseComboBox.SelectedIndexChanged += caseComboBox_SelectedIndexChanged;
            psuComboBox.SelectedIndexChanged += psuComboBox_SelectedIndexChanged;
            hddComboBox.SelectedIndexChanged += hddComboBox_SelectedIndexChanged;
            ssdComboBox.SelectedIndexChanged += ssdComboBox_SelectedIndexChanged;
            coolerComboBox.SelectedIndexChanged += coolerComboBox_SelectedIndexChanged;
            processorComboBox.SelectedIndexChanged += ProcessorComboBox_SelectedIndexChanged;
            ramComboBox.SelectedIndexChanged += ramComboBox_SelectedIndexChanged;
            motherboardComboBox.SelectedIndexChanged += MotherboardComboBox_SelectedIndexChanged;
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


        private void gpuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gpuComboBox.SelectedItem == null) return;

            var selectedGPU = (dynamic)gpuComboBox.SelectedItem;

            gpuFrequencyLabel1.Text = $"Частота: {selectedGPU.GpuFrequency} МГц";
            gpuBoostLabel1.Text = $"Boost: {selectedGPU.GpuBoost} МГц";
            memorySizeLabel1.Text = $"Объем памяти: {selectedGPU.MemorySize} ГБ";
            memoryTypeLabel1.Text = $"Тип памяти: {selectedGPU.MemoryType}";
            tdpLabel1.Text = $"TDP: {selectedGPU.Tdp} Вт";
            priceLabel1.Text = $"Цена: {MoneyService.ToRubles(selectedGPU.Price)} ₽";
        }

        private void caseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caseComboBox.SelectedItem == null) return;

            var selectedCase = (dynamic)caseComboBox.SelectedItem;

            formFaktorLabel1.Text = $"Форм-фактор: {selectedCase.FormFaktor}";
            sizeLabel1.Text = $"Размер: {selectedCase.Size}";
            priceLabel3.Text = $"Цена: {MoneyService.ToRubles(selectedCase.Price)} ₽";
        }

        private void psuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (psuComboBox.SelectedItem == null) return;

            var selectedPSU = (dynamic)psuComboBox.SelectedItem;

            powerSupplyLabel1.Text = $"Мощность: {selectedPSU.PowerSupply} Вт";
            formFactorLabel1.Text = $"Форм-фактор: {selectedPSU.FormFactor}";
            certificateLabel1.Text = $"Сертификат: {selectedPSU.Certificate}";
            priceLabel5.Text = $"Цена: {MoneyService.ToRubles(selectedPSU.Price)} ₽";
        }

        private void hddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hddComboBox.SelectedItem == null) return;

            var selectedHDD = (dynamic)hddComboBox.SelectedItem;

            capacityLabel1.Text = $"Объем: {selectedHDD.Capacity} ГБ";
            speedLabel1.Text = $"Скорость: {selectedHDD.Speed} об/мин";
            priceLabel7.Text = $"Цена: {MoneyService.ToRubles(selectedHDD.Price)} ₽";
        }

        private void ssdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ssdComboBox.SelectedItem == null) return;

            var selectedSSD = (dynamic)ssdComboBox.SelectedItem;

            capacityLabel3.Text = $"Объем: {selectedSSD.Capacity} ГБ";
            readingLabel1.Text = $"Чтение: {selectedSSD.Reading} МБ/с";
            writingLabel1.Text = $"Запись: {selectedSSD.Writing} МБ/с";
            priceLabel9.Text = $"Цена: {MoneyService.ToRubles(selectedSSD.Price)} ₽";
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
            this.Hide();

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

            if (string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Все поля обязательны для заполнения.");
                return;
            }


            var existingUser = Program.context.User.FirstOrDefault(u => u.ID == UserSession.Id);

            existingUser.Name = firstName;
            existingUser.MiddleName = middleName;
            existingUser.LastName = lastName;

            Program.context.SaveChanges();

            UserSession.Name = firstName;
            UserSession.LastName = lastName;
            UserSession.MiddleName = middleName;

            userFIOLabel.Text = $"{UserSession.LastName} {UserSession.Name} {UserSession.MiddleName}";
            MessageBox.Show("Данные пользователя успешно обновлены!");
        }

        private void SaveConfiguration(object sender, EventArgs e)
        {
            var newConfiguration = new Configuration
            {
                UserID = UserSession.Id,
                CaseID = (int)caseComboBox.SelectedValue,
                CoolerID = (int)coolerComboBox.SelectedValue,
                GpuID = (int)gpuComboBox.SelectedValue,
                HddID = (int)hddComboBox.SelectedValue,
                MotherboardID = (int)motherboardComboBox.SelectedValue,
                ProcessorID = (int)processorComboBox.SelectedValue,
                PsuID = (int)psuComboBox.SelectedValue,
                SsdID = (int)ssdComboBox.SelectedValue,
                RamID = (int)ramComboBox.SelectedValue
            };

            Program.context.Configuration.Add(newConfiguration);
            Program.context.SaveChanges();

            MessageBox.Show("Конфигурация успешно сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAllLabels();
        }

        private void ClearAllLabels()
        {
            // Очистка процессора
            processorSocketLabel.Text = "";
            processorTDPLabel.Text = "";
            processorFrequencyLabel.Text = "";
            processorBoostLabel.Text = "";
            processorCoresLabel.Text = "";
            processorThreadsLabel.Text = "";
            processorPriceLabel.Text = "";

            // Очистка материнской платы
            motherboardSocketLabel.Text = "";
            motherboardChipsetLabel.Text = "";
            motherboardFormFactorLabel.Text = "";
            motherboardPriceLabel.Text = "";
            motherboardRamTypeLabel.Text = "";

            // Очистка оперативной памяти
            ramCapacityLabel.Text = "";
            ramTypeLabel.Text = "";
            ramFrequencyLabel.Text = "";
            ramFormFactorLabel.Text = "";
            ramPriceLabel.Text = "";

            // Очистка кулера
            coolerSocketLabel.Text = "";
            coolerPowerLabel.Text = "";
            coolerMaterialLabel.Text = "";
            coolerTypeLabel.Text = "";
            coolerPriceLabel.Text = "";

            // Очистка видеокарты
            gpuFrequencyLabel1.Text = "";
            gpuBoostLabel1.Text = "";
            memorySizeLabel1.Text = "";
            memoryTypeLabel1.Text = "";
            tdpLabel1.Text = "";
            priceLabel1.Text = "";

            // Очистка корпуса
            formFaktorLabel1.Text = "";
            sizeLabel1.Text = "";
            priceLabel3.Text = "";

            // Очистка блока питания
            powerSupplyLabel1.Text = "";
            formFactorLabel1.Text = "";
            certificateLabel1.Text = "";
            priceLabel5.Text = "";

            // Очистка жесткого диска
            capacityLabel1.Text = "";
            speedLabel1.Text = "";
            priceLabel7.Text = "";

            // Очистка SSD
            capacityLabel3.Text = "";
            readingLabel1.Text = "";
            writingLabel1.Text = "";
            priceLabel9.Text = "";

            processorComboBox.SelectedIndex = -1;
            motherboardComboBox.SelectedIndex = -1;
            ramComboBox.SelectedIndex = -1;
            coolerComboBox.SelectedIndex = -1;
            gpuComboBox.SelectedIndex = -1;
            caseComboBox.SelectedIndex = -1;
            psuComboBox.SelectedIndex = -1;
            hddComboBox.SelectedIndex = -1;
            ssdComboBox.SelectedIndex = -1;
        }
    }
}
