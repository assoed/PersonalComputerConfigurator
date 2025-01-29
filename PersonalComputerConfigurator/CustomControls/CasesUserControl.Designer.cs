namespace PersonalComputerConfigurator.CustomControls
{
    partial class CasesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasesUserControl));
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionValueLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.powerSupplyValueLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.formFactorValueLabel = new System.Windows.Forms.Label();
            this.formFactorLabel = new System.Windows.Forms.Label();
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
            this.editPictureBox.TabIndex = 83;
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
            this.deletePictureBox.TabIndex = 82;
            this.deletePictureBox.TabStop = false;
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(370, 99);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(41, 13);
            this.priceValueLabel.TabIndex = 81;
            this.priceValueLabel.Text = "label13";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(301, 99);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 13);
            this.priceLabel.TabIndex = 80;
            this.priceLabel.Text = "ЦЕНА:";
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.AutoSize = true;
            this.descriptionValueLabel.Location = new System.Drawing.Point(245, 10);
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionValueLabel.TabIndex = 79;
            this.descriptionValueLabel.Text = "label7";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(154, 10);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 78;
            this.descriptionLabel.Text = "ОПИСАНИЕ:";
            // 
            // powerSupplyValueLabel
            // 
            this.powerSupplyValueLabel.AutoSize = true;
            this.powerSupplyValueLabel.Location = new System.Drawing.Point(63, 99);
            this.powerSupplyValueLabel.Name = "powerSupplyValueLabel";
            this.powerSupplyValueLabel.Size = new System.Drawing.Size(35, 13);
            this.powerSupplyValueLabel.TabIndex = 77;
            this.powerSupplyValueLabel.Text = "label9";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(3, 99);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(54, 13);
            this.sizeLabel.TabIndex = 76;
            this.sizeLabel.Text = "РАЗМЕР:";
            // 
            // formFactorValueLabel
            // 
            this.formFactorValueLabel.AutoSize = true;
            this.formFactorValueLabel.Location = new System.Drawing.Point(108, 48);
            this.formFactorValueLabel.Name = "formFactorValueLabel";
            this.formFactorValueLabel.Size = new System.Drawing.Size(41, 13);
            this.formFactorValueLabel.TabIndex = 75;
            this.formFactorValueLabel.Text = "label11";
            // 
            // formFactorLabel
            // 
            this.formFactorLabel.AutoSize = true;
            this.formFactorLabel.Location = new System.Drawing.Point(0, 48);
            this.formFactorLabel.Name = "formFactorLabel";
            this.formFactorLabel.Size = new System.Drawing.Size(92, 13);
            this.formFactorLabel.TabIndex = 74;
            this.formFactorLabel.Text = "ФОРМ ФАКТОР";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.Location = new System.Drawing.Point(69, 10);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(116, 38);
            this.nameValueLabel.TabIndex = 71;
            this.nameValueLabel.Text = "имя";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 70;
            this.nameLabel.Text = "Название:";
            // 
            // CasesUserControl
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
            this.Controls.Add(this.powerSupplyValueLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.formFactorValueLabel);
            this.Controls.Add(this.formFactorLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "CasesUserControl";
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
        private System.Windows.Forms.Label powerSupplyValueLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label formFactorValueLabel;
        private System.Windows.Forms.Label formFactorLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
