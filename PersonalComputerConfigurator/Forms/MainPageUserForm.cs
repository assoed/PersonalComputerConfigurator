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
    public partial class MainPageUserForm : Form
    {
     
        public MainPageUserForm()
        {
            InitializeComponent();
        }
   
        private void MainPageUserForm_Load(object sender, EventArgs e)
        {

            var processors = Program.context.Processor.ToList();

            // Преобразуем в список анонимных объектов
            var processorList = processors.Select(p => new
            {
                ID = p.ID,
                FullName = p.FullName  // Это свойство из модели Processor
            }).ToList();

            processorComboBox.DataSource = processorList;
            processorComboBox.DisplayMember = "FullName";
            processorComboBox.ValueMember   = "ID";

            SetupProfileBlock();
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить свой профиль?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var userToDelete = Program.context.User.FirstOrDefault(p => p.ID == UserSession.Id);
                if (userToDelete != null)
                {
                    Program.context.User.Remove(userToDelete);
                    Program.context.SaveChanges();

                    Controls.Remove(this);
                    MessageBox.Show("Ваш профиль удален. Вы будете перенаправлены на страницу аутентификации");
                }

                UserSession.logOut();
                this.Close();
                
                AuthorizationForm form = new AuthorizationForm();
                form.ShowDialog();
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
            userTabControl.SelectedTab = userProfileTab;
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
    }
}
