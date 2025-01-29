using PersonalComputerConfigurator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalComputerConfigurator.Constants;

namespace PersonalComputerConfigurator.Services
{
    public static class UserSession
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string LastName { get; set; }
        public static string MiddleName { get; set; }
        public static string Login { get; set; }
        public static string Email { get; set; }
        public static int? RoleId { get; set; } = Constants.Constants.UserRoleId;

        // Метод для выхода из системы (очистка данных)
        public static void logOut()
        {
            Id = 0;
            Name = null;
            LastName = null;
            MiddleName = null;
            Login = null;
            Email = null;
        }

        public static void initialazeUser(User user)
        {
            Id = user.ID;
            Name = user.Name;
            LastName = user.LastName;
            MiddleName = user.MiddleName;
            Login = user.Login;
            Email = user.Email;
            RoleId = user.Role;
        }
    }
}
