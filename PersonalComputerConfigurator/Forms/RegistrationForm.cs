using PersonalComputerConfigurator.Models;
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

            var newUser = new user
            {
                name = firstName,
                middleName = middleName,
                lastName = lastName,
                password = Services.PasswordHashService.hashPassword(password),
                login = login,
                email = email,
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

            Program.context.user.Add(newUser);
            Program.context.SaveChanges();
    
            MessageBox.Show("Регистрация прошла успешно!");

            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }
    }
}
