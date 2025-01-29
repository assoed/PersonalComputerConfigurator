using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalComputerConfigurator.Models;

namespace PersonalComputerConfigurator.CustomControls
{
    public partial class HddUserControl : UserControl
    {
        private HDD _hdd;
        public HddUserControl(HDD hdd)
        {
            InitializeComponent();
            _hdd = hdd;

            setLabelsValue();
        }



        private void setLabelsValue()
        {
            nameValueLabel.Text = _hdd.Name;
            descriptionValueLabel.Text = _hdd.Description;
            speedValueLabel.Text = _hdd.Speed.ToString();
            capacityValueLabel.Text = _hdd.Capacity.ToString();
            priceValueLabel.Text = _hdd.Price.ToString();
        }

        private void HddUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
