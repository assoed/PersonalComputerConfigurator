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
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.Location = new System.Drawing.Point(59, 12);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(27, 13);
            this.nameValueLabel.TabIndex = 1;
            this.nameValueLabel.Text = "имя";
            // 
            // socketLabel
            // 
            this.socketLabel.AutoSize = true;
            this.socketLabel.Location = new System.Drawing.Point(3, 37);
            this.socketLabel.Name = "socketLabel";
            this.socketLabel.Size = new System.Drawing.Size(49, 13);
            this.socketLabel.TabIndex = 2;
            this.socketLabel.Text = "СОКЕТ: ";
            // 
            // socketValueLabel
            // 
            this.socketValueLabel.AutoSize = true;
            this.socketValueLabel.Location = new System.Drawing.Point(58, 37);
            this.socketValueLabel.Name = "socketValueLabel";
            this.socketValueLabel.Size = new System.Drawing.Size(36, 13);
            this.socketValueLabel.TabIndex = 3;
            this.socketValueLabel.Text = "сокет";
            this.socketValueLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // tdpLabel
            // 
            this.tdpLabel.AutoSize = true;
            this.tdpLabel.Location = new System.Drawing.Point(3, 64);
            this.tdpLabel.Name = "tdpLabel";
            this.tdpLabel.Size = new System.Drawing.Size(32, 13);
            this.tdpLabel.TabIndex = 4;
            this.tdpLabel.Text = "TDP:";
            // 
            // tdpValueLabel
            // 
            this.tdpValueLabel.AutoSize = true;
            this.tdpValueLabel.Location = new System.Drawing.Point(44, 64);
            this.tdpValueLabel.Name = "tdpValueLabel";
            this.tdpValueLabel.Size = new System.Drawing.Size(35, 13);
            this.tdpValueLabel.TabIndex = 5;
            this.tdpValueLabel.Text = "label6";
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.AutoSize = true;
            this.descriptionValueLabel.Location = new System.Drawing.Point(239, 64);
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionValueLabel.TabIndex = 11;
            this.descriptionValueLabel.Text = "label7";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(172, 64);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "ОПИСАНИЕ:";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // boostValueLabel
            // 
            this.boostValueLabel.AutoSize = true;
            this.boostValueLabel.Location = new System.Drawing.Point(233, 37);
            this.boostValueLabel.Name = "boostValueLabel";
            this.boostValueLabel.Size = new System.Drawing.Size(35, 13);
            this.boostValueLabel.TabIndex = 9;
            this.boostValueLabel.Text = "label9";
            // 
            // boostLabel
            // 
            this.boostLabel.AutoSize = true;
            this.boostLabel.Location = new System.Drawing.Point(172, 37);
            this.boostLabel.Name = "boostLabel";
            this.boostLabel.Size = new System.Drawing.Size(53, 13);
            this.boostLabel.TabIndex = 8;
            this.boostLabel.Text = "РАЗГОН:";
            // 
            // frequencyValueLabel
            // 
            this.frequencyValueLabel.AutoSize = true;
            this.frequencyValueLabel.Location = new System.Drawing.Point(239, 12);
            this.frequencyValueLabel.Name = "frequencyValueLabel";
            this.frequencyValueLabel.Size = new System.Drawing.Size(41, 13);
            this.frequencyValueLabel.TabIndex = 7;
            this.frequencyValueLabel.Text = "label11";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(172, 12);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(61, 13);
            this.frequencyLabel.TabIndex = 6;
            this.frequencyLabel.Text = "ЧАСТОТА:";
            this.frequencyLabel.Click += new System.EventHandler(this.frequencyLabel_Click);
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(415, 64);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(41, 13);
            this.priceValueLabel.TabIndex = 17;
            this.priceValueLabel.Text = "label13";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(346, 64);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 13);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "ЦЕНА:";
            // 
            // threadsValueLabel
            // 
            this.threadsValueLabel.AutoSize = true;
            this.threadsValueLabel.Location = new System.Drawing.Point(415, 37);
            this.threadsValueLabel.Name = "threadsValueLabel";
            this.threadsValueLabel.Size = new System.Drawing.Size(41, 13);
            this.threadsValueLabel.TabIndex = 15;
            this.threadsValueLabel.Text = "label15";
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.Location = new System.Drawing.Point(346, 37);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(63, 13);
            this.threadsLabel.TabIndex = 14;
            this.threadsLabel.Text = "ПОТОКОВ:";
            // 
            // coresValueLabel
            // 
            this.coresValueLabel.AutoSize = true;
            this.coresValueLabel.Location = new System.Drawing.Point(415, 12);
            this.coresValueLabel.Name = "coresValueLabel";
            this.coresValueLabel.Size = new System.Drawing.Size(41, 13);
            this.coresValueLabel.TabIndex = 13;
            this.coresValueLabel.Text = "label17";
            // 
            // coresLabel
            // 
            this.coresLabel.AutoSize = true;
            this.coresLabel.Location = new System.Drawing.Point(346, 12);
            this.coresLabel.Name = "coresLabel";
            this.coresLabel.Size = new System.Drawing.Size(41, 13);
            this.coresLabel.TabIndex = 12;
            this.coresLabel.Text = "ЯДЕР:";
            // 
            // processorsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "processorsUserControl";
            this.Size = new System.Drawing.Size(499, 135);
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
    }
}
