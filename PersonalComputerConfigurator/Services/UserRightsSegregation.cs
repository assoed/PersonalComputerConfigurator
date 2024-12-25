using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalComputerConfigurator.Services
{
    internal class UserRightsSegregation
    {
        public void SetButtonsVisibilityAndEnabledState(UserControl userControl)
        {
            // Ищем PictureBox элементы по имени или типу
            var editPictureBox = userControl.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "editPictureBox");
            var deletePictureBox = userControl.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "deletePictureBox");

            // Проверка, если роль пользователя не администратор (предположим, что роль администратора — это 1)
            if (UserSession.RoleId != 1)  // Если роль не администратора
            {
                // Делать кнопки неактивными и невидимыми
                if (editPictureBox != null)
                {
                    editPictureBox.Enabled = false;  // Отключаем кнопку редактирования
                    editPictureBox.Visible = false;  // Скрываем кнопку редактирования
                }

                if (deletePictureBox != null)
                {
                    deletePictureBox.Enabled = false;  // Отключаем кнопку удаления
                    deletePictureBox.Visible = false;  // Скрываем кнопку удаления
                }
            }
            else
            {
                // Включаем кнопки и делаем их видимыми, если роль администратора
                if (editPictureBox != null)
                {
                    editPictureBox.Enabled = true;
                    editPictureBox.Visible = true;
                }

                if (deletePictureBox != null)
                {
                    deletePictureBox.Enabled = true;
                    deletePictureBox.Visible = true;
                }
            }
        }
    }
}
