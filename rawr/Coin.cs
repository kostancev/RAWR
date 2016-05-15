using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    public class Coin
    {
        public Bitmap picture { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Point coords { get; set; }

        public Coin(Bitmap pic,int X, int Y) {
            picture = pic;
            x = X;
            y = Y;
            coords = new Point(x, y);
        }

        public void moveLeft()
        {
            x = x - 10;
            coords = new Point(x, y);

        }
        public void moveRight()
        {
            x = x + 10;
            coords = new Point(x, y);

        }

        public bool catchCoin(int X,int Y,char s){
            if (s == 'r')
            {
                Console.WriteLine(X + " " + Y);
                Console.WriteLine(x + " " + y);

                if ((X+100  > x && X + 100 < x+50 && Y + 100 > y+50)||(X+100>x+50 && X<x && Y + 100 > y+50 && Y<y))
                    return true;
                else return false;
            }
            else {
                if ((X < x+50 && X  > x && Y + 100 > y && Y < y) || (X < x  && X > x+50 && Y + 100 > y && Y < y))
                    return true;
                else return false;
            }


            

            }

    }
}
