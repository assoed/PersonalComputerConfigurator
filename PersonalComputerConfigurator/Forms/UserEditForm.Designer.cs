﻿namespace PersonalComputerConfigurator.Forms
{
    partial class UserEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            this.userRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalComputerConfiguratorDatabaseDataSet = new PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSet();
            this.UserTableAdapter = new PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSetTableAdapters.UserTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.РОЛЬ = new System.Windows.Forms.Label();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.UserRoleTableAdapter = new PersonalComputerConfigurator.personalComputerConfiguratorDatabaseDataSetTableAdapters.UserRoleTableAdapter();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginRegistrationLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userRoleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalComputerConfiguratorDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // userRoleBindingSource
            // 
            this.userRoleBindingSource.DataMember = "userRole";
            this.userRoleBindingSource.DataSource = this.personalComputerConfiguratorDatabaseDataSet;
            // 
            // personalComputerConfiguratorDatabaseDataSet
            // 
            this.personalComputerConfiguratorDatabaseDataSet.DataSetName = "personalComputerConfiguratorDatabaseDataSet";
            this.personalComputerConfiguratorDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserTableAdapter
            // 
            this.UserTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.personalComputerConfiguratorDatabaseDataSet;
            // 
            // РОЛЬ
            // 
            this.РОЛЬ.AutoSize = true;
            this.РОЛЬ.Location = new System.Drawing.Point(495, 35);
            this.РОЛЬ.Name = "РОЛЬ";
            this.РОЛЬ.Size = new System.Drawing.Size(37, 13);
            this.РОЛЬ.TabIndex = 35;
            this.РОЛЬ.Text = "РОЛЬ";
            // 
            // saveUserButton
            // 
            this.saveUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveUserButton.Location = new System.Drawing.Point(143, 290);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(561, 23);
            this.saveUserButton.TabIndex = 34;
            this.saveUserButton.Text = "СОХРАНИТЬ";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(7, 231);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(130, 13);
            this.emailLabel.TabIndex = 33;
            this.emailLabel.Text = "ЭЛЕКТРОННАЯ ПОЧТА";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(143, 228);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(561, 20);
            this.emailTextBox.TabIndex = 32;
            // 
            // UserRoleTableAdapter
            // 
            this.UserRoleTableAdapter.ClearBeforeFill = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(53, 65);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.lastNameLabel.TabIndex = 27;
            this.lastNameLabel.Text = "ФАМИЛИЯ";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(53, 151);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.middleNameLabel.TabIndex = 25;
            this.middleNameLabel.Text = "ОТЧЕСТВО";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(87, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "ИМЯ";
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.registrationLabel.Location = new System.Drawing.Point(120, -1);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(364, 25);
            this.registrationLabel.TabIndex = 24;
            this.registrationLabel.Text = "РЕДАКТИРОВАНИЕ ПОЛЬЗОВАТЕЛЯ";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loginRegistrationLabel
            // 
            this.loginRegistrationLabel.AutoSize = true;
            this.loginRegistrationLabel.Location = new System.Drawing.Point(74, 193);
            this.loginRegistrationLabel.Name = "loginRegistrationLabel";
            this.loginRegistrationLabel.Size = new System.Drawing.Size(45, 13);
            this.loginRegistrationLabel.TabIndex = 28;
            this.loginRegistrationLabel.Text = "ЛОГИН";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(143, 190);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(561, 20);
            this.loginTextBox.TabIndex = 22;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(143, 65);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(561, 20);
            this.lastNameTextBox.TabIndex = 21;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(143, 151);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(561, 20);
            this.middleNameTextBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(143, 108);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(561, 20);
            this.nameTextBox.TabIndex = 19;
            // 
            // userRoleBindingSource1
            // 
            this.userRoleBindingSource1.DataMember = "userRole";
            this.userRoleBindingSource1.DataSource = this.personalComputerConfiguratorDatabaseDataSet;
            this.userRoleBindingSource1.CurrentChanged += new System.EventHandler(this.userRoleBindingSource1_CurrentChanged);
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.DataSource = this.userRoleBindingSource;
            this.userRoleComboBox.DisplayMember = "roleName";
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(547, 32);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.userRoleComboBox.TabIndex = 36;
            this.userRoleComboBox.ValueMember = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label2.Location = new System.Drawing.Point(141, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = " Поле должно быть не пустым";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label1.Location = new System.Drawing.Point(141, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = " Поле должно быть не пустым";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.Location = new System.Drawing.Point(141, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = " Поле должно быть не пустым";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label4.Location = new System.Drawing.Point(141, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "Логин должен быть уникальным";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label5.Location = new System.Drawing.Point(141, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "Формат почты example@example.example";
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 326);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.РОЛЬ);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.loginRegistrationLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserEditForm";
            this.Text = "КОНФИГУРАТОР ПК";
            this.Load += new System.EventHandler(this.UserEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalComputerConfiguratorDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource userRoleBindingSource;
        private personalComputerConfiguratorDatabaseDataSet personalComputerConfiguratorDatabaseDataSet;
        private personalComputerConfiguratorDatabaseDataSetTableAdapters.UserTableAdapter UserTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label РОЛЬ;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private personalComputerConfiguratorDatabaseDataSetTableAdapters.UserRoleTableAdapter UserRoleTableAdapter;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label loginRegistrationLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource userRoleBindingSource1;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}