namespace Kursach
{
    partial class Main_Window
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
            this.ChoicePictLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lion = new System.Windows.Forms.PictureBox();
            this.Jerry = new System.Windows.Forms.PictureBox();
            this.Cat = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jerry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoicePictLabel
            // 
            this.ChoicePictLabel.AutoSize = true;
            this.ChoicePictLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoicePictLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(37)))));
            this.ChoicePictLabel.Location = new System.Drawing.Point(353, 44);
            this.ChoicePictLabel.Name = "ChoicePictLabel";
            this.ChoicePictLabel.Size = new System.Drawing.Size(306, 38);
            this.ChoicePictLabel.TabIndex = 0;
            this.ChoicePictLabel.Text = "Выберите рисунок";
            this.ChoicePictLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Lion
            // 
            this.Lion.Image = global::Kursach.Properties.Resources.Lion_Small;
            this.Lion.Location = new System.Drawing.Point(391, 160);
            this.Lion.Name = "Lion";
            this.Lion.Size = new System.Drawing.Size(200, 192);
            this.Lion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Lion.TabIndex = 3;
            this.Lion.TabStop = false;
            this.Lion.Click += new System.EventHandler(this.Lion_Click);
            // 
            // Jerry
            // 
            this.Jerry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jerry.ErrorImage = global::Kursach.Properties.Resources.Jerry_Small;
            this.Jerry.Image = global::Kursach.Properties.Resources.Jerry_Small;
            this.Jerry.Location = new System.Drawing.Point(728, 122);
            this.Jerry.Name = "Jerry";
            this.Jerry.Size = new System.Drawing.Size(200, 250);
            this.Jerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Jerry.TabIndex = 1;
            this.Jerry.TabStop = false;
            this.Jerry.Click += new System.EventHandler(this.Jerry_Click);
            // 
            // Cat
            // 
            this.Cat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cat.Image = global::Kursach.Properties.Resources.Kat_Small;
            this.Cat.Location = new System.Drawing.Point(32, 122);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(200, 245);
            this.Cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Cat.TabIndex = 1;
            this.Cat.TabStop = false;
            this.Cat.Click += new System.EventHandler(this.Cat_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(2)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.Lion);
            this.Controls.Add(this.Jerry);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.ChoicePictLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.Text = "Раскраска";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jerry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChoicePictLabel;
        private System.Windows.Forms.PictureBox Cat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox Lion;
        private System.Windows.Forms.PictureBox Jerry;
    }
}

