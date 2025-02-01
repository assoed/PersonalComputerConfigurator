using PersonalComputerConfigurator.Models;
using PersonalComputerConfigurator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalComputerConfigurator.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }


        private void registrationButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = nameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = repeatPasswordTextBox.Text;
            string email = emailTextBox.Text;
            int roleId = (int)userRoleComboBox.SelectedValue;

            if (UserSession.RoleId != Constants.Constants.AdministratorRoleId)
            {
                roleId = Constants.Constants.UserRoleId;
            }

            User newUser = new User
            {
                Name = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Password = PasswordHashService.hashPassword(password),
                Login = login,
                Email = email,
                Role = roleId,
                IsBlocked = 0,
            };

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают. Пожалуйста, проверьте введённые данные.");
                return; 
            }

            if (string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Все поля обязательны для заполнения.");
                return; 
            }

            Program.context.User.Add(newUser);
            Program.context.SaveChanges();
    
            MessageBox.Show("Регистрация прошла успешно!");

            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            if(UserSession.RoleId != Constants.Constants.AdministratorRoleId)
            {
                userRoleComboBox.Visible = false;
                userRoleComboBox.Enabled = false;

                userRoleLabel.Enabled = false;
                userRoleLabel.Visible = false;
            } 
            if(UserSession.RoleId != Constants.Constants.UserRoleId)
            {
                registrationLabel.Text = "ДОБАВИТЬ НОВОГО ПОЛЬЗОВАТЕЛЯ";
                registrationButton.Text = "СОХРАНИТЬ ПОЛЬЗОВАТЕЛЯ";
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "personalComputerConfiguratorDatabaseDataSet.userRole". При необходимости она может быть перемещена или удалена.
            this.userRoleTableAdapter.Fill(this.personalComputerConfiguratorDatabaseDataSet.userRole);
            passwordTextBox.PasswordChar = '*';
            repeatPasswordTextBox.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
