using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void Cat_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(Properties.Resources.Kat_Big);
            WorkPlace new_WorkPlace = new WorkPlace(image, "Кошак", this);
            new_WorkPlace.Show();
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Lion_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(Properties.Resources.Lion);
            WorkPlace new_WorkPlace = new WorkPlace(image, "Симба", this);
            new_WorkPlace.Show();
            this.Hide();
        }

        private void Jerry_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(Properties.Resources.Jerry);
            WorkPlace new_WorkPlace = new WorkPlace(image, "Джерри", this);
            new_WorkPlace.Show();
            this.Hide();
        }
    }
}
