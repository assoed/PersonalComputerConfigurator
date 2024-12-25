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
            { "processorsTab", typeof(processors) },
            { "motherboardsTab", typeof(motherboards) },
            { "ramTab", typeof(ram) },
            { "coolersTab", typeof(coolers) },
            { "casesTab", typeof(cases) },
            { "hddTab", typeof(hdd) },
            { "ssdTab", typeof(ssd) },
            { "gpuTab", typeof(gpu) },
            { "psuTab", typeof(psu) }
        };


    }
}
