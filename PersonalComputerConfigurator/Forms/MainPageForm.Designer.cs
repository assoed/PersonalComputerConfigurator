namespace PersonalComputerConfigurator.Forms
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.mainPageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.updateButton = new System.Windows.Forms.PictureBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.userConfigurationsTab = new System.Windows.Forms.TabPage();
            this.profileTabPage = new System.Windows.Forms.TabPage();
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
            this.processorsTab = new System.Windows.Forms.TabPage();
            this.processorsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.motherboardsTab = new System.Windows.Forms.TabPage();
            this.ramTab = new System.Windows.Forms.TabPage();
            this.coolersTab = new System.Windows.Forms.TabPage();
            this.casesTab = new System.Windows.Forms.TabPage();
            this.hddTab = new System.Windows.Forms.TabPage();
            this.ssdTab = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageSplitContainer)).BeginInit();
            this.mainPageSplitContainer.Panel2.SuspendLayout();
            this.mainPageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.userConfigurationsTab.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.processorsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPageSplitContainer
            // 
            this.mainPageSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainPageSplitContainer.Name = "mainPageSplitContainer";
            this.mainPageSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainPageSplitContainer.Panel2
            // 
            this.mainPageSplitContainer.Panel2.Controls.Add(this.mainTabControl);
            this.mainPageSplitContainer.Size = new System.Drawing.Size(1118, 694);
            this.mainPageSplitContainer.SplitterDistance = 60;
            this.mainPageSplitContainer.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(182, 87);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(39, 33);
            this.updateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateButton.TabIndex = 1;
            this.updateButton.TabStop = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.userConfigurationsTab);
            this.mainTabControl.Controls.Add(this.profileTabPage);
            this.mainTabControl.Controls.Add(this.processorsTab);
            this.mainTabControl.Controls.Add(this.motherboardsTab);
            this.mainTabControl.Controls.Add(this.ramTab);
            this.mainTabControl.Controls.Add(this.coolersTab);
            this.mainTabControl.Controls.Add(this.casesTab);
            this.mainTabControl.Controls.Add(this.hddTab);
            this.mainTabControl.Controls.Add(this.ssdTab);
            this.mainTabControl.Controls.Add(this.tabPage6);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1118, 630);
            this.mainTabControl.TabIndex = 2;
            // 
            // userConfigurationsTab
            // 
            this.userConfigurationsTab.Controls.Add(this.updateButton);
            this.userConfigurationsTab.Location = new System.Drawing.Point(4, 22);
            this.userConfigurationsTab.Name = "userConfigurationsTab";
            this.userConfigurationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.userConfigurationsTab.Size = new System.Drawing.Size(1110, 604);
            this.userConfigurationsTab.TabIndex = 1;
            this.userConfigurationsTab.Text = "МОИ СБОРКИ";
            this.userConfigurationsTab.UseVisualStyleBackColor = true;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.saveProfileButton);
            this.profileTabPage.Controls.Add(this.yourProfileLabel);
            this.profileTabPage.Controls.Add(this.loginLabel);
            this.profileTabPage.Controls.Add(this.emailLabel);
            this.profileTabPage.Controls.Add(this.emailTextLabel);
            this.profileTabPage.Controls.Add(this.loginTextLabel);
            this.profileTabPage.Controls.Add(this.lastNameLabel);
            this.profileTabPage.Controls.Add(this.middleNameLabel);
            this.profileTabPage.Controls.Add(this.nameLabel);
            this.profileTabPage.Controls.Add(this.lastNameTextBox);
            this.profileTabPage.Controls.Add(this.middleNameTextBox);
            this.profileTabPage.Controls.Add(this.nameTextBox);
            this.profileTabPage.Location = new System.Drawing.Point(4, 22);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(1110, 607);
            this.profileTabPage.TabIndex = 2;
            this.profileTabPage.Text = "МОЙ ПРОФИЛЬ";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.saveProfileButton.Location = new System.Drawing.Point(328, 467);
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(217, 31);
            this.saveProfileButton.TabIndex = 45;
            this.saveProfileButton.Text = "СОХРАНИТЬ";
            this.saveProfileButton.UseVisualStyleBackColor = true;
            // 
            // yourProfileLabel
            // 
            this.yourProfileLabel.AutoSize = true;
            this.yourProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.yourProfileLabel.Location = new System.Drawing.Point(323, 127);
            this.yourProfileLabel.Name = "yourProfileLabel";
            this.yourProfileLabel.Size = new System.Drawing.Size(180, 26);
            this.yourProfileLabel.TabIndex = 44;
            this.yourProfileLabel.Text = "ВАШ ПРОФИЛЬ";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(203, 341);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(45, 13);
            this.loginLabel.TabIndex = 43;
            this.loginLabel.Text = "ЛОГИН";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(203, 379);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(130, 13);
            this.emailLabel.TabIndex = 42;
            this.emailLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // emailTextLabel
            // 
            this.emailTextLabel.AutoSize = true;
            this.emailTextLabel.Location = new System.Drawing.Point(58, 379);
            this.emailTextLabel.Name = "emailTextLabel";
            this.emailTextLabel.Size = new System.Drawing.Size(130, 13);
            this.emailTextLabel.TabIndex = 41;
            this.emailTextLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // loginTextLabel
            // 
            this.loginTextLabel.AutoSize = true;
            this.loginTextLabel.Location = new System.Drawing.Point(143, 341);
            this.loginTextLabel.Name = "loginTextLabel";
            this.loginTextLabel.Size = new System.Drawing.Size(45, 13);
            this.loginTextLabel.TabIndex = 40;
            this.loginTextLabel.Text = "ЛОГИН";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(122, 213);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.lastNameLabel.TabIndex = 39;
            this.lastNameLabel.Text = "ФАМИЛИЯ";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(122, 299);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.middleNameLabel.TabIndex = 37;
            this.middleNameLabel.Text = "ОТЧЕСТВО";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(156, 259);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "ИМЯ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(194, 213);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.lastNameTextBox.TabIndex = 36;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(194, 299);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.middleNameTextBox.TabIndex = 35;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(194, 256);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nameTextBox.TabIndex = 34;
            // 
            // processorsTab
            // 
            this.processorsTab.Controls.Add(this.processorsFlowLayoutPanel);
            this.processorsTab.Location = new System.Drawing.Point(4, 22);
            this.processorsTab.Name = "processorsTab";
            this.processorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.processorsTab.Size = new System.Drawing.Size(1110, 607);
            this.processorsTab.TabIndex = 3;
            this.processorsTab.Text = "ПРОЦЕССОРЫ";
            this.processorsTab.UseVisualStyleBackColor = true;
            // 
            // processorsFlowLayoutPanel
            // 
            this.processorsFlowLayoutPanel.AutoScroll = true;
            this.processorsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.processorsFlowLayoutPanel.Name = "processorsFlowLayoutPanel";
            this.processorsFlowLayoutPanel.Size = new System.Drawing.Size(1107, 604);
            this.processorsFlowLayoutPanel.TabIndex = 1;
            // 
            // motherboardsTab
            // 
            this.motherboardsTab.Location = new System.Drawing.Point(4, 22);
            this.motherboardsTab.Name = "motherboardsTab";
            this.motherboardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.motherboardsTab.Size = new System.Drawing.Size(1110, 607);
            this.motherboardsTab.TabIndex = 4;
            this.motherboardsTab.Text = "МАТ. ПЛАТЫ";
            this.motherboardsTab.UseVisualStyleBackColor = true;
            // 
            // ramTab
            // 
            this.ramTab.Location = new System.Drawing.Point(4, 22);
            this.ramTab.Name = "ramTab";
            this.ramTab.Padding = new System.Windows.Forms.Padding(3);
            this.ramTab.Size = new System.Drawing.Size(1110, 607);
            this.ramTab.TabIndex = 5;
            this.ramTab.Text = "ОПЕРАТИВНАЯ ПАМЯТЬ";
            this.ramTab.UseVisualStyleBackColor = true;
            // 
            // coolersTab
            // 
            this.coolersTab.Location = new System.Drawing.Point(4, 22);
            this.coolersTab.Name = "coolersTab";
            this.coolersTab.Padding = new System.Windows.Forms.Padding(3);
            this.coolersTab.Size = new System.Drawing.Size(1110, 607);
            this.coolersTab.TabIndex = 6;
            this.coolersTab.Text = "КУЛЕРЫ";
            this.coolersTab.UseVisualStyleBackColor = true;
            // 
            // casesTab
            // 
            this.casesTab.Location = new System.Drawing.Point(4, 22);
            this.casesTab.Name = "casesTab";
            this.casesTab.Padding = new System.Windows.Forms.Padding(3);
            this.casesTab.Size = new System.Drawing.Size(1110, 607);
            this.casesTab.TabIndex = 7;
            this.casesTab.Text = "КОРПУСЫ";
            this.casesTab.UseVisualStyleBackColor = true;
            // 
            // hddTab
            // 
            this.hddTab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.hddTab.Location = new System.Drawing.Point(4, 22);
            this.hddTab.Name = "hddTab";
            this.hddTab.Padding = new System.Windows.Forms.Padding(3);
            this.hddTab.Size = new System.Drawing.Size(1110, 607);
            this.hddTab.TabIndex = 8;
            this.hddTab.Text = "ЖЕСТКИЕ ДИСКИ";
            this.hddTab.UseVisualStyleBackColor = true;
            // 
            // ssdTab
            // 
            this.ssdTab.Location = new System.Drawing.Point(4, 22);
            this.ssdTab.Name = "ssdTab";
            this.ssdTab.Padding = new System.Windows.Forms.Padding(3);
            this.ssdTab.Size = new System.Drawing.Size(1110, 607);
            this.ssdTab.TabIndex = 9;
            this.ssdTab.Text = "ССД";
            this.ssdTab.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1110, 607);
            this.tabPage6.TabIndex = 10;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 694);
            this.Controls.Add(this.mainPageSplitContainer);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.mainPageSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPageSplitContainer)).EndInit();
            this.mainPageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.userConfigurationsTab.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTabPage.PerformLayout();
            this.processorsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainPageSplitContainer;
        private System.Windows.Forms.PictureBox updateButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage userConfigurationsTab;
        private System.Windows.Forms.TabPage profileTabPage;
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
        private System.Windows.Forms.TabPage processorsTab;
        private System.Windows.Forms.FlowLayoutPanel processorsFlowLayoutPanel;
        private System.Windows.Forms.TabPage motherboardsTab;
        private System.Windows.Forms.TabPage ramTab;
        private System.Windows.Forms.TabPage coolersTab;
        private System.Windows.Forms.TabPage casesTab;
        private System.Windows.Forms.TabPage hddTab;
        private System.Windows.Forms.TabPage ssdTab;
        private System.Windows.Forms.TabPage tabPage6;
    }
}