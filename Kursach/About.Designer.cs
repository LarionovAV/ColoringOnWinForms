namespace Kursach
{
    partial class About
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AboutBox = new System.Windows.Forms.TabControl();
            this.GeneralInfo = new System.Windows.Forms.TabPage();
            this.TextGeneral = new System.Windows.Forms.Label();
            this.Control = new System.Windows.Forms.TabPage();
            this.TextControl = new System.Windows.Forms.Label();
            this.AboutBox.SuspendLayout();
            this.GeneralInfo.SuspendLayout();
            this.Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutBox
            // 
            this.AboutBox.Controls.Add(this.GeneralInfo);
            this.AboutBox.Controls.Add(this.Control);
            this.AboutBox.Location = new System.Drawing.Point(40, 60);
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.SelectedIndex = 0;
            this.AboutBox.Size = new System.Drawing.Size(450, 400);
            this.AboutBox.TabIndex = 0;
            // 
            // GeneralInfo
            // 
            this.GeneralInfo.AutoScroll = true;
            this.GeneralInfo.Controls.Add(this.TextGeneral);
            this.GeneralInfo.Location = new System.Drawing.Point(4, 25);
            this.GeneralInfo.Name = "GeneralInfo";
            this.GeneralInfo.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralInfo.Size = new System.Drawing.Size(442, 371);
            this.GeneralInfo.TabIndex = 0;
            this.GeneralInfo.Text = "Основные сведения";
            this.GeneralInfo.UseVisualStyleBackColor = true;
            // 
            // TextGeneral
            // 
            this.TextGeneral.AutoSize = true;
            this.TextGeneral.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextGeneral.Location = new System.Drawing.Point(6, 19);
            this.TextGeneral.MaximumSize = new System.Drawing.Size(440, 0);
            this.TextGeneral.Name = "TextGeneral";
            this.TextGeneral.Size = new System.Drawing.Size(410, 161);
            this.TextGeneral.TabIndex = 0;
            this.TextGeneral.Text = "Игра \"Раскраска\".\r\nДанный программный продукт служит для развлечения и отдыха от " +
                "повседневной рутины.\r\nПроявите свои творческие и дизайнерские навыки, раскрасив " +
                "картинку.\r\nРазвлекайтесь.";
            // 
            // Control
            // 
            this.Control.AutoScroll = true;
            this.Control.Controls.Add(this.TextControl);
            this.Control.Location = new System.Drawing.Point(4, 25);
            this.Control.Name = "Control";
            this.Control.Padding = new System.Windows.Forms.Padding(3);
            this.Control.Size = new System.Drawing.Size(442, 371);
            this.Control.TabIndex = 1;
            this.Control.Text = "Как играть";
            this.Control.UseVisualStyleBackColor = true;
            // 
            // TextControl
            // 
            this.TextControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextControl.Location = new System.Drawing.Point(3, 3);
            this.TextControl.Name = "TextControl";
            this.TextControl.Size = new System.Drawing.Size(412, 511);
            this.TextControl.TabIndex = 0;
            this.TextControl.Text = resources.GetString("TextControl.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 523);
            this.Controls.Add(this.AboutBox);
            this.Name = "About";
            this.Text = "О программе";
            this.AboutBox.ResumeLayout(false);
            this.GeneralInfo.ResumeLayout(false);
            this.GeneralInfo.PerformLayout();
            this.Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AboutBox;
        private System.Windows.Forms.TabPage GeneralInfo;
        private System.Windows.Forms.Label TextGeneral;
        private System.Windows.Forms.TabPage Control;
        private System.Windows.Forms.Label TextControl;
    }
}