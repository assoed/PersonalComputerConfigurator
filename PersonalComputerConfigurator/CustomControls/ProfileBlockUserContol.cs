using PersonalComputerConfigurator.Forms;
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

namespace PersonalComputerConfigurator.CustomControls
{
    public partial class ProfileBlockUserControl : UserControl
    {
        private UserSession _currentUser;

        public event EventHandler LogoutClicked;

        public event EventHandler ProfileClicked;

        public event EventHandler UserDataUpdated;

        public ProfileBlockUserControl(UserSession userSession)
        {
            InitializeComponent();
            _currentUser = userSession;
            UpdateProfileData();
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            _currentUser.logOut();

            LogoutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ProfileBlockUserControl_Load(object sender, EventArgs e)
        {
            userFIOLabel.Text = $"{_currentUser.lastName} {_currentUser.name} {_currentUser.middleName}";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(profilePictureBox, "Перейти в профиль");
            toolTip.SetToolTip(userFIOLabel, "Перейти в профиль");
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            ProfileClicked?.Invoke(this, EventArgs.Empty);
        }

        private void userFIOLabel_Click(object sender, EventArgs e)
        {
            ProfileClicked?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateProfileData()
        {
            userFIOLabel.Text = $"{_currentUser.lastName} {_currentUser.name} {_currentUser.middleName}";
        }
    }
}
