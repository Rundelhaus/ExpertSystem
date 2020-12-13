
namespace ConfigurePc
{
    partial class LastQestion
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
            this.MadeButton = new System.Windows.Forms.Button();
            this.ConfigureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backLQButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MadeButton
            // 
            this.MadeButton.Location = new System.Drawing.Point(40, 141);
            this.MadeButton.Name = "MadeButton";
            this.MadeButton.Size = new System.Drawing.Size(75, 23);
            this.MadeButton.TabIndex = 1;
            this.MadeButton.Text = "Made";
            this.MadeButton.UseVisualStyleBackColor = true;
            this.MadeButton.Click += new System.EventHandler(this.MadeButton_Click);
            // 
            // ConfigureButton
            // 
            this.ConfigureButton.Location = new System.Drawing.Point(211, 141);
            this.ConfigureButton.Name = "ConfigureButton";
            this.ConfigureButton.Size = new System.Drawing.Size(75, 23);
            this.ConfigureButton.TabIndex = 2;
            this.ConfigureButton.Text = "Configure";
            this.ConfigureButton.UseVisualStyleBackColor = true;
            this.ConfigureButton.Click += new System.EventHandler(this.ConfigureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вас интересует готовый компьютер, \r\nили желаете подобрать конфигурацию?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backLQButton
            // 
            this.backLQButton.AutoSize = true;
            this.backLQButton.BackColor = System.Drawing.SystemColors.Control;
            this.backLQButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backLQButton.Location = new System.Drawing.Point(12, 189);
            this.backLQButton.Name = "backLQButton";
            this.backLQButton.Size = new System.Drawing.Size(41, 15);
            this.backLQButton.TabIndex = 4;
            this.backLQButton.Text = "Назад";
            this.backLQButton.Click += new System.EventHandler(this.backLQButton_Click);
            // 
            // LastQestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.backLQButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfigureButton);
            this.Controls.Add(this.MadeButton);
            this.Name = "LastQestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastQestion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LastQestion_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MadeButton;
        private System.Windows.Forms.Button ConfigureButton;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label backLQButton;
    }
}