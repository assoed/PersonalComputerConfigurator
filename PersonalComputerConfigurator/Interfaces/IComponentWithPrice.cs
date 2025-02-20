using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputerConfigurator.Interfaces
{
    public interface IComponentWithPrice
    {
        string Name { get; }
        int Price { get; }
    }
}
