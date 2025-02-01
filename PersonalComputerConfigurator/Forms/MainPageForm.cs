using PersonalComputerConfigurator.CustomControls;
using PersonalComputerConfigurator.Models;
using PersonalComputerConfigurator.Services;
using PersonalComputerConfigurator.Constants;
using PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            LoadData();
            BindDataGrids();
            InitializeBindingNavigators();
            SetupEventHandlers();
            SetupProfileBlock();
            showUsers(sender, e);
        }

        private void showUsers(object sender, EventArgs e)
        {
            usersEdtiorFlowLayoutPanel.Controls.Clear(); // Очищаем перед загрузкой

            List<User> users = Program.context.User.ToList();

            foreach (User user in users)
            {
                usersEdtiorFlowLayoutPanel.Controls.Add(new UserEditorAdminControl(user));
            }
        }


        private void LoadData()
        {
            motherboardTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.Motherboard);
            pSUTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.PSU);
            gPUTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.GPU);
            sSDTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.SSD);
            hDDTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.HDD);
            caseTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.Case);
            coolerTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.Cooler);
            rAMTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.RAM);
            processorTableAdapter.Fill(personalComputerConfiguratorDatabaseDataSet1.Processor);
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

        private void SetupEventHandlers()
        {
            foreach (var dataGridView in new[] { pSUDataGridView, gPUDataGridView, sSDDataGridView, processorDataGridView,
                                                 rAMDataGridView, hDDDataGridView, caseDataGridView, coolerDataGridView, motherboardDataGridView })
            {
                dataGridView.CellValidating += DataGridView_CellValidating;
                dataGridView.DataError += DataGridView_DataError;
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
            adminTabControl.SelectedTab = profileTabPage;
        }


        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) return;

            var columnName = dataGridView.Columns[e.ColumnIndex].HeaderText;
            var integerColumns = new HashSet<string> { "ИДЕНТИФИКАТОР", "МОЩНОСТЬ", "ЦЕНА", "ЧАСТОТА ГПУ", "РАЗГОН ГПУ", "ОБЪЕМ ВИДЕОПАМЯТИ", "ТДП" };

            if (integerColumns.Contains(columnName) && !long.TryParse(e.FormattedValue.ToString(), out _))
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
            MessageBox.Show($"Ошибка в данных: введите только число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                adapter.Update(personalComputerConfiguratorDatabaseDataSet1);
                MessageBox.Show("✅ Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
