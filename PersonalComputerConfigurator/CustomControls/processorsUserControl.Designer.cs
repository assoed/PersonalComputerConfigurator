namespace PersonalComputerConfigurator.CustomControls
{
    partial class processorsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(processorsUserControl));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.socketLabel = new System.Windows.Forms.Label();
            this.socketValueLabel = new System.Windows.Forms.Label();
            this.tdpLabel = new System.Windows.Forms.Label();
            this.tdpValueLabel = new System.Windows.Forms.Label();
            this.descriptionValueLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.boostValueLabel = new System.Windows.Forms.Label();
            this.boostLabel = new System.Windows.Forms.Label();
            this.frequencyValueLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.threadsValueLabel = new System.Windows.Forms.Label();
            this.threadsLabel = new System.Windows.Forms.Label();
            this.coresValueLabel = new System.Windows.Forms.Label();
            this.coresLabel = new System.Windows.Forms.Label();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название:";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.Location = new System.Drawing.Point(69, 12);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(116, 38);
            this.nameValueLabel.TabIndex = 1;
            this.nameValueLabel.Text = "имя";
            // 
            // socketLabel
            // 
            this.socketLabel.AutoSize = true;
            this.socketLabel.Location = new System.Drawing.Point(3, 53);
            this.socketLabel.Name = "socketLabel";
            this.socketLabel.Size = new System.Drawing.Size(49, 13);
            this.socketLabel.TabIndex = 2;
            this.socketLabel.Text = "СОКЕТ: ";
            this.socketLabel.Click += new System.EventHandler(this.socketLabel_Click);
            // 
            // socketValueLabel
            // 
            this.socketValueLabel.AutoSize = true;
            this.socketValueLabel.Location = new System.Drawing.Point(58, 53);
            this.socketValueLabel.Name = "socketValueLabel";
            this.socketValueLabel.Size = new System.Drawing.Size(36, 13);
            this.socketValueLabel.TabIndex = 3;
            this.socketValueLabel.Text = "сокет";
            this.socketValueLabel.Click += new System.EventHandler(this.socketValueLabel_Click);
            // 
            // tdpLabel
            // 
            this.tdpLabel.AutoSize = true;
            this.tdpLabel.Location = new System.Drawing.Point(10, 101);
            this.tdpLabel.Name = "tdpLabel";
            this.tdpLabel.Size = new System.Drawing.Size(32, 13);
            this.tdpLabel.TabIndex = 4;
            this.tdpLabel.Text = "TDP:";
            this.tdpLabel.Click += new System.EventHandler(this.tdpLabel_Click);
            // 
            // tdpValueLabel
            // 
            this.tdpValueLabel.AutoSize = true;
            this.tdpValueLabel.Location = new System.Drawing.Point(51, 101);
            this.tdpValueLabel.Name = "tdpValueLabel";
            this.tdpValueLabel.Size = new System.Drawing.Size(35, 13);
            this.tdpValueLabel.TabIndex = 5;
            this.tdpValueLabel.Text = "label6";
            this.tdpValueLabel.Click += new System.EventHandler(this.tdpValueLabel_Click);
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.AutoSize = true;
            this.descriptionValueLabel.Location = new System.Drawing.Point(218, 71);
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionValueLabel.TabIndex = 11;
            this.descriptionValueLabel.Text = "label7";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(151, 71);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "ОПИСАНИЕ:";
            // 
            // boostValueLabel
            // 
            this.boostValueLabel.AutoSize = true;
            this.boostValueLabel.Location = new System.Drawing.Point(280, 37);
            this.boostValueLabel.Name = "boostValueLabel";
            this.boostValueLabel.Size = new System.Drawing.Size(35, 13);
            this.boostValueLabel.TabIndex = 9;
            this.boostValueLabel.Text = "label9";
            // 
            // boostLabel
            // 
            this.boostLabel.AutoSize = true;
            this.boostLabel.Location = new System.Drawing.Point(219, 37);
            this.boostLabel.Name = "boostLabel";
            this.boostLabel.Size = new System.Drawing.Size(53, 13);
            this.boostLabel.TabIndex = 8;
            this.boostLabel.Text = "РАЗГОН:";
            // 
            // frequencyValueLabel
            // 
            this.frequencyValueLabel.AutoSize = true;
            this.frequencyValueLabel.Location = new System.Drawing.Point(280, 12);
            this.frequencyValueLabel.Name = "frequencyValueLabel";
            this.frequencyValueLabel.Size = new System.Drawing.Size(41, 13);
            this.frequencyValueLabel.TabIndex = 7;
            this.frequencyValueLabel.Text = "label11";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(213, 12);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(61, 13);
            this.frequencyLabel.TabIndex = 6;
            this.frequencyLabel.Text = "ЧАСТОТА:";
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(370, 101);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(41, 13);
            this.priceValueLabel.TabIndex = 17;
            this.priceValueLabel.Text = "label13";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(301, 101);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 13);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "ЦЕНА:";
            // 
            // threadsValueLabel
            // 
            this.threadsValueLabel.AutoSize = true;
            this.threadsValueLabel.Location = new System.Drawing.Point(396, 37);
            this.threadsValueLabel.Name = "threadsValueLabel";
            this.threadsValueLabel.Size = new System.Drawing.Size(41, 13);
            this.threadsValueLabel.TabIndex = 15;
            this.threadsValueLabel.Text = "label15";
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.Location = new System.Drawing.Point(327, 37);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(63, 13);
            this.threadsLabel.TabIndex = 14;
            this.threadsLabel.Text = "ПОТОКОВ:";
            // 
            // coresValueLabel
            // 
            this.coresValueLabel.AutoSize = true;
            this.coresValueLabel.Location = new System.Drawing.Point(396, 12);
            this.coresValueLabel.Name = "coresValueLabel";
            this.coresValueLabel.Size = new System.Drawing.Size(41, 13);
            this.coresValueLabel.TabIndex = 13;
            this.coresValueLabel.Text = "label17";
            // 
            // coresLabel
            // 
            this.coresLabel.AutoSize = true;
            this.coresLabel.Location = new System.Drawing.Point(327, 12);
            this.coresLabel.Name = "coresLabel";
            this.coresLabel.Size = new System.Drawing.Size(41, 13);
            this.coresLabel.TabIndex = 12;
            this.coresLabel.Text = "ЯДЕР:";
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(468, 3);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(28, 31);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 18;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // editPictureBox
            // 
            this.editPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("editPictureBox.Image")));
            this.editPictureBox.Location = new System.Drawing.Point(438, 83);
            this.editPictureBox.Name = "editPictureBox";
            this.editPictureBox.Size = new System.Drawing.Size(58, 52);
            this.editPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editPictureBox.TabIndex = 19;
            this.editPictureBox.TabStop = false;
            this.editPictureBox.Click += new System.EventHandler(this.editPictureBox_Click);
            // 
            // processorsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.editPictureBox);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.priceValueLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.threadsValueLabel);
            this.Controls.Add(this.threadsLabel);
            this.Controls.Add(this.coresValueLabel);
            this.Controls.Add(this.coresLabel);
            this.Controls.Add(this.descriptionValueLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.boostValueLabel);
            this.Controls.Add(this.boostLabel);
            this.Controls.Add(this.frequencyValueLabel);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.tdpValueLabel);
            this.Controls.Add(this.tdpLabel);
            this.Controls.Add(this.socketValueLabel);
            this.Controls.Add(this.socketLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.nameLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "processorsUserControl";
            this.Size = new System.Drawing.Size(499, 135);
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label socketLabel;
        private System.Windows.Forms.Label socketValueLabel;
        private System.Windows.Forms.Label tdpLabel;
        private System.Windows.Forms.Label tdpValueLabel;
        private System.Windows.Forms.Label descriptionValueLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label boostValueLabel;
        private System.Windows.Forms.Label boostLabel;
        private System.Windows.Forms.Label frequencyValueLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label priceValueLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label threadsValueLabel;
        private System.Windows.Forms.Label threadsLabel;
        private System.Windows.Forms.Label coresValueLabel;
        private System.Windows.Forms.Label coresLabel;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.PictureBox editPictureBox;
    }
}
