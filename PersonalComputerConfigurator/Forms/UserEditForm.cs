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


namespace PersonalComputerConfigurator.Forms
{
    public partial class UserEditForm : Form
    {
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
            this.userRoleTableAdapter.FillBy(this.personalComputerConfiguratorDatabaseDataSet.userRole);
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


            var existingUser = Program.context.User.FirstOrDefault(u => u.ID == _userId);
    
            if (existingUser == null)
            {
                MessageBox.Show("Ошибка: пользователь не найден.");
                return;
            }

            // Обновляем данные пользователя
            existingUser.Name = firstName;
            existingUser.MiddleName = middleName;
            existingUser.LastName = lastName;
            existingUser.Role = roleId;

            // Сохраняем изменения в базе данных
            Program.context.SaveChanges();

            MessageBox.Show("Данные пользователя успешно обновлены!");

            this.Close();
        }
    }
}
