namespace PersonalComputerConfigurator.CustomControls
{
    partial class MotherboardsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotherboardsUserControl));
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionValueLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.chipsetValueLabel = new System.Windows.Forms.Label();
            this.chipSetLabel = new System.Windows.Forms.Label();
            this.formFactorValueLabel = new System.Windows.Forms.Label();
            this.formFactorLabel = new System.Windows.Forms.Label();
            this.ramTypeValueLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.socketValueLabel = new System.Windows.Forms.Label();
            this.socketLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // editPictureBox
            // 
            this.editPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("editPictureBox.Image")));
            this.editPictureBox.Location = new System.Drawing.Point(438, 81);
            this.editPictureBox.Name = "editPictureBox";
            this.editPictureBox.Size = new System.Drawing.Size(58, 52);
            this.editPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editPictureBox.TabIndex = 39;
            this.editPictureBox.TabStop = false;
            this.editPictureBox.Click += new System.EventHandler(this.editPictureBox_Click);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(468, 1);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(28, 31);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 38;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(370, 99);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(41, 13);
            this.priceValueLabel.TabIndex = 37;
            this.priceValueLabel.Text = "label13";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(301, 99);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 13);
            this.priceLabel.TabIndex = 36;
            this.priceLabel.Text = "ЦЕНА:";
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.AutoSize = true;
            this.descriptionValueLabel.Location = new System.Drawing.Point(69, 48);
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionValueLabel.TabIndex = 31;
            this.descriptionValueLabel.Text = "label7";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(2, 48);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 30;
            this.descriptionLabel.Text = "ОПИСАНИЕ:";
            // 
            // chipsetValueLabel
            // 
            this.chipsetValueLabel.AutoSize = true;
            this.chipsetValueLabel.Location = new System.Drawing.Point(354, 35);
            this.chipsetValueLabel.Name = "chipsetValueLabel";
            this.chipsetValueLabel.Size = new System.Drawing.Size(35, 13);
            this.chipsetValueLabel.TabIndex = 29;
            this.chipsetValueLabel.Text = "label9";
            this.chipsetValueLabel.Click += new System.EventHandler(this.chipsetValueLabel_Click);
            // 
            // chipSetLabel
            // 
            this.chipSetLabel.AutoSize = true;
            this.chipSetLabel.Location = new System.Drawing.Point(277, 35);
            this.chipSetLabel.Name = "chipSetLabel";
            this.chipSetLabel.Size = new System.Drawing.Size(55, 13);
            this.chipSetLabel.TabIndex = 28;
            this.chipSetLabel.Text = "ЧИПСЕТ:";
            // 
            // formFactorValueLabel
            // 
            this.formFactorValueLabel.AutoSize = true;
            this.formFactorValueLabel.Location = new System.Drawing.Point(375, 10);
            this.formFactorValueLabel.Name = "formFactorValueLabel";
            this.formFactorValueLabel.Size = new System.Drawing.Size(41, 13);
            this.formFactorValueLabel.TabIndex = 27;
            this.formFactorValueLabel.Text = "label11";
            // 
            // formFactorLabel
            // 
            this.formFactorLabel.AutoSize = true;
            this.formFactorLabel.Location = new System.Drawing.Point(277, 10);
            this.formFactorLabel.Name = "formFactorLabel";
            this.formFactorLabel.Size = new System.Drawing.Size(92, 13);
            this.formFactorLabel.TabIndex = 26;
            this.formFactorLabel.Text = "ФОРМ ФАКТОР";
            // 
            // ramTypeValueLabel
            // 
            this.ramTypeValueLabel.AutoSize = true;
            this.ramTypeValueLabel.Location = new System.Drawing.Point(82, 99);
            this.ramTypeValueLabel.Name = "ramTypeValueLabel";
            this.ramTypeValueLabel.Size = new System.Drawing.Size(35, 13);
            this.ramTypeValueLabel.TabIndex = 25;
            this.ramTypeValueLabel.Text = "label6";
            this.ramTypeValueLabel.Click += new System.EventHandler(this.tdpValueLabel_Click);
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Location = new System.Drawing.Point(4, 99);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(59, 13);
            this.ramLabel.TabIndex = 24;
            this.ramLabel.Text = "RAMTYPE";
            // 
            // socketValueLabel
            // 
            this.socketValueLabel.AutoSize = true;
            this.socketValueLabel.Location = new System.Drawing.Point(338, 60);
            this.socketValueLabel.Name = "socketValueLabel";
            this.socketValueLabel.Size = new System.Drawing.Size(36, 13);
            this.socketValueLabel.TabIndex = 23;
            this.socketValueLabel.Text = "сокет";
            // 
            // socketLabel
            // 
            this.socketLabel.AutoSize = true;
            this.socketLabel.Location = new System.Drawing.Point(283, 60);
            this.socketLabel.Name = "socketLabel";
            this.socketLabel.Size = new System.Drawing.Size(49, 13);
            this.socketLabel.TabIndex = 22;
            this.socketLabel.Text = "СОКЕТ: ";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.Location = new System.Drawing.Point(69, 10);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(116, 38);
            this.nameValueLabel.TabIndex = 21;
            this.nameValueLabel.Text = "имя";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Название:";
            // 
            // MotherboardsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.editPictureBox);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.priceValueLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionValueLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.chipsetValueLabel);
            this.Controls.Add(this.chipSetLabel);
            this.Controls.Add(this.formFactorValueLabel);
            this.Controls.Add(this.formFactorLabel);
            this.Controls.Add(this.ramTypeValueLabel);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.socketValueLabel);
            this.Controls.Add(this.socketLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "MotherboardsUserControl";
            this.Size = new System.Drawing.Size(499, 135);
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox editPictureBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.Label priceValueLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionValueLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label chipsetValueLabel;
        private System.Windows.Forms.Label chipSetLabel;
        private System.Windows.Forms.Label formFactorValueLabel;
        private System.Windows.Forms.Label formFactorLabel;
        private System.Windows.Forms.Label ramTypeValueLabel;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label socketValueLabel;
        private System.Windows.Forms.Label socketLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
