﻿namespace PersonalComputerConfigurator.Forms
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registrationLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.loginRegistrationLabel = new System.Windows.Forms.Label();
            this.passwordRegistrationLabel = new System.Windows.Forms.Label();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.personalComputerConfiguratorDatabaseDataSet = new PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserTableAdapter = new PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSetTableAdapters.UserTableAdapter();
            this.userRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserRoleTableAdapter = new PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSetTableAdapters.UserRoleTableAdapter();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personalComputerConfiguratorDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(167, 141);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(561, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(167, 184);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(561, 20);
            this.middleNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(167, 98);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(561, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(167, 223);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(561, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(167, 303);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(561, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.registrationLabel.Location = new System.Drawing.Point(162, 32);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(452, 25);
            this.registrationLabel.TabIndex = 7;
            this.registrationLabel.Text = "ВВЕДИТЕ СВОИ ДАННЫЕ ДЛЯ РЕГИСТРАЦИИ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(129, 144);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "ИМЯ";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(95, 184);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.middleNameLabel.TabIndex = 8;
            this.middleNameLabel.Text = "ОТЧЕСТВО";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(95, 98);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "ФАМИЛИЯ";
            // 
            // loginRegistrationLabel
            // 
            this.loginRegistrationLabel.AutoSize = true;
            this.loginRegistrationLabel.Location = new System.Drawing.Point(116, 226);
            this.loginRegistrationLabel.Name = "loginRegistrationLabel";
            this.loginRegistrationLabel.Size = new System.Drawing.Size(45, 13);
            this.loginRegistrationLabel.TabIndex = 10;
            this.loginRegistrationLabel.Text = "ЛОГИН";
            // 
            // passwordRegistrationLabel
            // 
            this.passwordRegistrationLabel.AutoSize = true;
            this.passwordRegistrationLabel.Location = new System.Drawing.Point(109, 303);
            this.passwordRegistrationLabel.Name = "passwordRegistrationLabel";
            this.passwordRegistrationLabel.Size = new System.Drawing.Size(52, 13);
            this.passwordRegistrationLabel.TabIndex = 11;
            this.passwordRegistrationLabel.Text = "ПАРОЛЬ";
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(39, 346);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(122, 13);
            this.repeatPasswordLabel.TabIndex = 13;
            this.repeatPasswordLabel.Text = "ПОВТОРИТЕ ПАРОЛЬ";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(167, 343);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(561, 20);
            this.repeatPasswordTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(31, 264);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(130, 13);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registrationButton.Location = new System.Drawing.Point(167, 403);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(561, 23);
            this.registrationButton.TabIndex = 16;
            this.registrationButton.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(167, 264);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(561, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Location = new System.Drawing.Point(537, 68);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(37, 13);
            this.userRoleLabel.TabIndex = 17;
            this.userRoleLabel.Text = "РОЛЬ";
            this.userRoleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // personalComputerConfiguratorDatabaseDataSet
            // 
            this.personalComputerConfiguratorDatabaseDataSet.DataSetName = "personalComputerConfiguratorDatabaseDataSet";
            this.personalComputerConfiguratorDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.personalComputerConfiguratorDatabaseDataSet;
            // 
            // UserTableAdapter
            // 
            this.UserTableAdapter.ClearBeforeFill = true;
            // 
            // userRoleBindingSource
            // 
            this.userRoleBindingSource.DataMember = "userRole";
            this.userRoleBindingSource.DataSource = this.personalComputerConfiguratorDatabaseDataSet;
            // 
            // UserRoleTableAdapter
            // 
            this.UserRoleTableAdapter.ClearBeforeFill = true;
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.DataSource = this.userRoleBindingSource;
            this.userRoleComboBox.DisplayMember = "roleName";
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(580, 65);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(148, 21);
            this.userRoleComboBox.TabIndex = 18;
            this.userRoleComboBox.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.Location = new System.Drawing.Point(164, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = " Поле должно быть не пустым";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label4.Location = new System.Drawing.Point(164, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "Логин должен быть уникальным";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label5.Location = new System.Drawing.Point(164, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "Формат почты example@example.example";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label7.Location = new System.Drawing.Point(164, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "Пароль должен содержать заглавную букву и цифры. Быть не короче 8 символов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label8.Location = new System.Drawing.Point(165, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(359, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "Пароль должен содержать заглавную букву и цифры. Быть не короче 8 символов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label1.Location = new System.Drawing.Point(165, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = " Поле должно быть не пустым";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label2.Location = new System.Drawing.Point(165, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = " Поле должно быть не пустым";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.passwordRegistrationLabel);
            this.Controls.Add(this.loginRegistrationLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "КОНФИГУРАТОР ПК";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalComputerConfiguratorDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label loginRegistrationLabel;
        private System.Windows.Forms.Label passwordRegistrationLabel;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label userRoleLabel;
        private personalComputerConfiguratorDatabaseDataSet personalComputerConfiguratorDatabaseDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private personalComputerConfiguratorDatabaseDataSetTableAdapters.UserTableAdapter UserTableAdapter;
        private System.Windows.Forms.BindingSource userRoleBindingSource;
        private personalComputerConfiguratorDatabaseDataSetTableAdapters.UserRoleTableAdapter UserRoleTableAdapter;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}