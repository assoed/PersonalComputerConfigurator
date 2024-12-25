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
    public partial class AuthorizationForm : Form
    {

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar ='*';
        }

        private void createNewAccButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void loginButtton_Click(object sender, EventArgs e)
        {
            string login =  loginTextBox.Text; 
            string password = passwordTextBox.Text;


            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }

            var user = Program.context.user.FirstOrDefault(u => u.login == login);

            if (user == null)
            {
                MessageBox.Show("Пользователь с таким логином не найден.");
                return;
            }

            if (user.password != PasswordHashService.hashPassword(password))
            {
                MessageBox.Show("Неверный пароль.");
                return;
            }

            MessageBox.Show("Добро пожаловать, " + user.name + "!");

            UserSession.Id = user.id;
            UserSession.Name = user.name;
            UserSession.LastName = user.lastName;
            UserSession.MiddleName = user.middleName;
            UserSession.Login = user.login;
            UserSession.Email = user.email;

            MainPageForm mainPageForm = new MainPageForm();
            mainPageForm.Show();
            this.Hide();
        }
    }
}
