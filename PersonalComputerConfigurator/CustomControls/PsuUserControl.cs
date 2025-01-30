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
using PersonalComputerConfigurator.Models;


namespace PersonalComputerConfigurator.CustomControls
{

    public partial class PsuUserControl : UserControl
    {
        private PSU _psu;

        public PsuUserControl(PSU psu)
        {
            InitializeComponent();
            _psu = psu;
        }
    }
}
