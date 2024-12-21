namespace PersonalComputerConfigurator.Forms
{
    partial class ProfilePageForm
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
            this.emailTextLabel = new System.Windows.Forms.Label();
            this.loginTextLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.yourProfileLabel = new System.Windows.Forms.Label();
            this.saveProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextLabel
            // 
            this.emailTextLabel.AutoSize = true;
            this.emailTextLabel.Location = new System.Drawing.Point(23, 374);
            this.emailTextLabel.Name = "emailTextLabel";
            this.emailTextLabel.Size = new System.Drawing.Size(130, 13);
            this.emailTextLabel.TabIndex = 29;
            this.emailTextLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // loginTextLabel
            // 
            this.loginTextLabel.AutoSize = true;
            this.loginTextLabel.Location = new System.Drawing.Point(108, 336);
            this.loginTextLabel.Name = "loginTextLabel";
            this.loginTextLabel.Size = new System.Drawing.Size(45, 13);
            this.loginTextLabel.TabIndex = 24;
            this.loginTextLabel.Text = "ЛОГИН";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(87, 208);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.lastNameLabel.TabIndex = 23;
            this.lastNameLabel.Text = "ФАМИЛИЯ";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(87, 294);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.middleNameLabel.TabIndex = 21;
            this.middleNameLabel.Text = "ОТЧЕСТВО";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(121, 254);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "ИМЯ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(159, 208);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(159, 294);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.middleNameTextBox.TabIndex = 17;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(159, 251);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nameTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(168, 374);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(130, 13);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(168, 336);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(45, 13);
            this.loginLabel.TabIndex = 31;
            this.loginLabel.Text = "ЛОГИН";
            // 
            // yourProfileLabel
            // 
            this.yourProfileLabel.AutoSize = true;
            this.yourProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.yourProfileLabel.Location = new System.Drawing.Point(288, 122);
            this.yourProfileLabel.Name = "yourProfileLabel";
            this.yourProfileLabel.Size = new System.Drawing.Size(180, 26);
            this.yourProfileLabel.TabIndex = 32;
            this.yourProfileLabel.Text = "ВАШ ПРОФИЛЬ";
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.saveProfileButton.Location = new System.Drawing.Point(293, 462);
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(217, 31);
            this.saveProfileButton.TabIndex = 33;
            this.saveProfileButton.Text = "СОХРАНИТЬ";
            this.saveProfileButton.UseVisualStyleBackColor = true;
            this.saveProfileButton.Click += new System.EventHandler(this.saveProfileButton_Click);
            // 
            // ProfilePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 523);
            this.Controls.Add(this.saveProfileButton);
            this.Controls.Add(this.yourProfileLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextLabel);
            this.Controls.Add(this.loginTextLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ProfilePageForm";
            this.Text = "ProfilePageForm";
            this.Load += new System.EventHandler(this.ProfilePageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailTextLabel;
        private System.Windows.Forms.Label loginTextLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label yourProfileLabel;
        private System.Windows.Forms.Button saveProfileButton;
    }
}