namespace PersonalComputerConfigurator.CustomControls
{
    partial class RamUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RamUserControl));
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionValueLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.ramTypeValueLabel = new System.Windows.Forms.Label();
            this.ramTypeLabel = new System.Windows.Forms.Label();
            this.formFactorValueLabel = new System.Windows.Forms.Label();
            this.formFactorLabel = new System.Windows.Forms.Label();
            this.capacityValueLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.frequencyValueLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
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
            this.editPictureBox.TabIndex = 69;
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
            this.deletePictureBox.TabIndex = 68;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(370, 99);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(41, 13);
            this.priceValueLabel.TabIndex = 67;
            this.priceValueLabel.Text = "label13";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(301, 99);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 13);
            this.priceLabel.TabIndex = 66;
            this.priceLabel.Text = "ЦЕНА:";
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.AutoSize = true;
            this.descriptionValueLabel.Location = new System.Drawing.Point(245, 10);
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionValueLabel.TabIndex = 65;
            this.descriptionValueLabel.Text = "label7";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(154, 10);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 64;
            this.descriptionLabel.Text = "ОПИСАНИЕ:";
            // 
            // ramTypeValueLabel
            // 
            this.ramTypeValueLabel.AutoSize = true;
            this.ramTypeValueLabel.Location = new System.Drawing.Point(85, 48);
            this.ramTypeValueLabel.Name = "ramTypeValueLabel";
            this.ramTypeValueLabel.Size = new System.Drawing.Size(35, 13);
            this.ramTypeValueLabel.TabIndex = 63;
            this.ramTypeValueLabel.Text = "label9";
            // 
            // ramTypeLabel
            // 
            this.ramTypeLabel.AutoSize = true;
            this.ramTypeLabel.Location = new System.Drawing.Point(5, 48);
            this.ramTypeLabel.Name = "ramTypeLabel";
            this.ramTypeLabel.Size = new System.Drawing.Size(83, 13);
            this.ramTypeLabel.TabIndex = 62;
            this.ramTypeLabel.Text = "ТИП ПАМЯТИ:";
            // 
            // formFactorValueLabel
            // 
            this.formFactorValueLabel.AutoSize = true;
            this.formFactorValueLabel.Location = new System.Drawing.Point(262, 70);
            this.formFactorValueLabel.Name = "formFactorValueLabel";
            this.formFactorValueLabel.Size = new System.Drawing.Size(41, 13);
            this.formFactorValueLabel.TabIndex = 61;
            this.formFactorValueLabel.Text = "label11";
            // 
            // formFactorLabel
            // 
            this.formFactorLabel.AutoSize = true;
            this.formFactorLabel.Location = new System.Drawing.Point(154, 70);
            this.formFactorLabel.Name = "formFactorLabel";
            this.formFactorLabel.Size = new System.Drawing.Size(92, 13);
            this.formFactorLabel.TabIndex = 60;
            this.formFactorLabel.Text = "ФОРМ ФАКТОР";
            // 
            // capacityValueLabel
            // 
            this.capacityValueLabel.AutoSize = true;
            this.capacityValueLabel.Location = new System.Drawing.Point(110, 99);
            this.capacityValueLabel.Name = "capacityValueLabel";
            this.capacityValueLabel.Size = new System.Drawing.Size(35, 13);
            this.capacityValueLabel.TabIndex = 59;
            this.capacityValueLabel.Text = "label6";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(5, 99);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(99, 13);
            this.capacityLabel.TabIndex = 58;
            this.capacityLabel.Text = "ОБЪЕМ ПАМЯТИ:";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.Location = new System.Drawing.Point(69, 10);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(116, 38);
            this.nameValueLabel.TabIndex = 57;
            this.nameValueLabel.Text = "имя";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 56;
            this.nameLabel.Text = "Название:";
            // 
            // frequencyValueLabel
            // 
            this.frequencyValueLabel.AutoSize = true;
            this.frequencyValueLabel.Location = new System.Drawing.Point(262, 35);
            this.frequencyValueLabel.Name = "frequencyValueLabel";
            this.frequencyValueLabel.Size = new System.Drawing.Size(41, 13);
            this.frequencyValueLabel.TabIndex = 71;
            this.frequencyValueLabel.Text = "label11";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(154, 35);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(65, 13);
            this.frequencyLabel.TabIndex = 70;
            this.frequencyLabel.Text = "СКОРОСТЬ";
            // 
            // RamUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.frequencyValueLabel);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.editPictureBox);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.priceValueLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionValueLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.ramTypeValueLabel);
            this.Controls.Add(this.ramTypeLabel);
            this.Controls.Add(this.formFactorValueLabel);
            this.Controls.Add(this.formFactorLabel);
            this.Controls.Add(this.capacityValueLabel);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "RamUserControl";
            this.Size = new System.Drawing.Size(499, 135);
            this.Load += new System.EventHandler(this.RamUserControl_Load);
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
        private System.Windows.Forms.Label ramTypeValueLabel;
        private System.Windows.Forms.Label ramTypeLabel;
        private System.Windows.Forms.Label formFactorValueLabel;
        private System.Windows.Forms.Label formFactorLabel;
        private System.Windows.Forms.Label capacityValueLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label frequencyValueLabel;
        private System.Windows.Forms.Label frequencyLabel;
    }
}
