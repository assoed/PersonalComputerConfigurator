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

namespace PersonalComputerConfigurator.CustomControls
{
    public partial class CasesUserControl : UserControl
    {
        private Case _pcCase;


        public CasesUserControl(Case pcCase)
        {
            InitializeComponent();
            _pcCase = pcCase;
            UserRightsSegregation userRightsSegregation = new UserRightsSegregation();
            userRightsSegregation.SetButtonsVisibilityAndEnabledState(this);
        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
