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
using PersonalComputerConfigurator.Interfaces;
using System.Data.Entity;

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
            this.Shown += (s, args) => UpdateWarnings();
            ConnectComboBoxHandlers();
            warningPictureBox.Visible = false;

            var processors = Program.context.Processor.ToList();

            // Преобразуем в список анонимных объектов

            processorComboBox.DataSource = processors;
            processorComboBox.DisplayMember = "Name"; // Свойство, которое будет использоваться по умолчанию
            processorComboBox.ValueMember = "ID";
            processorComboBox.FormattingEnabled = true;

            // Назначение обработчика события Format
            processorComboBox.Format += (s, args) =>
            {
                if (args.ListItem is Processor processor)
                {
                    args.Value = $"{processor.Name} | {processor.Socket} | {processor.Tdp}W | {processor.Frequency} GHz | Boost {processor.Boost} GHz | {processor.Cores}C/{processor.Threads}T | {Convert.ToDouble(MoneyService.ToRubles(Convert.ToInt32(processor.Price)))} руб.";
                }
            };


            var motherboards = Program.context.Motherboard.ToList();

            motherboardComboBox.DataSource = motherboards;
            motherboardComboBox.DisplayMember = "FullName";
            motherboardComboBox.ValueMember = "ID";
            motherboardComboBox.FormattingEnabled = true;

            // Форматирование отображения в ComboBox
            motherboardComboBox.Format += (s, args) =>
            {
                if (args.ListItem is Motherboard motherboard)
                {
                    args.Value = $"{motherboard.Name} | {motherboard.Socket} | {motherboard.Chipset} | {motherboard.FormFactor} | {motherboard.DDRType.DdrTypeName} | {MoneyService.ToRubles(Convert.ToInt32(motherboard.Price))} руб.";
                }
            };

            var rams = Program.context.RAM.ToList();

            ramComboBox.DataSource = rams;
            ramComboBox.DisplayMember = "Name"; // Используется по умолчанию
            ramComboBox.ValueMember = "ID";
            ramComboBox.FormattingEnabled = true;

            // Форматирование отображения в ComboBox
            ramComboBox.Format += (s, args) =>
            {
                if (args.ListItem is RAM ram)
                {
                    args.Value = $"{ram.Name} | {ram.DDRType.DdrTypeName} | {ram.FormFactor} | {ram.Frequency} MHz | {ram.Capacity} GB | {MoneyService.ToRubles(Convert.ToInt32(ram.Price))}₽";
                }
            };


            var coolers = Program.context.Cooler.ToList();

            coolerComboBox.DataSource = coolers;
            coolerComboBox.DisplayMember = "Name"; // Используется по умолчанию
            coolerComboBox.ValueMember = "ID";
            coolerComboBox.FormattingEnabled = true;

            // Форматирование отображения в ComboBox
            coolerComboBox.Format += (s, args) =>
            {
                if (args.ListItem is Cooler cooler)
                {
                    args.Value = $"{cooler.Name} | {cooler.Socket} | {cooler.Type} | {cooler.Material} | {MoneyService.ToRubles(Convert.ToInt32(cooler.Price))}₽";
                }
            };

            var gpus = Program.context.GPU.ToList();

            gpuComboBox.DataSource = gpus;
            gpuComboBox.DisplayMember = "Name"; // Используется по умолчанию
            gpuComboBox.ValueMember = "ID";
            gpuComboBox.FormattingEnabled = true;

            // Форматирование отображения в ComboBox
            gpuComboBox.Format += (s, args) =>
            {
                if (args.ListItem is GPU gpu)
                {
                    args.Value = $"{gpu.Name} | {gpu.GpuFrequency} MHz | Boost: {gpu.GpuBoost} MHz | {gpu.MemorySize} GB {gpu.MemoryType} | {MoneyService.ToRubles(Convert.ToInt32(gpu.Price))}₽";
                }
            };

            var cases = Program.context.Case.ToList();

            caseComboBox.DataSource = cases;
            caseComboBox.DisplayMember = "Name"; // Используется по умолчанию
            caseComboBox.ValueMember = "ID";
            caseComboBox.FormattingEnabled = true;

            // Форматирование отображения в ComboBox
            caseComboBox.Format += (s, args) =>
            {
                if (args.ListItem is Case pcCase)
                {
                    args.Value = $"{pcCase.Name} | {pcCase.FormFaktor} | {pcCase.Size} | {MoneyService.ToRubles(Convert.ToInt32(pcCase.Price))}₽";
                }
            };

            var psus = Program.context.PSU.ToList();

            psuComboBox.DataSource = psus;
            psuComboBox.DisplayMember = "Name"; // Используется по умолчанию
            psuComboBox.ValueMember = "ID";
            psuComboBox.FormattingEnabled = true;

            // Форматирование отображения в ComboBox
            psuComboBox.Format += (s, args) =>
            {
                if (args.ListItem is PSU psu)
                {
                    args.Value = $"{psu.Name} | {psu.PowerSupply} Вт | {psu.FormFactor} | {psu.Certificate} | {MoneyService.ToRubles(Convert.ToInt32(psu.Price))}₽";
                }
            };

            var hdds = Program.context.HDD.ToList();

            hddComboBox.DataSource = hdds;
            hddComboBox.DisplayMember = "Name"; // Используется по умолчанию
            hddComboBox.ValueMember = "ID";
            hddComboBox.FormattingEnabled = true;

            // Форматирование отображения в ComboBox
            hddComboBox.Format += (s, args) =>
            {
                if (args.ListItem is HDD hdd)
                {
                    args.Value = $"{hdd.Name} | {hdd.Capacity} ГБ | {hdd.Speed} об/мин | {MoneyService.ToRubles(Convert.ToInt32(hdd.Price))}₽";
                }
            };

            var ssds = Program.context.SSD.ToList();

            ssdComboBox.DataSource = ssds;
            ssdComboBox.DisplayMember = "Name"; // Используется по умолчанию
            ssdComboBox.ValueMember = "ID";
            ssdComboBox.FormattingEnabled = true;

            // Форматирование отображения в ComboBox
            ssdComboBox.Format += (s, args) =>
            {
                if (args.ListItem is SSD ssd)
                {
                    args.Value = $"{ssd.Name} | {ssd.Capacity} ГБ | Чтение: {ssd.Reading} МБ/с | Запись: {ssd.Writing} МБ/с | {MoneyService.ToRubles(Convert.ToInt32(ssd.Price))}₽";
                }
            };


            ClearAllLabels();
            ShowConfigurations();
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

            UpdateTotalPrice();
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

            UpdateTotalPrice();
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

            UpdateWarnings();
            UpdateTotalPrice();
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

            UpdateWarnings();
            UpdateTotalPrice();
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

            UpdateTotalPrice();
        }

        private void caseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caseComboBox.SelectedItem == null) return;

            var selectedCase = (dynamic)caseComboBox.SelectedItem;

            formFaktorLabel1.Text = $"Форм-фактор: {selectedCase.FormFaktor}";
            sizeLabel1.Text = $"Размер: {selectedCase.Size}";
            priceLabel3.Text = $"Цена: {MoneyService.ToRubles(selectedCase.Price)} ₽";

            UpdateTotalPrice();
        }

        private void psuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (psuComboBox.SelectedItem == null) return;

            var selectedPSU = (dynamic)psuComboBox.SelectedItem;

            powerSupplyLabel1.Text = $"Мощность: {selectedPSU.PowerSupply} Вт";
            formFactorLabel1.Text = $"Форм-фактор: {selectedPSU.FormFactor}";
            certificateLabel1.Text = $"Сертификат: {selectedPSU.Certificate}";
            priceLabel5.Text = $"Цена: {MoneyService.ToRubles(selectedPSU.Price)} ₽";

            UpdateTotalPrice();
        }

        private void hddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hddComboBox.SelectedItem == null) return;

            var selectedHDD = (dynamic)hddComboBox.SelectedItem;

            capacityLabel1.Text = $"Объем: {selectedHDD.Capacity} ГБ";
            speedLabel1.Text = $"Скорость: {selectedHDD.Speed} об/мин";
            priceLabel7.Text = $"Цена: {MoneyService.ToRubles(selectedHDD.Price)} ₽";

            UpdateTotalPrice();
        }

        private void ssdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ssdComboBox.SelectedItem == null) return;

            var selectedSSD = (dynamic)ssdComboBox.SelectedItem;

            capacityLabel3.Text = $"Объем: {selectedSSD.Capacity} ГБ";
            readingLabel1.Text = $"Чтение: {selectedSSD.Reading} МБ/с";
            writingLabel1.Text = $"Запись: {selectedSSD.Writing} МБ/с";
            priceLabel9.Text = $"Цена: {MoneyService.ToRubles(selectedSSD.Price)} ₽";

            UpdateTotalPrice();
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
                RamID = (int)ramComboBox.SelectedValue,
                Name = configNameTextBox.Text,
                ConfigPrice = CalculateTotalPrice(),
                CreatedAt = DateTime.Now,
            };

            Program.context.Configuration.Add(newConfiguration);
            Program.context.SaveChanges();

            // Очистка старых предупреждений
            var oldWarnings = Program.context.ConfigurationWarning.Where(w => w.ConfigID == newConfiguration.ID);
            Program.context.ConfigurationWarning.RemoveRange(oldWarnings);

            List<ConfigurationWarning> warnings = new List<ConfigurationWarning>();

            // Проверка совместимости RAM и материнской платы (DDR Type)
            var motherboard = Program.context.Motherboard.Find(newConfiguration.MotherboardID);
            var ram = Program.context.RAM.Find(newConfiguration.RamID);

            if (motherboard != null && ram != null && motherboard.RamType != ram.Type)
            {
                warnings.Add(new ConfigurationWarning
                {
                    ConfigID = newConfiguration.ID,
                    WarningText = $"ОЗУ ({ram.Type}) несовместимо с материнской платой ({motherboard.RamType})!"
                });
            }

            // Добавление предупреждений в базу данных
            if (warnings.Any())
            {
                Program.context.ConfigurationWarning.AddRange(warnings);
                Program.context.SaveChanges();
            }

            MessageBox.Show("Конфигурация сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowConfigurations();
        }


        private void ClearAllLabels()
        {
            configNameTextBox.Text = "";

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

            configPriceLabel.Text = "Общая цена: 0₽";
        }
        public void ShowConfigurations()
        {
            configurationsFlowLayoutPanel.Controls.Clear();

            // Загружаем сборки пользователя и подгружаем связанные предупреждения
            List<Configuration> configs = Program.context.Configuration.ToList();

            foreach (Configuration config in configs)
            {
                var userControl = new ConfigurationUserControl(config);
                userControl.SetMainForm(this);

                configurationsFlowLayoutPanel.Controls.Add(userControl);
            }
        }

        private int CalculateTotalPrice()
        {
            int totalPrice = 0;

            var selectedItems = new List<object>
            {
                processorComboBox.SelectedItem,
                motherboardComboBox.SelectedItem,
                ramComboBox.SelectedItem,
                coolerComboBox.SelectedItem,
                gpuComboBox.SelectedItem,
                caseComboBox.SelectedItem,
                psuComboBox.SelectedItem,
                hddComboBox.SelectedItem,
                ssdComboBox.SelectedItem
            };

            foreach (var item in selectedItems)
            {
                if (item is IComponentWithPrice component)
                {
                    totalPrice += component.Price;
                }
            }

            return totalPrice;
        }

        private void UpdateTotalPrice()
        {
            configPriceLabel.Text = $"Общая цена: {MoneyService.ToRubles(CalculateTotalPrice())}₽";
        }

        private void UpdateWarnings()
        {
            List<string> warnings = new List<string>();

            var motherboardId = motherboardComboBox.SelectedValue as int?;
            var ramId = ramComboBox.SelectedValue as int?;

            if (motherboardId == null || ramId == null)
            {
                warningPictureBox.Visible = false;
                return; // Выходим из метода, если данные не загружены
            }

            var motherboard = Program.context.Motherboard.Find(motherboardId);
            var ram = Program.context.RAM.Find(ramId);

            // Проверка совместимости RAM и Материнской платы
            if (motherboard != null && ram != null && motherboard.RamType != ram.Type)
            {
                warnings.Add($"ОЗУ ({ram.Type}) несовместимо с материнской платой ({motherboard.RamType})!");
            }

            // Если есть предупреждения, показываем значок и настраиваем всплывающую подсказку
            if (warnings.Any())
            {
                warningPictureBox.Visible = true;
                ToolTip toolTip = new ToolTip
                {
                    AutoPopDelay = 5000,
                    InitialDelay = 500,
                    ReshowDelay = 400
                };
                toolTip.SetToolTip(warningPictureBox, "⚠ Внимание! \n" + string.Join("\n", warnings));
            }
            else
            {
                warningPictureBox.Visible = false;
            }
        }

        private void cleanConfigPictureBox_Click(object sender, EventArgs e)
        {
            ClearAllLabels();
        }
    }
}
