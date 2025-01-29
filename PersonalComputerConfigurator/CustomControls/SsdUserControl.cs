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
    public partial class SsdUserControl : UserControl
    {
        private SSD _ssd;
        public SsdUserControl(SSD ssd)
        {
            InitializeComponent();
            _ssd = ssd;
            setLabelsValue();
        }

        private void setLabelsValue()
        {
            nameValueLabel.Text = _ssd.Name;
            descriptionValueLabel.Text = _ssd.Description;
            readingValueLabel.Text = _ssd.Reading.ToString();
            capacityValueLabel.Text = _ssd.Capacity.ToString();
            writingValueLabel.Text = _ssd.Writing.ToString();
            priceValueLabel.Text = _ssd.Price.ToString();
        }

        private void readLabel_Click(object sender, EventArgs e)
        {

        }

        private void writingLabel_Click(object sender, EventArgs e)
        {

        }

        private void writingValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void readingValueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
