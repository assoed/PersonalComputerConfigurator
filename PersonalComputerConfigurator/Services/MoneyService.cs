using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputerConfigurator.Services
{
    internal class MoneyService
    {
        public static int ToCents(int sum)
        {
            return sum * 100;
        }

        public static int ToRubles(int sum)
        {
            return sum / 100;
        }
    }
}
