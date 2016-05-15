using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RAWR
{
    public class Box
    {
        public Bitmap picture { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Point coords { get; set; }
        

        public Box(Bitmap pic,int X, int Y) {
            picture = pic;
            x = X;
            y = Y;
            coords = new Point(x, y);
           
        }

        public bool pixelInBox(int X) {
            if (X > x && X < x + 100)
                return true;
            else return false;

        }

        public void moveLeft() {
            x = x - 10;
            coords = new Point(x, y);

        }
        public void moveRight()
        {
            x = x + 10;
            coords = new Point(x, y);

        }

    }
}
