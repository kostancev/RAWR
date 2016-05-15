using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    public class Level
    {

        public Dinosaur enche;
        public FinishLvl turtle;
        public List<Enemy> enemies;
        public List<Box> boxes;
        public List<Coin> coins;
        Bitmap endImg = (Bitmap)Bitmap.FromFile("Images\\turtle.png");
        public Level(List<Enemy> Enemies,List<Box> Boxes, List<Coin> Coins)
        {
            enche = new Dinosaur();
           

            turtle = new FinishLvl(endImg);
            enemies = new List<Enemy>();
            boxes = new List<Box>();
            coins = new List<Coin>();
            this.enemies = Enemies;
            this.boxes = Boxes;
            this.coins = Coins;


        }
    }
}
