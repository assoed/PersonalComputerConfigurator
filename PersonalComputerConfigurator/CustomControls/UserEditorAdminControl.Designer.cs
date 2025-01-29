namespace PersonalComputerConfigurator.CustomControls
{
    partial class UserEditorAdminControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditorAdminControl));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameValueLabel = new System.Windows.Forms.Label();
            this.MiddleNameValueLabel = new System.Windows.Forms.Label();
            this.firstNameValueLabel = new System.Windows.Forms.Label();
            this.RoleIdLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.roleValueLabel = new System.Windows.Forms.Label();
            this.loginValueLabel = new System.Windows.Forms.Label();
            this.EmailValueLabel = new System.Windows.Forms.Label();
            this.IdValueLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(4, 43);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "ИМЯ";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(4, 67);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.middleNameLabel.TabIndex = 1;
            this.middleNameLabel.Text = "ОТЧЕСТВО";
            this.middleNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(4, 17);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "ФАМИЛИЯ";
            // 
            // LastNameValueLabel
            // 
            this.LastNameValueLabel.AutoSize = true;
            this.LastNameValueLabel.Location = new System.Drawing.Point(79, 17);
            this.LastNameValueLabel.Name = "LastNameValueLabel";
            this.LastNameValueLabel.Size = new System.Drawing.Size(53, 13);
            this.LastNameValueLabel.TabIndex = 6;
            this.LastNameValueLabel.Text = "фамилия";
            // 
            // MiddleNameValueLabel
            // 
            this.MiddleNameValueLabel.AutoSize = true;
            this.MiddleNameValueLabel.Location = new System.Drawing.Point(79, 67);
            this.MiddleNameValueLabel.Name = "MiddleNameValueLabel";
            this.MiddleNameValueLabel.Size = new System.Drawing.Size(55, 13);
            this.MiddleNameValueLabel.TabIndex = 5;
            this.MiddleNameValueLabel.Text = " отчество";
            // 
            // firstNameValueLabel
            // 
            this.firstNameValueLabel.AutoSize = true;
            this.firstNameValueLabel.Location = new System.Drawing.Point(79, 43);
            this.firstNameValueLabel.Name = "firstNameValueLabel";
            this.firstNameValueLabel.Size = new System.Drawing.Size(27, 13);
            this.firstNameValueLabel.TabIndex = 4;
            this.firstNameValueLabel.Text = "имя";
            // 
            // RoleIdLabel
            // 
            this.RoleIdLabel.AutoSize = true;
            this.RoleIdLabel.Location = new System.Drawing.Point(221, 43);
            this.RoleIdLabel.Name = "RoleIdLabel";
            this.RoleIdLabel.Size = new System.Drawing.Size(37, 13);
            this.RoleIdLabel.TabIndex = 10;
            this.RoleIdLabel.Text = "РОЛЬ";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(221, 67);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(130, 13);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(221, 17);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(45, 13);
            this.LoginLabel.TabIndex = 8;
            this.LoginLabel.Text = "ЛОГИН";
            // 
            // roleValueLabel
            // 
            this.roleValueLabel.AutoSize = true;
            this.roleValueLabel.Location = new System.Drawing.Point(264, 43);
            this.roleValueLabel.Name = "roleValueLabel";
            this.roleValueLabel.Size = new System.Drawing.Size(31, 13);
            this.roleValueLabel.TabIndex = 14;
            this.roleValueLabel.Text = "роль";
            // 
            // loginValueLabel
            // 
            this.loginValueLabel.AutoSize = true;
            this.loginValueLabel.Location = new System.Drawing.Point(272, 17);
            this.loginValueLabel.Name = "loginValueLabel";
            this.loginValueLabel.Size = new System.Drawing.Size(36, 13);
            this.loginValueLabel.TabIndex = 12;
            this.loginValueLabel.Text = "логин";
            // 
            // EmailValueLabel
            // 
            this.EmailValueLabel.AutoSize = true;
            this.EmailValueLabel.Location = new System.Drawing.Point(357, 67);
            this.EmailValueLabel.Name = "EmailValueLabel";
            this.EmailValueLabel.Size = new System.Drawing.Size(41, 13);
            this.EmailValueLabel.TabIndex = 13;
            this.EmailValueLabel.Text = "епочта";
            // 
            // IdValueLabel
            // 
            this.IdValueLabel.AutoSize = true;
            this.IdValueLabel.Location = new System.Drawing.Point(381, 0);
            this.IdValueLabel.Name = "IdValueLabel";
            this.IdValueLabel.Size = new System.Drawing.Size(15, 13);
            this.IdValueLabel.TabIndex = 16;
            this.IdValueLabel.Text = "id";
            this.IdValueLabel.Click += new System.EventHandler(this.IdValueLabel_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(357, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 15;
            this.IdLabel.Text = "ID";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // editPictureBox
            // 
            this.editPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("editPictureBox.Image")));
            this.editPictureBox.Location = new System.Drawing.Point(464, 57);
            this.editPictureBox.Name = "editPictureBox";
            this.editPictureBox.Size = new System.Drawing.Size(42, 33);
            this.editPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editPictureBox.TabIndex = 84;
            this.editPictureBox.TabStop = false;
            this.editPictureBox.Click += new System.EventHandler(this.editPictureBox_Click);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(519, 3);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(28, 31);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 85;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // UserEditorAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.editPictureBox);
            this.Controls.Add(this.IdValueLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.roleValueLabel);
            this.Controls.Add(this.EmailValueLabel);
            this.Controls.Add(this.loginValueLabel);
            this.Controls.Add(this.RoleIdLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LastNameValueLabel);
            this.Controls.Add(this.MiddleNameValueLabel);
            this.Controls.Add(this.firstNameValueLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.Name = "UserEditorAdminControl";
            this.Size = new System.Drawing.Size(550, 93);
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameValueLabel;
        private System.Windows.Forms.Label MiddleNameValueLabel;
        private System.Windows.Forms.Label firstNameValueLabel;
        private System.Windows.Forms.Label RoleIdLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label roleValueLabel;
        private System.Windows.Forms.Label loginValueLabel;
        private System.Windows.Forms.Label EmailValueLabel;
        private System.Windows.Forms.Label IdValueLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.PictureBox editPictureBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
    }
}
