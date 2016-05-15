using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    public class FinishLvl
    {
        public Bitmap picture { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public FinishLvl(Bitmap Picture) {
            picture = Picture;
            x = 4500;
            y =400;
        }

        public bool isFinished(int X) {
            if (X+100 > x)
                return true;
            else
                return false;
        }
        public bool isVisible() {
            if (x + 100 < 1000)
                return true;
            else
                return false;
        }
    }
}
