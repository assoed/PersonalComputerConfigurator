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
    public partial class MainPageForm : Form
    {
        private UserSession _currentUser;

        private ProfileBlockUserControl _profileBlock;

        public MainPageForm(UserSession userSession)
        {
            InitializeComponent();
            _currentUser = userSession;
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            // Создаем один экземпляр ProfileBlockUserControl
            _profileBlock = new ProfileBlockUserControl(_currentUser);

            _profileBlock.Location = new Point(this.ClientSize.Width - _profileBlock.Width - 10, 10);
            _profileBlock.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Подписка на события
            _profileBlock.LogoutClicked += UserControl_LogoutClicked;
            _profileBlock.ProfileClicked += UserControl_ProfileClicked;

            mainPageSplitContainer.Panel1.Controls.Add(_profileBlock);

            lastNameTextBox.Text = _currentUser.lastName;
            nameTextBox.Text = _currentUser.name;
            middleNameTextBox.Text = _currentUser.middleName;
            emailLabel.Text = _currentUser.email;
            loginLabel.Text = _currentUser.login;
            showProcessors(sender, e);
        }

        private void UserControl_LogoutClicked(object sender, EventArgs e)
        {
            // Закрываем текущую форму (MainPageForm)
            this.Hide();

            // Показать форму авторизации
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void ProcessorUserControl_EditFormDataSaved(object sender, EventArgs e)
        {
            // После сохранения данных обновляем отображение
            processorsFlowLayoutPanel.Controls.Clear();  // Очистка старых данных
            showProcessors(null, null);  // Перезагрузка процессоров
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_ProfileClicked(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = profileTabPage;
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            string newName = nameTextBox.Text;
            string newLastName = lastNameTextBox.Text;
            string newMiddleName = middleNameTextBox.Text;

            // Проверка на пустые данные
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newLastName) || string.IsNullOrWhiteSpace(newMiddleName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Получаем пользователя из базы данных с учетом его id
            var user = Program.context.user.FirstOrDefault(u => u.id == _currentUser.id);

            if (user != null)
            {
                user.name = newName;
                user.lastName = newLastName;
                user.middleName = newMiddleName;

                Program.context.SaveChanges();

                _currentUser.name = newName;
                _currentUser.lastName = newLastName;
                _currentUser.middleName = newMiddleName;

                MessageBox.Show("Данные успешно сохранены.");
            }

            _profileBlock.UpdateProfileData();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void showProcessors(object sender, EventArgs e)
        {
            processorsFlowLayoutPanel.Controls.Clear();

            List <processors> processors = Program.context.processors.ToList();

            foreach (processors processor in processors)
            {
                processorsFlowLayoutPanel.Controls.Add(new processorsUserControl(processor));
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            showProcessors(sender, e);
        }

        private void userFIOLabel_Click(object sender, EventArgs e)
        {

        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }
    }  
}
