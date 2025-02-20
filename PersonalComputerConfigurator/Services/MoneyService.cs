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
        /// <summary>
        /// Преобразует сумму из рублей в копейки.
        /// </summary>
        public static int ToCents(double rubles)
        {
            return (int)(rubles * 100);
        }

        /// <summary>
        /// Преобразует сумму из копеек в строку с рублями, форматируя до 2 знаков после запятой.
        /// </summary>
        public static string ToRubles(int cents)
        {
            return (cents / 100.0).ToString("F2");
        }

        /// <summary>
        /// Преобразует сумму из строки с рублями обратно в копейки.
        /// </summary>
        public static int FromRublesToCents(string rublesString)
        {
            if (double.TryParse(rublesString, out double rubles))
            {
                return (int)(rubles * 100);
            }
            throw new FormatException("Некорректный формат суммы в рублях.");
        }
    }
}