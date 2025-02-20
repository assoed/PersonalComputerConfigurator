using PersonalComputerConfigurator.Models;
using PersonalComputerConfigurator.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;



namespace PersonalComputerConfigurator.Forms
{
    public partial class UserEditForm : Form
    {
        public event Action UserUpdated;
        private int _userId;
        public UserEditForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void SetTextBoxValues(int userId)
        {
            User user = Program.context.User.FirstOrDefault(x => x.ID == userId);

            if (user != null) {
                lastNameTextBox.Text = user.LastName;
                middleNameTextBox.Text = user.MiddleName;
                nameTextBox.Text = user.Name;
                loginTextBox.Text = user.Login;
                emailTextBox.Text = user.Email;
                userRoleComboBox.SelectedValue = user.Role ?? Constants.Constants.UserRoleId;
            }
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            this.UserRoleTableAdapter.Fill(this.personalComputerConfiguratorDatabaseDataSet.UserRole);
            SetTextBoxValues(_userId);
        }

        private void userRoleBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = nameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string login = loginTextBox.Text;
            string email = emailTextBox.Text;
            int roleId = (int)userRoleComboBox.SelectedValue;


            // Проверка на заполненность полей
            if (string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Все поля обязательны для заполнения.");
                return;
            }


            if (!isEmailValid(email))
            {
                MessageBox.Show("Введите корректный email.");
                return;
            }

            var existingUser = Program.context.User.FirstOrDefault(u => u.ID == _userId);
    
            if (existingUser == null)
            {
                MessageBox.Show("Ошибка: пользователь не найден.");
                return;
            }

            if (Program.context.User.Any(u => u.Login == login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует. Выберите другой логин.");
                return;
            }

            // Обновляем данные пользователя
            existingUser.Name = firstName;
            existingUser.MiddleName = middleName;
            existingUser.LastName = lastName;
            existingUser.Role = roleId;
            existingUser.Email = email;
            existingUser.Login = login;

            // Сохраняем изменения в базе данных
            Program.context.SaveChanges();

            MessageBox.Show("Данные пользователя успешно обновлены!");
            UserUpdated?.Invoke();

            this.Close();
        }

        private bool isEmailValid(string email)
        {
            email = Regex.Replace(email, @"(@.+)$", match =>
            {
                var idn = new IdnMapping();
                string domainName = idn.GetAscii(match.Groups[2].Value);
                return match.Groups[1].Value + domainName;
            }, RegexOptions.None, TimeSpan.FromMilliseconds(200));

            // Check if the email matches the regex pattern
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
    }
}
