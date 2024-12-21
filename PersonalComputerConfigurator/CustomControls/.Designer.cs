namespace PersonalComputerConfigurator.CustomControls
{
    partial class ProfileBlockUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileBlockUserControl));
            this.logoutButton = new System.Windows.Forms.Button();
            this.userFIOLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(230, 30);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(70, 20);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "ВЫЙТИ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userFIOLabel
            // 
            this.userFIOLabel.AutoSize = true;
            this.userFIOLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userFIOLabel.Location = new System.Drawing.Point(56, 0);
            this.userFIOLabel.Name = "userFIOLabel";
            this.userFIOLabel.Size = new System.Drawing.Size(24, 13);
            this.userFIOLabel.TabIndex = 5;
            this.userFIOLabel.Text = "FIO";
            this.userFIOLabel.Click += new System.EventHandler(this.userFIOLabel_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(50, 50);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 4;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // ProfileBlockUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userFIOLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Name = "ProfileBlockUserControl";
            this.Size = new System.Drawing.Size(303, 50);
            this.Load += new System.EventHandler(this.ProfileBlockUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label userFIOLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
    }
}