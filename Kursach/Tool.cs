using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Kursach
{
    abstract class Tool
    {
        protected const int MAX_REC_CALLS = 7500;
        protected int x, y;
        protected Color OldColor;
        public abstract void Repaint(ref Bitmap image, int x, int y);
        public void SetX(int value)
        {
            x = value;
        }
        public void SetY(int value)
        {
            y = value;
        }
        public void SetOldColor(Bitmap image)
        {
            OldColor = image.GetPixel(x, y);
        }
        public Color GetOldColor()
        {
            return OldColor;
        }
    }
}
