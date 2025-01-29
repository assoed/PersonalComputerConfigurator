namespace PersonalComputerConfigurator.CustomControls
{
    partial class SsdUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SsdUserControl));
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionValueLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.readingValueLabel = new System.Windows.Forms.Label();
            this.readLabel = new System.Windows.Forms.Label();
            this.writingValueLabel = new System.Windows.Forms.Label();
            this.writingLabel = new System.Windows.Forms.Label();
            this.capacityValueLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
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
            this.editPictureBox.TabIndex = 93;
            this.editPictureBox.TabStop = false;
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(468, 1);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(28, 31);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 92;
            this.deletePictureBox.TabStop = false;
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(370, 99);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(41, 13);
            this.priceValueLabel.TabIndex = 91;
            this.priceValueLabel.Text = "label13";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(301, 99);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 13);
            this.priceLabel.TabIndex = 90;
            this.priceLabel.Text = "ЦЕНА:";
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.AutoSize = true;
            this.descriptionValueLabel.Location = new System.Drawing.Point(3, 58);
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionValueLabel.TabIndex = 89;
            this.descriptionValueLabel.Text = "label7";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 35);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 88;
            this.descriptionLabel.Text = "ОПИСАНИЕ:";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.Location = new System.Drawing.Point(69, 10);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(116, 38);
            this.nameValueLabel.TabIndex = 85;
            this.nameValueLabel.Text = "имя";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 84;
            this.nameLabel.Text = "Название:";
            // 
            // readingValueLabel
            // 
            this.readingValueLabel.AutoSize = true;
            this.readingValueLabel.Location = new System.Drawing.Point(291, 10);
            this.readingValueLabel.Name = "readingValueLabel";
            this.readingValueLabel.Size = new System.Drawing.Size(28, 13);
            this.readingValueLabel.TabIndex = 95;
            this.readingValueLabel.Text = "read";
            this.readingValueLabel.Click += new System.EventHandler(this.readingValueLabel_Click);
            // 
            // readLabel
            // 
            this.readLabel.AutoSize = true;
            this.readLabel.Location = new System.Drawing.Point(211, 10);
            this.readLabel.Name = "readLabel";
            this.readLabel.Size = new System.Drawing.Size(52, 13);
            this.readLabel.TabIndex = 94;
            this.readLabel.Text = "ЧТЕНИЕ";
            this.readLabel.Click += new System.EventHandler(this.readLabel_Click);
            // 
            // writingValueLabel
            // 
            this.writingValueLabel.AutoSize = true;
            this.writingValueLabel.Location = new System.Drawing.Point(291, 39);
            this.writingValueLabel.Name = "writingValueLabel";
            this.writingValueLabel.Size = new System.Drawing.Size(29, 13);
            this.writingValueLabel.TabIndex = 97;
            this.writingValueLabel.Text = "write";
            this.writingValueLabel.Click += new System.EventHandler(this.writingValueLabel_Click);
            // 
            // writingLabel
            // 
            this.writingLabel.AutoSize = true;
            this.writingLabel.Location = new System.Drawing.Point(211, 39);
            this.writingLabel.Name = "writingLabel";
            this.writingLabel.Size = new System.Drawing.Size(54, 13);
            this.writingLabel.TabIndex = 96;
            this.writingLabel.Text = "ЗАПИСЬ:";
            this.writingLabel.Click += new System.EventHandler(this.writingLabel_Click);
            // 
            // capacityValueLabel
            // 
            this.capacityValueLabel.AutoSize = true;
            this.capacityValueLabel.Location = new System.Drawing.Point(291, 70);
            this.capacityValueLabel.Name = "capacityValueLabel";
            this.capacityValueLabel.Size = new System.Drawing.Size(29, 13);
            this.capacityValueLabel.TabIndex = 99;
            this.capacityValueLabel.Text = "write";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(211, 70);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(49, 13);
            this.capacityLabel.TabIndex = 98;
            this.capacityLabel.Text = "ОБЪЕМ:";
            // 
            // SsdUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.capacityValueLabel);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.writingValueLabel);
            this.Controls.Add(this.writingLabel);
            this.Controls.Add(this.readingValueLabel);
            this.Controls.Add(this.readLabel);
            this.Controls.Add(this.editPictureBox);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.priceValueLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionValueLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "SsdUserControl";
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
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label readingValueLabel;
        private System.Windows.Forms.Label readLabel;
        private System.Windows.Forms.Label writingValueLabel;
        private System.Windows.Forms.Label writingLabel;
        private System.Windows.Forms.Label capacityValueLabel;
        private System.Windows.Forms.Label capacityLabel;
    }
}
