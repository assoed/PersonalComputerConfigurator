namespace PersonalComputerConfigurator.Forms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.Authorization = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.createNewAccButton = new System.Windows.Forms.Button();
            this.loginButtton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Authorization
            // 
            this.Authorization.AutoSize = true;
            this.Authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.Authorization.Location = new System.Drawing.Point(59, 39);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(675, 54);
            this.Authorization.TabIndex = 0;
            this.Authorization.Text = "ВОЙДИТЕ В СВОЙ АККАУНТ";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(68, 182);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(257, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(68, 260);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(257, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuthorizationForm_KeyDown);
            // 
            // createNewAccButton
            // 
            this.createNewAccButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createNewAccButton.Location = new System.Drawing.Point(509, 379);
            this.createNewAccButton.Name = "createNewAccButton";
            this.createNewAccButton.Size = new System.Drawing.Size(255, 34);
            this.createNewAccButton.TabIndex = 3;
            this.createNewAccButton.Text = "СОЗДАТЬ АККАУНТ";
            this.createNewAccButton.UseVisualStyleBackColor = true;
            this.createNewAccButton.Click += new System.EventHandler(this.createNewAccButton_Click);
            // 
            // loginButtton
            // 
            this.loginButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginButtton.Location = new System.Drawing.Point(70, 379);
            this.loginButtton.Name = "loginButtton";
            this.loginButtton.Size = new System.Drawing.Size(255, 34);
            this.loginButtton.TabIndex = 4;
            this.loginButtton.Text = "ВОЙТИ";
            this.loginButtton.UseVisualStyleBackColor = true;
            this.loginButtton.Click += new System.EventHandler(this.loginButtton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginLabel.Location = new System.Drawing.Point(64, 159);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(65, 20);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "ЛОГИН";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordLabel.Location = new System.Drawing.Point(66, 237);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 20);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "ПАРОЛЬ";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginButtton);
            this.Controls.Add(this.createNewAccButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.Authorization);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.Text = "КОНФИГУРАТОР ПК";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Authorization;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button createNewAccButton;
        private System.Windows.Forms.Button loginButtton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}