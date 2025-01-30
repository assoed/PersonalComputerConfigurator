namespace PersonalComputerConfigurator.CustomControls
{
    partial class GpuUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GpuUserControl));
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.memoryTypeValueLabel = new System.Windows.Forms.Label();
            this.memoryTypeLabel = new System.Windows.Forms.Label();
            this.memoryValueLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.descriptionValueLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.boostValueLabel = new System.Windows.Forms.Label();
            this.boostLabel = new System.Windows.Forms.Label();
            this.frequencyValueLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.tdpValueLabel = new System.Windows.Forms.Label();
            this.tdpLabel = new System.Windows.Forms.Label();
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
            // memoryTypeValueLabel
            // 
            this.memoryTypeValueLabel.AutoSize = true;
            this.memoryTypeValueLabel.Location = new System.Drawing.Point(396, 51);
            this.memoryTypeValueLabel.Name = "memoryTypeValueLabel";
            this.memoryTypeValueLabel.Size = new System.Drawing.Size(41, 13);
            this.memoryTypeValueLabel.TabIndex = 35;
            this.memoryTypeValueLabel.Text = "label15";
            // 
            // memoryTypeLabel
            // 
            this.memoryTypeLabel.Location = new System.Drawing.Point(329, 35);
            this.memoryTypeLabel.Name = "memoryTypeLabel";
            this.memoryTypeLabel.Size = new System.Drawing.Size(63, 29);
            this.memoryTypeLabel.TabIndex = 34;
            this.memoryTypeLabel.Text = "ТИП ПАМЯТИ:";
            // 
            // memoryValueLabel
            // 
            this.memoryValueLabel.AutoSize = true;
            this.memoryValueLabel.Location = new System.Drawing.Point(396, 10);
            this.memoryValueLabel.Name = "memoryValueLabel";
            this.memoryValueLabel.Size = new System.Drawing.Size(41, 13);
            this.memoryValueLabel.TabIndex = 33;
            this.memoryValueLabel.Text = "label17";
            // 
            // memoryLabel
            // 
            this.memoryLabel.Location = new System.Drawing.Point(329, 1);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(61, 38);
            this.memoryLabel.TabIndex = 32;
            this.memoryLabel.Text = "ОБЪЕМ ПАМЯТИ:";
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.AutoSize = true;
            this.descriptionValueLabel.Location = new System.Drawing.Point(82, 70);
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionValueLabel.TabIndex = 31;
            this.descriptionValueLabel.Text = "label7";
            this.descriptionValueLabel.Click += new System.EventHandler(this.descriptionValueLabel_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(5, 70);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 30;
            this.descriptionLabel.Text = "ОПИСАНИЕ:";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // boostValueLabel
            // 
            this.boostValueLabel.AutoSize = true;
            this.boostValueLabel.Location = new System.Drawing.Point(271, 35);
            this.boostValueLabel.Name = "boostValueLabel";
            this.boostValueLabel.Size = new System.Drawing.Size(35, 13);
            this.boostValueLabel.TabIndex = 29;
            this.boostValueLabel.Text = "label9";
            // 
            // boostLabel
            // 
            this.boostLabel.AutoSize = true;
            this.boostLabel.Location = new System.Drawing.Point(212, 35);
            this.boostLabel.Name = "boostLabel";
            this.boostLabel.Size = new System.Drawing.Size(53, 13);
            this.boostLabel.TabIndex = 28;
            this.boostLabel.Text = "РАЗГОН:";
            // 
            // frequencyValueLabel
            // 
            this.frequencyValueLabel.AutoSize = true;
            this.frequencyValueLabel.Location = new System.Drawing.Point(271, 10);
            this.frequencyValueLabel.Name = "frequencyValueLabel";
            this.frequencyValueLabel.Size = new System.Drawing.Size(41, 13);
            this.frequencyValueLabel.TabIndex = 27;
            this.frequencyValueLabel.Text = "label11";
            this.frequencyValueLabel.Click += new System.EventHandler(this.frequencyValueLabel_Click);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(205, 10);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(61, 13);
            this.frequencyLabel.TabIndex = 26;
            this.frequencyLabel.Text = "ЧАСТОТА:";
            this.frequencyLabel.Click += new System.EventHandler(this.frequencyLabel_Click);
            // 
            // tdpValueLabel
            // 
            this.tdpValueLabel.AutoSize = true;
            this.tdpValueLabel.Location = new System.Drawing.Point(41, 35);
            this.tdpValueLabel.Name = "tdpValueLabel";
            this.tdpValueLabel.Size = new System.Drawing.Size(35, 13);
            this.tdpValueLabel.TabIndex = 25;
            this.tdpValueLabel.Text = "label6";
            // 
            // tdpLabel
            // 
            this.tdpLabel.AutoSize = true;
            this.tdpLabel.Location = new System.Drawing.Point(3, 35);
            this.tdpLabel.Name = "tdpLabel";
            this.tdpLabel.Size = new System.Drawing.Size(32, 13);
            this.tdpLabel.TabIndex = 24;
            this.tdpLabel.Text = "TDP:";
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
            // GpuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.editPictureBox);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.priceValueLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.memoryTypeValueLabel);
            this.Controls.Add(this.memoryTypeLabel);
            this.Controls.Add(this.memoryValueLabel);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.descriptionValueLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.boostValueLabel);
            this.Controls.Add(this.boostLabel);
            this.Controls.Add(this.frequencyValueLabel);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.tdpValueLabel);
            this.Controls.Add(this.tdpLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "GpuUserControl";
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
        private System.Windows.Forms.Label memoryTypeValueLabel;
        private System.Windows.Forms.Label memoryTypeLabel;
        private System.Windows.Forms.Label memoryValueLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label descriptionValueLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label boostValueLabel;
        private System.Windows.Forms.Label boostLabel;
        private System.Windows.Forms.Label frequencyValueLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label tdpValueLabel;
        private System.Windows.Forms.Label tdpLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
