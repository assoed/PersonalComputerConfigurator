using PersonalComputerConfigurator.Interfaces;
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
    public partial class EditConfigForm : Form
    {
        private Configuration _configuration;

        public event EventHandler ConfigurationUpdated;

        public EditConfigForm(Configuration configuration)
        {
            InitializeComponent();
            _configuration = configuration;
        }

        private void EditConfigForm_Load(object sender, EventArgs e)
        {
            ConnectComboBoxHandlers();

            configPriceLabel.Text = $"Общая цена: {MoneyService.ToRubles(Convert.ToInt32(_configuration.ConfigPrice))}₽";
            configNameTextBox.Text = _configuration.Name;

            var processors = Program.context.Processor.ToList();

            // Преобразуем в список анонимных объектов

            processorComboBox.DataSource = processors;
            processorComboBox.DisplayMember = "Name"; // Свойство, которое будет использоваться по умолчанию
            processorComboBox.ValueMember = "ID";
            processorComboBox.FormattingEnabled = true;
            processorComboBox.SelectedValue = _configuration.ProcessorID;

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
            motherboardComboBox.SelectedValue = _configuration.MotherboardID;

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
            ramComboBox.SelectedValue = _configuration.RamID;

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
            coolerComboBox.SelectedValue = _configuration.CoolerID;

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
            gpuComboBox.SelectedValue = _configuration.GpuID;

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
            caseComboBox.SelectedValue = _configuration.CaseID;

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
            psuComboBox.SelectedValue = _configuration.PsuID;

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
            hddComboBox.SelectedValue = _configuration.HddID;

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
            ssdComboBox.SelectedValue = _configuration.SsdID;

            // Форматирование отображения в ComboBox
            ssdComboBox.Format += (s, args) =>
            {
                if (args.ListItem is SSD ssd)
                {
                    args.Value = $"{ssd.Name} | {ssd.Capacity} ГБ | Чтение: {ssd.Reading} МБ/с | Запись: {ssd.Writing} МБ/с | {MoneyService.ToRubles(Convert.ToInt32(ssd.Price))}₽";
                }
            };
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

        private void saveConfigPictureBox_Click(object sender, EventArgs e)
        {
            Configuration existingConfiguration = Program.context.Configuration.FirstOrDefault(c => c.ID == _configuration.ID);

            existingConfiguration.UserID = UserSession.Id;
            existingConfiguration.CaseID = (int)caseComboBox.SelectedValue;
            existingConfiguration.CoolerID = (int)coolerComboBox.SelectedValue;
            existingConfiguration.GpuID = (int)gpuComboBox.SelectedValue;
            existingConfiguration.HddID = (int)hddComboBox.SelectedValue;
            existingConfiguration.MotherboardID = (int)motherboardComboBox.SelectedValue;
            existingConfiguration.ProcessorID = (int)processorComboBox.SelectedValue;
            existingConfiguration.PsuID = (int)psuComboBox.SelectedValue;
            existingConfiguration.SsdID = (int)ssdComboBox.SelectedValue;
            existingConfiguration.RamID = (int)ramComboBox.SelectedValue;
            existingConfiguration.Name = configNameTextBox.Text;
            existingConfiguration.ConfigPrice = CalculateTotalPrice();
            existingConfiguration.UpdatedAt = DateTime.Now;

            Program.context.SaveChanges();

            MessageBox.Show("Конфигурация успешно сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ConfigurationUpdated?.Invoke(this, EventArgs.Empty);

            this.Close();
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

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            // Проверяем, существует ли конфигурация
            Configuration existingConfiguration = Program.context.Configuration.FirstOrDefault(c => c.ID == _configuration.ID);

            if (existingConfiguration != null)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту сборку?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Удаляем конфигурацию из базы данных
                    Program.context.Configuration.Remove(existingConfiguration);
                    Program.context.SaveChanges();

                    MessageBox.Show("Конфигурация успешно удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConfigurationUpdated?.Invoke(this, EventArgs.Empty); // Если есть обработчик события обновления

                    this.Close(); // Закрываем форму
                }
            }
            else
            {
                MessageBox.Show("Конфигурация не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
