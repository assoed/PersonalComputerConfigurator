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
        private ProfileBlockUserControl _profileBlock;

        public MainPageUserForm()
        {
            InitializeComponent();
        }
   
        private void MainPageUserForm_Load(object sender, EventArgs e)
        {
            // Создаем один экземпляр ProfileBlockUserControl
            _profileBlock = new ProfileBlockUserControl();

            _profileBlock.Location = new Point(this.ClientSize.Width - _profileBlock.Width - 10, 10);
            _profileBlock.Anchor = AnchorStyles.Top | AnchorStyles.Right;


            mainPageSplitContainer.Panel1.Controls.Add(_profileBlock);

            lastNameTextBox.Text = UserSession.LastName;
            nameTextBox.Text = UserSession.Name;
            middleNameTextBox.Text = UserSession.MiddleName;
            emailLabel.Text = UserSession.Email;
            loginLabel.Text = UserSession.Login;
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
    }
}
