using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Kursach
{
    class Paint : Tool
    {
        private Color PaintColor = new Color();
        private static int curCalls = 0;
        private static bool error = false;
        private Bitmap image;

        public Paint(Bitmap im)
        {
            image = im;
            PaintColor = Color.FromArgb(0, 0, 0, 0);
        }
        public void SetError(bool value)
        {
            error = value;
        }
        public void SetCalls(int value)
        {
            curCalls = value;
        }
        public void SetColor(Color color)
        {
            PaintColor = color;
        }
        override public void Repaint(ref Bitmap image, int x, int y)
        {
            Color tmp = new Color();
            
            tmp = image.GetPixel(x, y);
            
            if (tmp != OldColor || tmp == PaintColor || error)
                return;
            else
            {
                curCalls++;
                image.SetPixel(x, y, PaintColor);
                if (curCalls <= MAX_REC_CALLS)
                {
                        Repaint(ref image, x - 1, y);
                        Repaint(ref image, x, y + 1);
                        Repaint(ref image, x + 1, y);
                        Repaint(ref image, x, y - 1);
                }
                else
                    error = true;
                curCalls--;
                if (curCalls == MAX_REC_CALLS - 20)
                    error = false;
                return;
            }
           
        }
    }
}
