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

        public ProfilePageForm()
        {
            InitializeComponent();
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
            var user = Program.context.User.FirstOrDefault(u => u.ID == UserSession.Id);

            if (user != null)
            {
                user.Name = newName;
                user.LastName = newLastName;
                user.MiddleName = newMiddleName;

                Program.context.SaveChanges();

                UserSession.Name = newName;
                UserSession.LastName = newLastName;
                UserSession.MiddleName = newMiddleName;

                MessageBox.Show("Данные успешно сохранены.");
            }
        }

        private void ProfilePageForm_Load(object sender, EventArgs e)
        {
            lastNameTextBox.Text = UserSession.LastName;
            nameTextBox.Text = UserSession.Name;
            middleNameTextBox.Text = UserSession.MiddleName;
            emailLabel.Text = UserSession.Email;
            loginLabel.Text = UserSession.Login;
        }
    }
}
