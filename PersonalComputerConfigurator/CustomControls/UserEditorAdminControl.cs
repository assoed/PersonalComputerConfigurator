using PersonalComputerConfigurator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalComputerConfigurator.Forms;
using PersonalComputerConfigurator.Services;

namespace PersonalComputerConfigurator.CustomControls
{
    public partial class UserEditorAdminControl : UserControl
    {
        private User _user;

        public UserEditorAdminControl(User users)
        {
            InitializeComponent();
            _user = users;
            setLabelsValue();


        }

        private void setLabelsValue()
        {
            firstNameValueLabel.Text = _user.Name;
            LastNameValueLabel.Text = _user.LastName;
            MiddleNameValueLabel.Text = _user.MiddleName;
            roleValueLabel.Text = _user.UserRole?.RoleName;
            EmailValueLabel.Text = _user.Email;
            loginValueLabel.Text = _user.Login;
            IdValueLabel.Text = _user.ID.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void IdValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var userToDelete = Program.context.User.FirstOrDefault(p => p.ID == _user.ID);
                if (userToDelete != null && userToDelete.IsBlocked == 1)
                {
                    Program.context.User.Remove(userToDelete);
                    Program.context.SaveChanges();

                    Controls.Remove(this);
                    MessageBox.Show("Пользователь успешно удален.");
                }
            }
        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {
            UserEditForm userEditForm = new UserEditForm(_user.ID);
            userEditForm.ShowDialog();
        }

        private void blockUserPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите за этого пользователя", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var userToBlock = Program.context.User.FirstOrDefault(p => p.ID == _user.ID);
                userToBlock.IsBlocked = 1;
                if (userToBlock != null)
                {
                    Program.context.SaveChanges();
                    MessageBox.Show("Пользователь успешно заблокирован.");
                }
            }
        }

        private void UserEditorAdminControl_Load(object sender, EventArgs e)
        {
            if ( _user.IsBlocked == 0) 
            { 
                deletePictureBox.Visible = false;
                deletePictureBox.Enabled = false;
                unblockUserPictureBox.Visible = false;
                unblockUserPictureBox.Enabled = false;
            }
            else
            {
                blockUserPictureBox.Visible = false;
                blockUserPictureBox.Enabled = false;
                deletePictureBox.Visible = true;
                deletePictureBox.Enabled = true;
                unblockUserPictureBox.Visible = true;
                unblockUserPictureBox.Enabled = true;
            }
        }

        private void unblockUserPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Разблокировать этого пользователя?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var userToBlock = Program.context.User.FirstOrDefault(p => p.ID == _user.ID);
                userToBlock.IsBlocked = 0;
                if (userToBlock != null)
                {
                    Program.context.SaveChanges();
                    MessageBox.Show("Пользователь успешно разблокирован.");
                }
            }
        }
    }
}
