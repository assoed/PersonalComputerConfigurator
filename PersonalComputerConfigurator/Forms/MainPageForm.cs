using PersonalComputerConfigurator.CustomControls;
using PersonalComputerConfigurator.Models;
using PersonalComputerConfigurator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalComputerConfigurator.Constants;

namespace PersonalComputerConfigurator.Forms
{
    public partial class MainPageForm : Form
    {
        private ProfileBlockUserControl _profileBlock;

        public MainPageForm()
        {
            InitializeComponent();
        }


        private void MainPageForm_Load(object sender, EventArgs e)
        {
            // Создаем один экземпляр ProfileBlockUserControl
            _profileBlock = new ProfileBlockUserControl();

            _profileBlock.Location = new Point(this.ClientSize.Width - _profileBlock.Width - 10, 10);
            _profileBlock.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Подписка на события
            _profileBlock.LogoutClicked += UserControl_LogoutClicked;
            _profileBlock.ProfileClicked += UserControl_ProfileClicked;

            mainPageSplitContainer.Panel1.Controls.Add(_profileBlock);

            lastNameTextBox.Text = UserSession.LastName;
            nameTextBox.Text = UserSession.Name;
            middleNameTextBox.Text = UserSession.MiddleName;
            emailLabel.Text = UserSession.Email;
            loginLabel.Text = UserSession.Login;
            showProcessors(sender, e);
            showMotherboards(sender, e);
            showRAM(sender, e);
            showCoolers(sender, e);
            showUsers(sender, e);
            showCases(sender, e);
            showHDD(sender, e);
            showSSD(sender, e);
        }

        private void UserControl_LogoutClicked(object sender, EventArgs e)
        {
            // Закрываем текущую форму (MainPageForm)
            this.Hide();

            // Показать форму авторизации
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void ProcessorUserControl_EditFormDataSaved(object sender, EventArgs e)
        {
            // После сохранения данных обновляем отображение
            processorsFlowLayoutPanel.Controls.Clear();  // Очистка старых данных
            showProcessors(null, null);  // Перезагрузка процессоров
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_ProfileClicked(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = profileTabPage;
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            string newName = nameTextBox.Text;
            string newLastName = lastNameTextBox.Text;
            string newMiddleName = middleNameTextBox.Text;

            // Проверка на пустые данные
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newLastName) || string.IsNullOrWhiteSpace(newMiddleName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Получаем пользователя из базы данных с учетом его id
            var user = Program.context.User.FirstOrDefault(u => u.ID == UserSession.Id);

            if (user != null)
            {
                user.Name = newName;
                user.LastName = newLastName;
                user.MiddleName = newMiddleName;

                Program.context.SaveChanges();

                UserSession.Name = newName;
                UserSession.LastName = newLastName;
                UserSession.MiddleName = newMiddleName;

                MessageBox.Show("Данные успешно сохранены.");
            }

            _profileBlock.UpdateProfileData();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void showProcessors(object sender, EventArgs e)
        {
            processorsFlowLayoutPanel.Controls.Clear();

            List <Processor> processors = Program.context.Processor.ToList();

            foreach (Processor processor in processors)
            {
                processorsFlowLayoutPanel.Controls.Add(new ProcessorsUserControl(processor));
            }
        }

        private void showMotherboards(object sender, EventArgs e)
        {
            motherboardFlowLayoutPanel.Controls.Clear();

            List<Motherboard> motherboards = Program.context.Motherboard.ToList();

            foreach (Motherboard motherboard in motherboards)
            {
                motherboardFlowLayoutPanel.Controls.Add(new MotherboardsUserControl(motherboard));
            }
        }

        private void showRAM(object sender, EventArgs e)
        {
            ramFlowLayoutPanel.Controls.Clear();

            List<RAM> rams = Program.context.RAM.ToList();

            foreach (RAM ram in rams)
            {
                ramFlowLayoutPanel.Controls.Add(new RamUserControl(ram));
            }
        }

        private void showCoolers(object sender, EventArgs e)
        {
            coolersFlowLayoutPanel.Controls.Clear();

            List<Cooler> coolers = Program.context.Cooler.ToList();

            foreach (Cooler cooler in coolers)
            {
                coolersFlowLayoutPanel.Controls.Add(new CoolersUserControl(cooler));
            }
        }

        private void showCases(object sender, EventArgs e)
        {
            casesFlowLayoutPanel.Controls.Clear();

            List<Case> cases = Program.context.Case.ToList();

            foreach (Case pcCase in cases)
            {
                casesFlowLayoutPanel.Controls.Add(new CasesUserControl(pcCase));
            }
        }

        private void showHDD(object sender, EventArgs e)
        {
            hddFlowLayoutPanel.Controls.Clear();

            List<HDD> hdds = Program.context.HDD.ToList();

            foreach (HDD hdd in hdds)
            {
               hddFlowLayoutPanel.Controls.Add(new HddUserControl(hdd));
            }
        }


        private void showUsers(object sender, EventArgs e)
        {

            List<User> users = Program.context.User.ToList();

            foreach (User user in users)
            {
                usersEdtiorFlowLayoutPanel.Controls.Add(new UserEditorAdminControl(user));
            }
        }

        private void showSSD(object sender, EventArgs e)
        {
            ssdFlowLayoutPanel.Controls.Clear();

            List<SSD> ssds = Program.context.SSD.ToList();

            foreach (SSD ssd in ssds)
            {
                ssdFlowLayoutPanel.Controls.Add(new SsdUserControl(ssd));
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            showProcessors(sender, e);
            showMotherboards(sender, e);
            showRAM(sender, e);
            showCoolers(sender, e);
            showUsers(sender, e);
            showCases(sender, e);
            showHDD(sender, e);
            showSSD(sender, e);
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            // Получаем имя выбранной вкладки
            var selectedTab = adminTabControl.SelectedTab.Name; // Получаем имя текущей выбранной вкладки

            // Проверяем, есть ли для этой вкладки модель в словаре
            if (ComponentsDictionary.tabModelMapping.TryGetValue(selectedTab, out Type modelType))
            {
                // Создаем экземпляр модели с помощью рефлексии
                var modelInstance = Activator.CreateInstance(modelType);

                // Создаем форму редактирования
                GenericEditFormCreator formCreator = new GenericEditFormCreator();
                Form newEditForm = formCreator.CreateEditForm(modelInstance, isNewObject: true);

                // Показываем форму
                newEditForm.ShowDialog();
            }
            else
            {
                // Если для вкладки нет соответствующей модели, показываем сообщение об ошибке
                MessageBox.Show("Для этой вкладки нет связанной модели.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void updateButton_Click_1(object sender, EventArgs e)
        {

        }

        private void ramFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private bool IsAdmin()
        {

            if (UserSession.RoleId == Constants.Constants.AdministratorRoleId)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Удаляем процессор из базы данных
                var userToDelete = Program.context.User.FirstOrDefault(p => p.ID == UserSession.Id);
                if (userToDelete != null)
                {
                    Program.context.User.Remove(userToDelete);
                    Program.context.SaveChanges();

                    Controls.Remove(this);
                    MessageBox.Show("Пользователь успешно удален.");
                }
            }
        }
    }  
}
