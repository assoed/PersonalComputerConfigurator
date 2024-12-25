namespace PersonalComputerConfigurator.CustomControls
{
    partial class CoolersUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolersUserControl));
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionValueLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.powerValueLabel = new System.Windows.Forms.Label();
            this.PowerSupplyLabel = new System.Windows.Forms.Label();
            this.typeValueLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.materialValueLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
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
            // powerValueLabel
            // 
            this.powerValueLabel.AutoSize = true;
            this.powerValueLabel.Location = new System.Drawing.Point(85, 48);
            this.powerValueLabel.Name = "powerValueLabel";
            this.powerValueLabel.Size = new System.Drawing.Size(35, 13);
            this.powerValueLabel.TabIndex = 63;
            this.powerValueLabel.Text = "label9";
            // 
            // PowerSupplyLabel
            // 
            this.PowerSupplyLabel.AutoSize = true;
            this.PowerSupplyLabel.Location = new System.Drawing.Point(5, 48);
            this.PowerSupplyLabel.Name = "PowerSupplyLabel";
            this.PowerSupplyLabel.Size = new System.Drawing.Size(74, 13);
            this.PowerSupplyLabel.TabIndex = 62;
            this.PowerSupplyLabel.Text = "МОЩНОСТЬ:";
            // 
            // typeValueLabel
            // 
            this.typeValueLabel.AutoSize = true;
            this.typeValueLabel.Location = new System.Drawing.Point(262, 70);
            this.typeValueLabel.Name = "typeValueLabel";
            this.typeValueLabel.Size = new System.Drawing.Size(41, 13);
            this.typeValueLabel.TabIndex = 61;
            this.typeValueLabel.Text = "label11";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(154, 70);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(33, 13);
            this.typeLabel.TabIndex = 60;
            this.typeLabel.Text = "ТИП:";
            // 
            // materialValueLabel
            // 
            this.materialValueLabel.AutoSize = true;
            this.materialValueLabel.Location = new System.Drawing.Point(82, 99);
            this.materialValueLabel.Name = "materialValueLabel";
            this.materialValueLabel.Size = new System.Drawing.Size(35, 13);
            this.materialValueLabel.TabIndex = 59;
            this.materialValueLabel.Text = "label6";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(4, 99);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(70, 13);
            this.materialLabel.TabIndex = 58;
            this.materialLabel.Text = "МАТЕРИАЛ:";
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
            // CoolersUserControl
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
            this.Controls.Add(this.powerValueLabel);
            this.Controls.Add(this.PowerSupplyLabel);
            this.Controls.Add(this.typeValueLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.materialValueLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "CoolersUserControl";
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
        private System.Windows.Forms.Label powerValueLabel;
        private System.Windows.Forms.Label PowerSupplyLabel;
        private System.Windows.Forms.Label typeValueLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label materialValueLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
