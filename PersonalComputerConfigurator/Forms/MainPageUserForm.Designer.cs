namespace PersonalComputerConfigurator.Forms
{
    partial class MainPageUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageUserForm));
            this.mainPageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addNewButton = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.PictureBox();
            this.userTabControl = new System.Windows.Forms.TabControl();
            this.UserProfileTab = new System.Windows.Forms.TabPage();
            this.UsersUserConfigurationsTab = new System.Windows.Forms.TabPage();
            this.ConfiguratorTab = new System.Windows.Forms.TabPage();
            this.deleteProfileLabel = new System.Windows.Forms.Label();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.saveProfileButton = new System.Windows.Forms.Button();
            this.yourProfileLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextLabel = new System.Windows.Forms.Label();
            this.loginTextLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageSplitContainer)).BeginInit();
            this.mainPageSplitContainer.Panel1.SuspendLayout();
            this.mainPageSplitContainer.Panel2.SuspendLayout();
            this.mainPageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).BeginInit();
            this.userTabControl.SuspendLayout();
            this.UserProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPageSplitContainer
            // 
            this.mainPageSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainPageSplitContainer.Name = "mainPageSplitContainer";
            this.mainPageSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainPageSplitContainer.Panel1
            // 
            this.mainPageSplitContainer.Panel1.Controls.Add(this.addNewButton);
            this.mainPageSplitContainer.Panel1.Controls.Add(this.updateButton);
            // 
            // mainPageSplitContainer.Panel2
            // 
            this.mainPageSplitContainer.Panel2.Controls.Add(this.userTabControl);
            this.mainPageSplitContainer.Size = new System.Drawing.Size(1118, 694);
            this.mainPageSplitContainer.SplitterDistance = 90;
            this.mainPageSplitContainer.TabIndex = 1;
            // 
            // addNewButton
            // 
            this.addNewButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewButton.Image")));
            this.addNewButton.Location = new System.Drawing.Point(60, 46);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(43, 31);
            this.addNewButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addNewButton.TabIndex = 0;
            this.addNewButton.TabStop = false;
            // 
            // updateButton
            // 
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(12, 46);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(42, 31);
            this.updateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateButton.TabIndex = 1;
            this.updateButton.TabStop = false;
            // 
            // userTabControl
            // 
            this.userTabControl.Controls.Add(this.UserProfileTab);
            this.userTabControl.Controls.Add(this.UsersUserConfigurationsTab);
            this.userTabControl.Controls.Add(this.ConfiguratorTab);
            this.userTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTabControl.Location = new System.Drawing.Point(0, 0);
            this.userTabControl.Name = "userTabControl";
            this.userTabControl.SelectedIndex = 0;
            this.userTabControl.Size = new System.Drawing.Size(1118, 600);
            this.userTabControl.TabIndex = 6;
            // 
            // UserProfileTab
            // 
            this.UserProfileTab.Controls.Add(this.deleteProfileLabel);
            this.UserProfileTab.Controls.Add(this.deletePictureBox);
            this.UserProfileTab.Controls.Add(this.saveProfileButton);
            this.UserProfileTab.Controls.Add(this.yourProfileLabel);
            this.UserProfileTab.Controls.Add(this.loginLabel);
            this.UserProfileTab.Controls.Add(this.emailLabel);
            this.UserProfileTab.Controls.Add(this.emailTextLabel);
            this.UserProfileTab.Controls.Add(this.loginTextLabel);
            this.UserProfileTab.Controls.Add(this.lastNameLabel);
            this.UserProfileTab.Controls.Add(this.middleNameLabel);
            this.UserProfileTab.Controls.Add(this.nameLabel);
            this.UserProfileTab.Controls.Add(this.lastNameTextBox);
            this.UserProfileTab.Controls.Add(this.middleNameTextBox);
            this.UserProfileTab.Controls.Add(this.nameTextBox);
            this.UserProfileTab.Location = new System.Drawing.Point(4, 22);
            this.UserProfileTab.Name = "UserProfileTab";
            this.UserProfileTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserProfileTab.Size = new System.Drawing.Size(1110, 574);
            this.UserProfileTab.TabIndex = 0;
            this.UserProfileTab.Text = "МОЙ ПРОФИЛЬ";
            this.UserProfileTab.UseVisualStyleBackColor = true;
            // 
            // UsersUserConfigurationsTab
            // 
            this.UsersUserConfigurationsTab.Location = new System.Drawing.Point(4, 22);
            this.UsersUserConfigurationsTab.Name = "UsersUserConfigurationsTab";
            this.UsersUserConfigurationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersUserConfigurationsTab.Size = new System.Drawing.Size(1110, 626);
            this.UsersUserConfigurationsTab.TabIndex = 1;
            this.UsersUserConfigurationsTab.Text = "МОИ СБОРКИ";
            this.UsersUserConfigurationsTab.UseVisualStyleBackColor = true;
            // 
            // ConfiguratorTab
            // 
            this.ConfiguratorTab.Location = new System.Drawing.Point(4, 22);
            this.ConfiguratorTab.Name = "ConfiguratorTab";
            this.ConfiguratorTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfiguratorTab.Size = new System.Drawing.Size(1110, 626);
            this.ConfiguratorTab.TabIndex = 2;
            this.ConfiguratorTab.Text = "СОБРАТЬ ПК";
            this.ConfiguratorTab.UseVisualStyleBackColor = true;
            // 
            // deleteProfileLabel
            // 
            this.deleteProfileLabel.AutoSize = true;
            this.deleteProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deleteProfileLabel.Location = new System.Drawing.Point(788, 448);
            this.deleteProfileLabel.Name = "deleteProfileLabel";
            this.deleteProfileLabel.Size = new System.Drawing.Size(235, 26);
            this.deleteProfileLabel.TabIndex = 101;
            this.deleteProfileLabel.Text = "УДАЛИТЬ ПРОФИЛЬ";
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(1029, 439);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(43, 46);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 100;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.saveProfileButton.Location = new System.Drawing.Point(309, 468);
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(217, 31);
            this.saveProfileButton.TabIndex = 99;
            this.saveProfileButton.Text = "СОХРАНИТЬ";
            this.saveProfileButton.UseVisualStyleBackColor = true;
            // 
            // yourProfileLabel
            // 
            this.yourProfileLabel.AutoSize = true;
            this.yourProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.yourProfileLabel.Location = new System.Drawing.Point(304, 128);
            this.yourProfileLabel.Name = "yourProfileLabel";
            this.yourProfileLabel.Size = new System.Drawing.Size(180, 26);
            this.yourProfileLabel.TabIndex = 98;
            this.yourProfileLabel.Text = "ВАШ ПРОФИЛЬ";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(184, 342);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(45, 13);
            this.loginLabel.TabIndex = 97;
            this.loginLabel.Text = "ЛОГИН";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(184, 380);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(130, 13);
            this.emailLabel.TabIndex = 96;
            this.emailLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // emailTextLabel
            // 
            this.emailTextLabel.AutoSize = true;
            this.emailTextLabel.Location = new System.Drawing.Point(39, 380);
            this.emailTextLabel.Name = "emailTextLabel";
            this.emailTextLabel.Size = new System.Drawing.Size(130, 13);
            this.emailTextLabel.TabIndex = 95;
            this.emailTextLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // loginTextLabel
            // 
            this.loginTextLabel.AutoSize = true;
            this.loginTextLabel.Location = new System.Drawing.Point(124, 342);
            this.loginTextLabel.Name = "loginTextLabel";
            this.loginTextLabel.Size = new System.Drawing.Size(45, 13);
            this.loginTextLabel.TabIndex = 94;
            this.loginTextLabel.Text = "ЛОГИН";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(103, 214);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.lastNameLabel.TabIndex = 93;
            this.lastNameLabel.Text = "ФАМИЛИЯ";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(103, 300);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.middleNameLabel.TabIndex = 91;
            this.middleNameLabel.Text = "ОТЧЕСТВО";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(137, 260);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 92;
            this.nameLabel.Text = "ИМЯ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(175, 214);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.lastNameTextBox.TabIndex = 90;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(175, 300);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.middleNameTextBox.TabIndex = 89;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(175, 257);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(278, 20);
            this.nameTextBox.TabIndex = 88;
            // 
            // MainPageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 694);
            this.Controls.Add(this.mainPageSplitContainer);
            this.Name = "MainPageUserForm";
            this.Text = "КОНФИГУРАТОР ПК";
            this.Load += new System.EventHandler(this.MainPageUserForm_Load);
            this.mainPageSplitContainer.Panel1.ResumeLayout(false);
            this.mainPageSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPageSplitContainer)).EndInit();
            this.mainPageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addNewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).EndInit();
            this.userTabControl.ResumeLayout(false);
            this.UserProfileTab.ResumeLayout(false);
            this.UserProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainPageSplitContainer;
        private System.Windows.Forms.PictureBox addNewButton;
        private System.Windows.Forms.PictureBox updateButton;
        private System.Windows.Forms.TabControl userTabControl;
        private System.Windows.Forms.TabPage UserProfileTab;
        private System.Windows.Forms.TabPage UsersUserConfigurationsTab;
        private System.Windows.Forms.TabPage ConfiguratorTab;
        private System.Windows.Forms.Label deleteProfileLabel;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.Button saveProfileButton;
        private System.Windows.Forms.Label yourProfileLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label emailTextLabel;
        private System.Windows.Forms.Label loginTextLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}