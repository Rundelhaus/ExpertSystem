
namespace ConfigurePc
{
    partial class PersonalUse
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
            this.GamingButton = new System.Windows.Forms.Button();
            this.CasualButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GamingButton
            // 
            this.GamingButton.Location = new System.Drawing.Point(37, 121);
            this.GamingButton.Name = "GamingButton";
            this.GamingButton.Size = new System.Drawing.Size(112, 34);
            this.GamingButton.TabIndex = 0;
            this.GamingButton.Text = "Игровая сборка";
            this.GamingButton.UseVisualStyleBackColor = true;
            this.GamingButton.Click += new System.EventHandler(this.GamingButton_Click);
            // 
            // CasualButton
            // 
            this.CasualButton.Location = new System.Drawing.Point(186, 121);
            this.CasualButton.Name = "CasualButton";
            this.CasualButton.Size = new System.Drawing.Size(123, 34);
            this.CasualButton.TabIndex = 1;
            this.CasualButton.Text = "Обычная сборка";
            this.CasualButton.UseVisualStyleBackColor = true;
            this.CasualButton.Click += new System.EventHandler(this.CasualButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сборка какой направленности \r\nвас интересует?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Назад";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PersonalUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CasualButton);
            this.Controls.Add(this.GamingButton);
            this.Name = "PersonalUse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalUse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonalUse_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GamingButton;
        private System.Windows.Forms.Button CasualButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}