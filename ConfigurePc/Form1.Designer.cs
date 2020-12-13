
namespace ConfigurePc
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PersonalUseButon = new System.Windows.Forms.Button();
            this.officeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonalUseButon
            // 
            this.PersonalUseButon.Location = new System.Drawing.Point(52, 114);
            this.PersonalUseButon.Name = "PersonalUseButon";
            this.PersonalUseButon.Size = new System.Drawing.Size(103, 38);
            this.PersonalUseButon.TabIndex = 0;
            this.PersonalUseButon.Text = "Личное пользование";
            this.PersonalUseButon.UseVisualStyleBackColor = true;
            this.PersonalUseButon.Click += new System.EventHandler(this.PersonalUseButton_Click);
            // 
            // officeButton
            // 
            this.officeButton.Location = new System.Drawing.Point(230, 114);
            this.officeButton.Name = "officeButton";
            this.officeButton.Size = new System.Drawing.Size(101, 38);
            this.officeButton.TabIndex = 1;
            this.officeButton.Text = "Работа в офисе";
            this.officeButton.UseVisualStyleBackColor = true;
            this.officeButton.Click += new System.EventHandler(this.officeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Для каких целей \r\nтребуется персональный компьютер?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.officeButton);
            this.Controls.Add(this.PersonalUseButon);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure your PC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PersonalUseButon;
        private System.Windows.Forms.Button officeButton;
        private System.Windows.Forms.Label label1;
    }
}

