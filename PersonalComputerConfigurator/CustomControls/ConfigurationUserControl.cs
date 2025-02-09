using PersonalComputerConfigurator.Forms;
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
    public partial class ConfigurationUserControl : UserControl
    {
        Configuration _configuration;

        private MainPageUserForm _mainForm;

        private MainPageForm _mainAdminForm;

        public void SetMainForm(MainPageUserForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void SetMainAdminForm(MainPageForm mainForm)
        {
            _mainAdminForm = mainForm;
        }

        public ConfigurationUserControl(Configuration configuration)
        {
            InitializeComponent();
           _configuration = configuration;
            setLabels();
        }

        private void setLabels()
        {
            configLabel.Text = $"{_configuration.Processor.Name} + {_configuration.GPU.Name} + {_configuration.GPU.Name}";
        }

        private void ConfigurationUserControl_Click(object sender, EventArgs e)
        {
            EditConfigForm editConfigForm = new EditConfigForm(_configuration);

            editConfigForm.ConfigurationUpdated += EditForm_ConfigurationUpdated;
            editConfigForm.ShowDialog();
        }

        private void EditForm_ConfigurationUpdated(object sender, EventArgs e)
        {
            _mainForm?.ShowConfigurations(); // Обновляем главную форму
            _mainAdminForm?.ShowConfigurations();
        }
    }
}
