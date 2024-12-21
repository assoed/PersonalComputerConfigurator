using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputerConfigurator.Services
{
    public class UserSession
    {
        // Свойства для хранения информации о пользователе
        public int id { get; set; }               // ID пользователя
        public string name { get; set; }          // Имя пользователя
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }         // Логин пользователя
        public string email { get; set; }         // Email пользователя

        // Метод, позволяющий проверить, авторизован ли пользователь
        public bool IsAuthenticated => id > 0;

        // Метод для выхода из системы (очистка данных)
        public void logOut()
        {
            id = 0;
            name = null;
            login = null;
            email = null;
            lastName = null;
            middleName = null;
        }
    }

}
