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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageUserForm));
            this.mainPageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.logoutButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.PictureBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.userFIOLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.PictureBox();
            this.userTabControl = new System.Windows.Forms.TabControl();
            this.userProfileTab = new System.Windows.Forms.TabPage();
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
            this.UsersUserConfigurationsTab = new System.Windows.Forms.TabPage();
            this.ConfiguratorTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processorComboBox = new System.Windows.Forms.ComboBox();
            this.personalComputerConfiguratorDatabaseDataSet1 = new PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSet1();
            this.personalComputerConfiguratorDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processorTableAdapter = new PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSet1TableAdapters.ProcessorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageSplitContainer)).BeginInit();
            this.mainPageSplitContainer.Panel1.SuspendLayout();
            this.mainPageSplitContainer.Panel2.SuspendLayout();
            this.mainPageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).BeginInit();
            this.userTabControl.SuspendLayout();
            this.userProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.ConfiguratorTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalComputerConfiguratorDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalComputerConfiguratorDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).BeginInit();
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
            this.mainPageSplitContainer.Panel1.Controls.Add(this.logoutButton);
            this.mainPageSplitContainer.Panel1.Controls.Add(this.addNewButton);
            this.mainPageSplitContainer.Panel1.Controls.Add(this.profilePictureBox);
            this.mainPageSplitContainer.Panel1.Controls.Add(this.userFIOLabel);
            this.mainPageSplitContainer.Panel1.Controls.Add(this.updateButton);
            // 
            // mainPageSplitContainer.Panel2
            // 
            this.mainPageSplitContainer.Panel2.Controls.Add(this.userTabControl);
            this.mainPageSplitContainer.Size = new System.Drawing.Size(1325, 694);
            this.mainPageSplitContainer.SplitterDistance = 90;
            this.mainPageSplitContainer.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1239, 48);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(70, 20);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "ВЫЙТИ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(1006, 18);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(50, 50);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 10;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // userFIOLabel
            // 
            this.userFIOLabel.AutoSize = true;
            this.userFIOLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userFIOLabel.Location = new System.Drawing.Point(1075, 18);
            this.userFIOLabel.Name = "userFIOLabel";
            this.userFIOLabel.Size = new System.Drawing.Size(24, 13);
            this.userFIOLabel.TabIndex = 11;
            this.userFIOLabel.Text = "FIO";
            this.userFIOLabel.Click += new System.EventHandler(this.profilePictureBox_Click);
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
            this.userTabControl.Controls.Add(this.userProfileTab);
            this.userTabControl.Controls.Add(this.UsersUserConfigurationsTab);
            this.userTabControl.Controls.Add(this.ConfiguratorTab);
            this.userTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTabControl.Location = new System.Drawing.Point(0, 0);
            this.userTabControl.Name = "userTabControl";
            this.userTabControl.SelectedIndex = 0;
            this.userTabControl.Size = new System.Drawing.Size(1325, 600);
            this.userTabControl.TabIndex = 6;
            // 
            // userProfileTab
            // 
            this.userProfileTab.Controls.Add(this.deleteProfileLabel);
            this.userProfileTab.Controls.Add(this.deletePictureBox);
            this.userProfileTab.Controls.Add(this.saveProfileButton);
            this.userProfileTab.Controls.Add(this.yourProfileLabel);
            this.userProfileTab.Controls.Add(this.loginLabel);
            this.userProfileTab.Controls.Add(this.emailLabel);
            this.userProfileTab.Controls.Add(this.emailTextLabel);
            this.userProfileTab.Controls.Add(this.loginTextLabel);
            this.userProfileTab.Controls.Add(this.lastNameLabel);
            this.userProfileTab.Controls.Add(this.middleNameLabel);
            this.userProfileTab.Controls.Add(this.nameLabel);
            this.userProfileTab.Controls.Add(this.lastNameTextBox);
            this.userProfileTab.Controls.Add(this.middleNameTextBox);
            this.userProfileTab.Controls.Add(this.nameTextBox);
            this.userProfileTab.Location = new System.Drawing.Point(4, 22);
            this.userProfileTab.Name = "userProfileTab";
            this.userProfileTab.Padding = new System.Windows.Forms.Padding(3);
            this.userProfileTab.Size = new System.Drawing.Size(1317, 574);
            this.userProfileTab.TabIndex = 0;
            this.userProfileTab.Text = "МОЙ ПРОФИЛЬ";
            this.userProfileTab.UseVisualStyleBackColor = true;
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
            this.saveProfileButton.Click += new System.EventHandler(this.saveProfileButton_Click);
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
            // UsersUserConfigurationsTab
            // 
            this.UsersUserConfigurationsTab.Location = new System.Drawing.Point(4, 22);
            this.UsersUserConfigurationsTab.Name = "UsersUserConfigurationsTab";
            this.UsersUserConfigurationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersUserConfigurationsTab.Size = new System.Drawing.Size(1317, 574);
            this.UsersUserConfigurationsTab.TabIndex = 1;
            this.UsersUserConfigurationsTab.Text = "МОИ СБОРКИ";
            this.UsersUserConfigurationsTab.UseVisualStyleBackColor = true;
            // 
            // ConfiguratorTab
            // 
            this.ConfiguratorTab.Controls.Add(this.groupBox1);
            this.ConfiguratorTab.Location = new System.Drawing.Point(4, 22);
            this.ConfiguratorTab.Name = "ConfiguratorTab";
            this.ConfiguratorTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfiguratorTab.Size = new System.Drawing.Size(1317, 574);
            this.ConfiguratorTab.TabIndex = 2;
            this.ConfiguratorTab.Text = "СОБРАТЬ ПК";
            this.ConfiguratorTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.processorComboBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // processorComboBox
            // 
            this.processorComboBox.DataSource = this.processorBindingSource;
            this.processorComboBox.DisplayMember = "Name";
            this.processorComboBox.FormattingEnabled = true;
            this.processorComboBox.Location = new System.Drawing.Point(6, 32);
            this.processorComboBox.Name = "processorComboBox";
            this.processorComboBox.Size = new System.Drawing.Size(301, 21);
            this.processorComboBox.TabIndex = 0;
            this.processorComboBox.ValueMember = "ID";
            // 
            // personalComputerConfiguratorDatabaseDataSet1
            // 
            this.personalComputerConfiguratorDatabaseDataSet1.DataSetName = "personalComputerConfiguratorDatabaseDataSet1";
            this.personalComputerConfiguratorDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalComputerConfiguratorDatabaseDataSet1BindingSource
            // 
            this.personalComputerConfiguratorDatabaseDataSet1BindingSource.DataSource = this.personalComputerConfiguratorDatabaseDataSet1;
            this.personalComputerConfiguratorDatabaseDataSet1BindingSource.Position = 0;
            // 
            // processorBindingSource
            // 
            this.processorBindingSource.DataMember = "Processor";
            this.processorBindingSource.DataSource = this.personalComputerConfiguratorDatabaseDataSet1BindingSource;
            // 
            // processorTableAdapter
            // 
            this.processorTableAdapter.ClearBeforeFill = true;
            // 
            // MainPageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Controls.Add(this.mainPageSplitContainer);
            this.Name = "MainPageUserForm";
            this.Text = "КОНФИГУРАТОР ПК";
            this.Load += new System.EventHandler(this.MainPageUserForm_Load);
            this.mainPageSplitContainer.Panel1.ResumeLayout(false);
            this.mainPageSplitContainer.Panel1.PerformLayout();
            this.mainPageSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPageSplitContainer)).EndInit();
            this.mainPageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addNewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).EndInit();
            this.userTabControl.ResumeLayout(false);
            this.userProfileTab.ResumeLayout(false);
            this.userProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ConfiguratorTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personalComputerConfiguratorDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalComputerConfiguratorDatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainPageSplitContainer;
        private System.Windows.Forms.PictureBox addNewButton;
        private System.Windows.Forms.PictureBox updateButton;
        private System.Windows.Forms.TabControl userTabControl;
        private System.Windows.Forms.TabPage userProfileTab;
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
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label userFIOLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox processorComboBox;
        private System.Windows.Forms.BindingSource personalComputerConfiguratorDatabaseDataSet1BindingSource;
        private personalComputerConfiguratorDatabaseDataSet1 personalComputerConfiguratorDatabaseDataSet1;
        private System.Windows.Forms.BindingSource processorBindingSource;
        private personalComputerConfiguratorDatabaseDataSet1TableAdapters.ProcessorTableAdapter processorTableAdapter;
    }
}