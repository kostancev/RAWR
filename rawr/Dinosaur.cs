using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    public class Dinosaur
    {
        public Bitmap picture { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Point coords { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public char side { get; set; }

        public int start { get; set; }

        public Dinosaur() {
            picture = (Bitmap)Bitmap.FromFile("Images\\dino.png");
            x = 100;
            y = 360;
            coords = new Point(x, y);
            width = picture.Size.Width;
            height = picture.Size.Height;
            side = 'r';
            start = x;
            
        }

        public void changeSide() {
            if (side == 'r')
            {
               
                side = 'l';
            }
            else {
                side = 'r';
            }
            picture.RotateFlip(RotateFlipType.Rotate180FlipY);
        }

    }
}
