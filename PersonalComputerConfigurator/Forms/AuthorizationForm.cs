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
using PersonalComputerConfigurator.Constants;

namespace PersonalComputerConfigurator.Forms
{
    public partial class AuthorizationForm : Form
    {
        private Form mainForm;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void createNewAccButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void loginButtton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }

            var user = Program.context.User.FirstOrDefault(u => u.Login == login);

            if (user == null)
            {
                MessageBox.Show("Пользователь с таким логином не найден.");
                return;
            }

            if (!PasswordHashService.VerifyPassword(password, user.Password))
            {
                MessageBox.Show("Неверный логин и пароль.");
/*                loginTextBox.Clear();
                passwordTextBox.Clear();*/
                return;
            }

            MessageBox.Show($"Добро пожаловать, {user.Name}!");

            InitializeUserSession(user);
            OpenMainForm((int)user.Role);
            this.Hide();
        }

        private void InitializeUserSession(dynamic user)
        {
            UserSession.Id = user.ID;
            UserSession.Name = user.Name;
            UserSession.LastName = user.LastName;
            UserSession.MiddleName = user.MiddleName;
            UserSession.Login = user.Login;
            UserSession.Email = user.Email;
            UserSession.RoleId = user.Role;
        }

        private void OpenMainForm(int roleId)
        {
            if (roleId == Constants.Constants.AdministratorRoleId)
            {
                mainForm = new MainPageForm();
            }
            else
            {
                mainForm = new MainPageUserForm();
            }

            mainForm.Show();
        }

        private void AuthorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Проверяем, нажата ли клавиша Enter
            {
                e.SuppressKeyPress = true; // Отключаем стандартное поведение Enter
                loginButtton_Click(sender, e);

            }
        }
    }

}
