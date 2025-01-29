using PersonalComputerConfigurator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalComputerConfigurator.Services
{
    internal class ComponentsDictionary
    {
        public static readonly Dictionary<string, Type> tabModelMapping = new Dictionary<string, Type>
        {
            { "processorsTab", typeof(Processor) },
            { "motherboardsTab", typeof(Motherboard) },
            { "ramTab", typeof(RAM) },
            { "coolersTab", typeof(Cooler) },
            { "casesTab", typeof(Case) },
            { "hddTab", typeof(HDD) },
            { "ssdTab", typeof(SSD) },
            { "gpuTab", typeof(GPU) },
            { "psuTab", typeof(PSU) }
        };


    }
}
