using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    public class Enemy
    {
        public Bitmap picture { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Point coords { get; set; }
        public int enemyStart { get; set; }
        public Enemy(Bitmap pic,int X,int Y)
        {
            picture = pic;
           
            x = X;
            y = Y;
            coords = new Point(x, y);
            enemyStart = x;    
        }

        public bool hitEnemy(int X, int Y,char s)
        {
            if (s == 'r') {
                if (X + 100 > x && X + 100 < x + 50 && Y+100>y)
                    return true;
                else
                    return false;
            }
            else {
                if(X> x && X < x + 50 && Y + 100 > y)
                    return true;
                else
                    return false;

            }
           

        }

    }
}
