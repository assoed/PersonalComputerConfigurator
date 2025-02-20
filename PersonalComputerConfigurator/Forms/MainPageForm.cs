using PersonalComputerConfigurator.CustomControls;
using PersonalComputerConfigurator.Models;
using PersonalComputerConfigurator.Services;
using PersonalComputerConfigurator.Constants;
using PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PersonalComputerConfigurator.Interfaces;
using System.Data;
using System.Data.Entity;

namespace PersonalComputerConfigurator.Forms
{
    public partial class MainPageForm : Form
    {
        // Поля для BindingNavigator
        private BindingNavigator psuBindingNavigator, gpuBindingNavigator, ssdBindingNavigator,
            processorBindingNavigator, ramBindingNavigator, coolerBindingNavigator,
            hddBindingNavigator, caseBindingNavigator, motherboardBindingNavigator;

        private readonly Dictionary<string, (BindingNavigator navigator, BindingSource source, dynamic adapter)> _bindings;

        public MainPageForm()
        {
            InitializeComponent();
            // Инициализация словаря биндингов
            _bindings = new Dictionary<string, (BindingNavigator, BindingSource, dynamic)>
            {
                { "PSU", (psuBindingNavigator = new BindingNavigator(true), pSUBindingSource, pSUTableAdapter) },
                { "GPU", (gpuBindingNavigator = new BindingNavigator(true), gPUBindingSource, gPUTableAdapter) },
                { "SSD", (ssdBindingNavigator = new BindingNavigator(true), sSDBindingSource, sSDTableAdapter) },
                { "Processor", (processorBindingNavigator = new BindingNavigator(true), processorBindingSource, processorTableAdapter) },
                { "RAM", (ramBindingNavigator = new BindingNavigator(true), rAMBindingSource, rAMTableAdapter) },
                { "Cooler", (coolerBindingNavigator = new BindingNavigator(true), coolerBindingSource, coolerTableAdapter) },
                { "HDD", (hddBindingNavigator = new BindingNavigator(true), hDDBindingSource, hDDTableAdapter) },
                { "Case", (caseBindingNavigator = new BindingNavigator(true), caseBindingSource, caseTableAdapter) },
                { "Motherboard", (motherboardBindingNavigator = new BindingNavigator(true), motherboardBindingSource, motherboardTableAdapter) }
            };

            CustomizeBindingNavigators();
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            ClearAllLabels();

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


            ShowConfigurations();
            SetupProfileBlock();


            LoadData();
            BindDataGrids();
            InitializeBindingNavigators();
            SetupEventHandlers();
            SetupProfileBlock();
            showUsers();
            ClearAllLabels();
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

            hddCapacityLabel.Text = $"Объем: {selectedHDD.Capacity} ГБ";
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

        private void ClearAllLabels()
        {
            configNameTextBox.Text = "";
            // Очистка всех Label
            processorSocketLabel.Text = "";
            processorTDPLabel.Text = "";
            processorFrequencyLabel.Text = "";
            processorBoostLabel.Text = "";
            processorCoresLabel.Text = "";
            processorThreadsLabel.Text = "";
            processorPriceLabel.Text = "";

            motherboardSocketLabel.Text = "";
            motherboardChipsetLabel.Text = "";
            motherboardFormFactorLabel.Text = "";
            motherboardPriceLabel.Text = "";
            motherboardRamTypeLabel.Text = "";

            ramCapacityLabel.Text = "";
            ramTypeLabel.Text = "";
            ramFrequencyLabel.Text = "";
            ramFormFactorLabel.Text = "";
            ramPriceLabel.Text = "";

            coolerSocketLabel.Text = "";
            coolerPowerLabel.Text = "";
            coolerMaterialLabel.Text = "";
            coolerTypeLabel.Text = "";
            coolerPriceLabel.Text = "";

            gpuFrequencyLabel1.Text = "";
            gpuBoostLabel1.Text = "";
            memorySizeLabel1.Text = "";
            memoryTypeLabel1.Text = "";
            tdpLabel1.Text = "";
            priceLabel1.Text = "";

            formFaktorLabel1.Text = "";
            sizeLabel1.Text = "";
            priceLabel3.Text = "";

            powerSupplyLabel1.Text = "";
            formFactorLabel1.Text = "";
            certificateLabel1.Text = "";
            priceLabel5.Text = "";

            hddCapacityLabel.Text = "";
            speedLabel1.Text = "";
            priceLabel7.Text = "";

            // Очистка SSD
            capacityLabel3.Text = "";
            readingLabel1.Text = "";
            writingLabel1.Text = "";
            priceLabel9.Text = "";

            // Очистка ComboBox без вызова SelectedIndexChanged
            ResetComboBox(processorComboBox);
            ResetComboBox(motherboardComboBox);
            ResetComboBox(ramComboBox);
            ResetComboBox(coolerComboBox);
            ResetComboBox(gpuComboBox);
            ResetComboBox(caseComboBox);
            ResetComboBox(psuComboBox);
            ResetComboBox(hddComboBox);
            ResetComboBox(ssdComboBox);

            configPriceLabel.Text = "Общая цена: 0₽";

        }

        private void ResetComboBox(ComboBox comboBox)
        {
            if (comboBox.DataSource != null)
            {
                comboBox.SelectedIndex = -1;
                comboBox.SelectedItem = null;
            }
        }


        public void ShowConfigurations()
        {
            configurationsFlowLayoutPanel.Controls.Clear();

            // Загружаем сборки пользователя и подгружаем связанные предупреждения
            List<Configuration> configs = Program.context.Configuration.Where(c => c.UserID == UserSession.Id).ToList();

            foreach (Configuration config in configs)
            {
                var userControl = new ConfigurationUserControl(config);
                userControl.SetMainAdminForm(this);

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

        private void LoadData()
        {
            motherboardTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.Motherboard);
            pSUTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.PSU);
            gPUTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.GPU);
            sSDTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.SSD);
            hDDTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.HDD);
            caseTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.Case);
            coolerTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.Cooler);
            rAMTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.RAM);
            processorTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.Processor);
            DDRTypeTableAdapter dDRTypeTableAdapter = new DDRTypeTableAdapter();

            dDRTypeTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet.DDRType);
        }

        private void BindDataGrids()
        {
            pSUDataGridView.DataSource = pSUBindingSource;
            gPUDataGridView.DataSource = gPUBindingSource;
            sSDDataGridView.DataSource = sSDBindingSource;
            processorDataGridView.DataSource = processorBindingSource;
            rAMDataGridView.DataSource = rAMBindingSource;
            hDDDataGridView.DataSource = hDDBindingSource;
            caseDataGridView.DataSource = caseBindingSource;
            coolerDataGridView.DataSource = coolerBindingSource;
            motherboardDataGridView.DataSource = motherboardBindingSource;

            SetupMotherboardRamTypeComboBox();
            SetupMemoryTypeComboBox();
        }

        private void SetupMemoryTypeComboBox()
        {
            // Удаляем старый столбец "Type", если он уже есть
            if (rAMDataGridView.Columns["Type"] != null)
                rAMDataGridView.Columns.Remove("Type");

            // Создаем новый столбец ComboBox
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                Name = "Type",
                HeaderText = "Тип памяти",
                DataPropertyName = "Type",
                DataSource = personalComputerConfiguratorDatabaseDataSet.DDRType, // Источник данных
                DisplayMember = "DdrTypeName", // Отображаемые названия (DDR3, DDR4...)
                ValueMember = "DdrID", // Хранимые значения (1, 2, 3...)
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Popup,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };

            rAMDataGridView.Columns.Add(comboBoxColumn);

            // Проходим по всем строкам и исправляем возможные ошибки с типами
            foreach (DataGridViewRow row in rAMDataGridView.Rows)
            {
                if (row.Cells["Type"].Value == DBNull.Value || row.Cells["Type"].Value == null)
                {
                    row.Cells["Type"].Value = 1; // Значение по умолчанию (DDR3)
                }
            }

            rAMBindingSource.ResetBindings(false);
        }
        private void SetupMotherboardRamTypeComboBox()
        {
            // Проверяем, существует ли колонка "RamType" и удаляем её
            if (motherboardDataGridView.Columns.Contains("RamType"))
                motherboardDataGridView.Columns.Remove("RamType");

            // Создаём новый столбец ComboBox
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                Name = "RamType",
                HeaderText = "Тип оперативной памяти",
                DataPropertyName = "RamType",
                DataSource = personalComputerConfiguratorDatabaseDataSet.DDRType,
                DisplayMember = "DdrTypeName",
                ValueMember = "DdrID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ValueType = typeof(int),
                FlatStyle = FlatStyle.Popup,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };

            // Добавляем колонку в DataGridView
            motherboardDataGridView.Columns.Add(comboBoxColumn);

            // Устанавливаем значение по умолчанию (если NULL)
            foreach (DataGridViewRow row in motherboardDataGridView.Rows)
            {
                if (row.Cells["RamType"].Value == DBNull.Value || row.Cells["RamType"].Value == null)
                {
                    row.Cells["RamType"].Value = 1; // По умолчанию DDR3
                }
            }

            motherboardBindingSource.ResetBindings(false);
        }


        private void InitializeBindingNavigators()
        {
            foreach (var binding in _bindings)
            {
                binding.Value.navigator.BindingSource = binding.Value.source;
                binding.Value.navigator.Dock = DockStyle.Top;
                AddSaveButton(binding.Value.navigator, binding.Value.source, binding.Value.adapter);
            }

            // Добавляем BindingNavigator в соответствующие вкладки
            psuTab.Controls.Add(psuBindingNavigator);
            gpuTab.Controls.Add(gpuBindingNavigator);
            ssdTab.Controls.Add(ssdBindingNavigator);
            processorsTab.Controls.Add(processorBindingNavigator);
            ramTab.Controls.Add(ramBindingNavigator);
            coolersTab.Controls.Add(coolerBindingNavigator);
            hddTab.Controls.Add(hddBindingNavigator);
            casesTab.Controls.Add(caseBindingNavigator);
            motherboardTab.Controls.Add(motherboardBindingNavigator);
        }

        private void addNewUserPictureBox_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.UserUpdated += showUsers;
            registrationForm.ShowDialog();
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

        private void showUsers()
        {
            usersEdtiorFlowLayoutPanel.Controls.Clear(); // Очищаем перед загрузкой

            List<User> users = Program.context.User.ToList();

            foreach (User user in users)
            {

                var userControl = new UserEditorAdminControl(user);
                userControl.UserUpdated += showUsers; // Подписываемся на обновление
                usersEdtiorFlowLayoutPanel.Controls.Add(userControl);

            }
        }

        private void SetupEventHandlers()
        {
            foreach (var dataGridView in new[] { pSUDataGridView, gPUDataGridView, sSDDataGridView, processorDataGridView,
                                                 rAMDataGridView, hDDDataGridView, caseDataGridView, coolerDataGridView, motherboardDataGridView })
            {
                dataGridView.CellValidating += DataGridView_CellValidating;
                dataGridView.DataError += DataGridView_DataError;
            }
        }

        private void psuSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(pSUBindingSource, psuSearchTextBox.Text, "Name");
        }

        private void gpuSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(gPUBindingSource, gpuSearchTextBox.Text, "Name");
        }

        private void ssdSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(sSDBindingSource, ssdSearchTextBox.Text, "Name");
        }

        private void processorSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(processorBindingSource, psuSearchTextBox.Text, "Name");
        }

        private void ramSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(rAMBindingSource, ramSearchTextBox.Text, "Name");
        }

        private void hddSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(hDDBindingSource, hddSearchTextBox.Text, "Name");
        }

        private void caseSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(caseBindingSource, caseSearchTextBox.Text, "Name");
        }

        private void coolerSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(coolerBindingSource, coolerSearchTextBox.Text, "Name");
        }

        private void motherboardSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(motherboardBindingSource, motherboardSearchTextBox.Text, "Name");
        }

        private void adminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rAMDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Type"].Value = 1;
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cleanConfigPictureBox_Click(object sender, EventArgs e)
        {
            ClearAllLabels();
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
            adminTabControl.SelectedTab = profileTabPage;
        }


        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) return;

            var columnName = dataGridView.Columns[e.ColumnIndex].HeaderText;
            var integerColumns = new HashSet<string> { "ИДЕНТИФИКАТОР", "МОЩНОСТЬ", "ЦЕНА", "ЧАСТОТА ГПУ", "РАЗГОН ГПУ", "ОБЪЕМ ВИДЕОПАМЯТИ", "ТДП", "Type" };

            if (integerColumns.Contains(columnName) && !int.TryParse(e.FormattedValue.ToString(), out _))
            {
                MessageBox.Show($"Ошибка: Введите только целое число в столбце '{columnName}'!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Должно быть целое число!";
                e.Cancel = true;
            }
            else
            {
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
            }
        }


        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Ошибка в данных: {e.Exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = true;
        }
        private void AddSaveButton(BindingNavigator navigator, BindingSource source, dynamic adapter)
        {
            if (!navigator.Items.Cast<ToolStripItem>().Any(i => i.Text == "Сохранить"))
            {
                var saveButton = new ToolStripButton("Сохранить")
                {
                    Image = SystemIcons.Shield.ToBitmap(),
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                };
                saveButton.Click += (s, e) => SaveChanges(source, adapter);
                navigator.Items.Add(saveButton);
            }
        }

        private void SaveChanges(BindingSource source, dynamic adapter)
        {
            try
            {
                if (!Validate())
                {
                    MessageBox.Show("Исправьте ошибки перед сохранением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                source.EndEdit();
                adapter.Update(personalComputerConfiguratorDatabaseDataSet);
                MessageBox.Show("✅ Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySearchFilter(BindingSource source, string searchText, string columnName)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                source.RemoveFilter(); // Сбрасываем фильтр, если поле пустое
            }
            else
            {
                source.Filter = $"{columnName} LIKE '%{searchText}%'"; // Фильтр по введённому тексту
            }
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
            ClearAllLabels();
            ShowConfigurations();
        }

        private bool IsComponentUsed(string componentType, int componentID)
        {
            // Очистка кэша EF вручную
            Program.context.ChangeTracker.Entries().ToList().ForEach(e => e.State = EntityState.Detached);

            switch (componentType)
            {
                case "Processor":
                    return Program.context.Configuration.Any(c => c.ProcessorID == componentID);
                case "GPU":
                    return Program.context.Configuration.Any(c => c.GpuID == componentID);
                case "RAM":
                    return Program.context.Configuration.Any(c => c.RamID == componentID);
                case "Motherboard":
                    return Program.context.Configuration.Any(c => c.MotherboardID == componentID);
                case "PSU":
                    return Program.context.Configuration.Any(c => c.PsuID == componentID);
                case "Cooler":
                    return Program.context.Configuration.Any(c => c.CoolerID == componentID);
                case "HDD":
                    return Program.context.Configuration.Any(c => c.HddID == componentID);
                case "SSD":
                    return Program.context.Configuration.Any(c => c.SsdID == componentID);
                case "Case":
                    return Program.context.Configuration.Any(c => c.CaseID == componentID);
                default:
                    return false;
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton button)
            {
                // Определяем `BindingNavigator`, из которого пришел вызов
                var binding = _bindings.FirstOrDefault(b => b.Value.navigator.Items.Contains(button));
                if (binding.Value.source == null) return;

                // Проверяем, есть ли текущий элемент
                if (binding.Value.source.Current is DataRowView currentRow)
                {
                    int componentID = (int)currentRow["ID"];
                    string componentType = binding.Key; // "Processor", "GPU", и т. д.

                    // Проверяем, используется ли комплектующее в сборках
                    if (IsComponentUsed(componentType, componentID))
                    {
                        MessageBox.Show($"❌ Этот {componentType} используется в сборках и не может быть удалён!",
                                        "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Остановка метода — удаление не продолжается
                    }

                    // Запрос подтверждения удаления
                    DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить {componentType}?",
                                                          "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        binding.Value.source.RemoveCurrent(); // Удаление
                        binding.Value.adapter.Update(personalComputerConfiguratorDatabaseDataSet); // Сохранение
                        MessageBox.Show($"{componentType} успешно удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void CustomizeBindingNavigators()
        {
            foreach (var binding in _bindings)
            {
                foreach (ToolStripItem item in binding.Value.navigator.Items)
                {
                    if (item is ToolStripButton button && button.Name == "bindingNavigatorDeleteItem")
                    {
                        button.Click -= BindingNavigatorDeleteItem_Click; // Удаляем старый обработчик
                        button.Click += BindingNavigatorDeleteItem_Click; // Добавляем новый
                    }
                }
            }
        }
    }
}
