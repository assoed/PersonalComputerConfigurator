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
            this.addNewButton = new System.Windows.Forms.PictureBox();
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
            this.motherBoardsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.motherboardFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ramTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ramFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.coolersTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.coolersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.casesTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.casesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hddTab = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ssdTab = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.gpuTab = new System.Windows.Forms.TabPage();
            this.psuTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageSplitContainer)).BeginInit();
            this.mainPageSplitContainer.Panel1.SuspendLayout();
            this.mainPageSplitContainer.Panel2.SuspendLayout();
            this.mainPageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.processorsTab.SuspendLayout();
            this.motherboardsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motherBoardsSplitContainer)).BeginInit();
            this.motherBoardsSplitContainer.Panel2.SuspendLayout();
            this.motherBoardsSplitContainer.SuspendLayout();
            this.ramTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.coolersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.casesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.hddTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.ssdTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
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
            this.mainPageSplitContainer.Panel2.Controls.Add(this.mainTabControl);
            this.mainPageSplitContainer.Size = new System.Drawing.Size(1118, 694);
            this.mainPageSplitContainer.SplitterDistance = 60;
            this.mainPageSplitContainer.TabIndex = 0;
            // 
            // addNewButton
            // 
            this.addNewButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewButton.Image")));
            this.addNewButton.Location = new System.Drawing.Point(80, 26);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(46, 31);
            this.addNewButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addNewButton.TabIndex = 0;
            this.addNewButton.TabStop = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(23, 26);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(33, 31);
            this.updateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateButton.TabIndex = 1;
            this.updateButton.TabStop = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            this.mainTabControl.Controls.Add(this.gpuTab);
            this.mainTabControl.Controls.Add(this.psuTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1118, 630);
            this.mainTabControl.TabIndex = 2;
            // 
            // userConfigurationsTab
            // 
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
            this.profileTabPage.Size = new System.Drawing.Size(1110, 604);
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
            this.processorsTab.Size = new System.Drawing.Size(1110, 604);
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
            this.motherboardsTab.Controls.Add(this.motherBoardsSplitContainer);
            this.motherboardsTab.Location = new System.Drawing.Point(4, 22);
            this.motherboardsTab.Name = "motherboardsTab";
            this.motherboardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.motherboardsTab.Size = new System.Drawing.Size(1110, 604);
            this.motherboardsTab.TabIndex = 4;
            this.motherboardsTab.Text = "МАТ. ПЛАТЫ";
            this.motherboardsTab.UseVisualStyleBackColor = true;
            // 
            // motherBoardsSplitContainer
            // 
            this.motherBoardsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motherBoardsSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.motherBoardsSplitContainer.Name = "motherBoardsSplitContainer";
            this.motherBoardsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // motherBoardsSplitContainer.Panel2
            // 
            this.motherBoardsSplitContainer.Panel2.Controls.Add(this.motherboardFlowLayoutPanel);
            this.motherBoardsSplitContainer.Size = new System.Drawing.Size(1104, 598);
            this.motherBoardsSplitContainer.SplitterDistance = 49;
            this.motherBoardsSplitContainer.TabIndex = 0;
            // 
            // motherboardFlowLayoutPanel
            // 
            this.motherboardFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motherboardFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.motherboardFlowLayoutPanel.Name = "motherboardFlowLayoutPanel";
            this.motherboardFlowLayoutPanel.Size = new System.Drawing.Size(1104, 545);
            this.motherboardFlowLayoutPanel.TabIndex = 0;
            // 
            // ramTab
            // 
            this.ramTab.Controls.Add(this.splitContainer2);
            this.ramTab.Location = new System.Drawing.Point(4, 22);
            this.ramTab.Name = "ramTab";
            this.ramTab.Padding = new System.Windows.Forms.Padding(3);
            this.ramTab.Size = new System.Drawing.Size(1110, 604);
            this.ramTab.TabIndex = 5;
            this.ramTab.Text = "ОПЕРАТИВНАЯ ПАМЯТЬ";
            this.ramTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ramFlowLayoutPanel);
            this.splitContainer2.Size = new System.Drawing.Size(1104, 598);
            this.splitContainer2.SplitterDistance = 49;
            this.splitContainer2.TabIndex = 1;
            // 
            // ramFlowLayoutPanel
            // 
            this.ramFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ramFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ramFlowLayoutPanel.Name = "ramFlowLayoutPanel";
            this.ramFlowLayoutPanel.Size = new System.Drawing.Size(1104, 545);
            this.ramFlowLayoutPanel.TabIndex = 0;
            this.ramFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ramFlowLayoutPanel_Paint);
            // 
            // coolersTab
            // 
            this.coolersTab.Controls.Add(this.splitContainer1);
            this.coolersTab.Location = new System.Drawing.Point(4, 22);
            this.coolersTab.Name = "coolersTab";
            this.coolersTab.Padding = new System.Windows.Forms.Padding(3);
            this.coolersTab.Size = new System.Drawing.Size(1110, 604);
            this.coolersTab.TabIndex = 6;
            this.coolersTab.Text = "КУЛЕРЫ";
            this.coolersTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.coolersFlowLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 598);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 1;
            // 
            // coolersFlowLayoutPanel
            // 
            this.coolersFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coolersFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.coolersFlowLayoutPanel.Name = "coolersFlowLayoutPanel";
            this.coolersFlowLayoutPanel.Size = new System.Drawing.Size(1104, 545);
            this.coolersFlowLayoutPanel.TabIndex = 0;
            // 
            // casesTab
            // 
            this.casesTab.Controls.Add(this.splitContainer3);
            this.casesTab.Location = new System.Drawing.Point(4, 22);
            this.casesTab.Name = "casesTab";
            this.casesTab.Padding = new System.Windows.Forms.Padding(3);
            this.casesTab.Size = new System.Drawing.Size(1110, 604);
            this.casesTab.TabIndex = 7;
            this.casesTab.Text = "КОРПУСЫ";
            this.casesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.casesFlowLayoutPanel);
            this.splitContainer3.Size = new System.Drawing.Size(1104, 598);
            this.splitContainer3.SplitterDistance = 49;
            this.splitContainer3.TabIndex = 1;
            // 
            // casesFlowLayoutPanel
            // 
            this.casesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.casesFlowLayoutPanel.Name = "casesFlowLayoutPanel";
            this.casesFlowLayoutPanel.Size = new System.Drawing.Size(1104, 545);
            this.casesFlowLayoutPanel.TabIndex = 0;
            // 
            // hddTab
            // 
            this.hddTab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.hddTab.Controls.Add(this.splitContainer4);
            this.hddTab.Location = new System.Drawing.Point(4, 22);
            this.hddTab.Name = "hddTab";
            this.hddTab.Padding = new System.Windows.Forms.Padding(3);
            this.hddTab.Size = new System.Drawing.Size(1110, 604);
            this.hddTab.TabIndex = 8;
            this.hddTab.Text = "ЖЕСТКИЕ ДИСКИ";
            this.hddTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer4.Size = new System.Drawing.Size(1104, 598);
            this.splitContainer4.SplitterDistance = 49;
            this.splitContainer4.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1104, 545);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // ssdTab
            // 
            this.ssdTab.Controls.Add(this.splitContainer5);
            this.ssdTab.Location = new System.Drawing.Point(4, 22);
            this.ssdTab.Name = "ssdTab";
            this.ssdTab.Padding = new System.Windows.Forms.Padding(3);
            this.ssdTab.Size = new System.Drawing.Size(1110, 604);
            this.ssdTab.TabIndex = 9;
            this.ssdTab.Text = "ССД";
            this.ssdTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer5.Size = new System.Drawing.Size(1104, 598);
            this.splitContainer5.SplitterDistance = 49;
            this.splitContainer5.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1104, 545);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // gpuTab
            // 
            this.gpuTab.Location = new System.Drawing.Point(4, 22);
            this.gpuTab.Name = "gpuTab";
            this.gpuTab.Padding = new System.Windows.Forms.Padding(3);
            this.gpuTab.Size = new System.Drawing.Size(1110, 604);
            this.gpuTab.TabIndex = 10;
            this.gpuTab.Text = "ВИДЕОКАРТЫ";
            this.gpuTab.UseVisualStyleBackColor = true;
            // 
            // psuTab
            // 
            this.psuTab.Location = new System.Drawing.Point(4, 22);
            this.psuTab.Name = "psuTab";
            this.psuTab.Padding = new System.Windows.Forms.Padding(3);
            this.psuTab.Size = new System.Drawing.Size(1110, 604);
            this.psuTab.TabIndex = 11;
            this.psuTab.Text = "БЛОКИ ПИТАНИЯ";
            this.psuTab.UseVisualStyleBackColor = true;
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
            this.mainPageSplitContainer.Panel1.ResumeLayout(false);
            this.mainPageSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPageSplitContainer)).EndInit();
            this.mainPageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addNewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTabPage.PerformLayout();
            this.processorsTab.ResumeLayout(false);
            this.motherboardsTab.ResumeLayout(false);
            this.motherBoardsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.motherBoardsSplitContainer)).EndInit();
            this.motherBoardsSplitContainer.ResumeLayout(false);
            this.ramTab.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.coolersTab.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.casesTab.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.hddTab.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ssdTab.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
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
        public System.Windows.Forms.FlowLayoutPanel processorsFlowLayoutPanel;
        private System.Windows.Forms.TabPage motherboardsTab;
        private System.Windows.Forms.TabPage ramTab;
        private System.Windows.Forms.TabPage coolersTab;
        private System.Windows.Forms.TabPage casesTab;
        private System.Windows.Forms.TabPage hddTab;
        private System.Windows.Forms.TabPage ssdTab;
        private System.Windows.Forms.TabPage gpuTab;
        private System.Windows.Forms.PictureBox addNewButton;
        private System.Windows.Forms.SplitContainer motherBoardsSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel ramFlowLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel coolersFlowLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.FlowLayoutPanel casesFlowLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TabPage psuTab;
        private System.Windows.Forms.FlowLayoutPanel motherboardFlowLayoutPanel;
    }
}