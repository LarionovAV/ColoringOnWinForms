using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kursach
{
    public partial class WorkPlace : Form
    {
        private bool saved = false;
        private Bitmap bmp;
        private Paint MyPaint;
        private Main_Window Main;
        public WorkPlace(Bitmap image, string name, Main_Window form1)
        {
            Main = form1;
            InitializeComponent();
            for (int i = 0; i < image.Size.Width; i++)
                for (int j = 0; j < image.Size.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image.Width - 1 || j == image.Height - 1)
                        image.SetPixel(i, j, Color.FromArgb(0, 57, 2, 93));
                    if (image.GetPixel(i, j).A == 255)
                        if (image.GetPixel(i, j).R > 180 ||
                            image.GetPixel(i, j).G > 180 ||
                            image.GetPixel(i, j).B > 180)
                            image.SetPixel(i, j, Color.White);
                        else
                            image.SetPixel(i, j, Color.Black);
                }
            Picture.Image = image;
            bmp = image;
            this.Text = name;
        }


        private void Red_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = Red.BackColor;
        }
        private void LightGreen_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = LightGreen.BackColor;
        }
        private void Yellow_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = Yello.BackColor;
        }
        private void DarkBrown_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = DarkBrown.BackColor;
        }
        private void Gray_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = Gray.BackColor;
        }
        private void Orange_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = Orange.BackColor;
        }
        private void Indigo_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = Indigo.BackColor;
        }
        private void Blue_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = Blue.BackColor;
        }
        private void Pink_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = Pink.BackColor;
        }
        private void LightBrown_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = LightBrown.BackColor;
        }
        private void MidleBrown_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = MidleBrown.BackColor;
        }
        private void DarkGreen_Click(object sender, EventArgs e)
        {
            Choosen_Color.BackColor = DarkGreen.BackColor;
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DialogResult Save_File()
        {
            DialogResult result;
            if ((result = SaveFile.ShowDialog()) == DialogResult.OK)
            {
                try
                {
                    Picture.Image.Save(SaveFile.FileName);
                    saved = true;
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить изображение", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            Save_File();
        }
        private void Brush_Click(object sender, EventArgs e)
        {
            if (MyPaint == null)
                MyPaint = new Paint(bmp);
            Brush_Button.BackColor = Color.Yellow;
            Eraser_Button.BackColor = Color.White;
        }
        private void Picture_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (MyPaint != null)
            {
                MyPaint.SetX(e.X);
                MyPaint.SetY(e.Y);               
                MyPaint.SetOldColor(bmp);
                if (Brush_Button.BackColor == Color.Yellow)
                    MyPaint.SetColor(Choosen_Color.BackColor);
                if (MyPaint.GetOldColor() != Color.FromArgb(255, 0, 0, 0) && MyPaint.GetOldColor().A != 0 && Choosen_Color.BackColor != Color.White)
                    MyPaint.Repaint(ref bmp, e.X, e.Y);
                MyPaint.SetError(false);
                MyPaint.SetCalls(0);
            }
            saved = false;
            Picture.Image = bmp;
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                    if (bmp.GetPixel(i, j).A == 255 &&
                        bmp.GetPixel(i, j).R != 0 &&
                        bmp.GetPixel(i, j).G != 0 &&
                        bmp.GetPixel(i, j).B != 0)
                            bmp.SetPixel(i, j, Color.White);
            Picture.Image = bmp;
        }
        private void Eraser_Button_Click(object sender, EventArgs e)
        {
            if (MyPaint == null)
                MyPaint = new Paint(bmp);
            MyPaint.SetColor(Color.FromArgb(255, 255, 255, 255));
            Brush_Button.BackColor = Color.White;
            Eraser_Button.BackColor = Color.Yellow;
        }
        private void WorkPlace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                // Stream myStream;
                string message = "Сохранить ваш рисунок?";
                string caption = "Рисунок не сохранен!!!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    DialogResult res = Save_File();
                    if (res == DialogResult.OK)
                    {
                        Main.Show();
                    }
                    else
                        e.Cancel = true;
                }
                else
                {
                    Main.Show();
                }
            }
            else
            {
                Main.Show();
            }
        }
        public void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
