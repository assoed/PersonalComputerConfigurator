using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputerConfigurator.Services
{
    internal class TranslateService
    {
        private static readonly Dictionary<string, string> TranslationDictionary = new Dictionary<string, string>
    {   { "id", "ИДЕНТИФИКАТОР" },
        { "name", "ИМЯ" },
        { "description", "ОПИСАНИЕ" },
        { "socket", "СОКЕТ" },
        { "tdp", "ПОТРЕБЛЕНИЕ МОЩНОСТИ (TDP)" },
        { "frequency", "ЧАСТОТА" },
        { "boost", "БУСТ" },
        { "cores", "ЯДРА" },
        { "threads", "ПОТОКИ" },
        { "price", "ЦЕНА" }
    };

        public static string translate(string input)
        {
            if (TranslationDictionary.TryGetValue(input, out string translation))
            {
                return translation;
            }
            return input;
        }
    }
}
