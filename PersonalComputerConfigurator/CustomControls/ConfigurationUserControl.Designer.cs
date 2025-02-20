namespace PersonalComputerConfigurator.CustomControls
{
    partial class ConfigurationUserControl
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
            this.configLabel = new System.Windows.Forms.Label();
            this.configNameLabel = new System.Windows.Forms.Label();
            this.configDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Location = new System.Drawing.Point(19, 102);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(35, 13);
            this.configLabel.TabIndex = 0;
            this.configLabel.Text = "label1";
            // 
            // configNameLabel
            // 
            this.configNameLabel.AutoSize = true;
            this.configNameLabel.Location = new System.Drawing.Point(19, 32);
            this.configNameLabel.Name = "configNameLabel";
            this.configNameLabel.Size = new System.Drawing.Size(35, 13);
            this.configNameLabel.TabIndex = 1;
            this.configNameLabel.Text = "label1";
            // 
            // configDateLabel
            // 
            this.configDateLabel.AutoSize = true;
            this.configDateLabel.Location = new System.Drawing.Point(310, 136);
            this.configDateLabel.Name = "configDateLabel";
            this.configDateLabel.Size = new System.Drawing.Size(35, 13);
            this.configDateLabel.TabIndex = 2;
            this.configDateLabel.Text = "label1";
            // 
            // ConfigurationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.configDateLabel);
            this.Controls.Add(this.configNameLabel);
            this.Controls.Add(this.configLabel);
            this.Name = "ConfigurationUserControl";
            this.Size = new System.Drawing.Size(431, 158);
            this.Click += new System.EventHandler(this.ConfigurationUserControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.Label configNameLabel;
        private System.Windows.Forms.Label configDateLabel;
    }
}
