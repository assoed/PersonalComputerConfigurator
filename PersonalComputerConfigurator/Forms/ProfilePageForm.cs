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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalComputerConfigurator.Forms
{
    public partial class ProfilePageForm : Form
    {
        private UserSession _currentUser;

        public ProfilePageForm(UserSession userSession)
        {
            InitializeComponent();
            _currentUser = userSession;
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
        }

        private void ProfilePageForm_Load(object sender, EventArgs e)
        {
            lastNameTextBox.Text = _currentUser.lastName;
            nameTextBox.Text = _currentUser.name;
            middleNameTextBox.Text = _currentUser.middleName;
            emailLabel.Text = _currentUser.email;
            loginLabel.Text = _currentUser.login;
        }
    }
}
