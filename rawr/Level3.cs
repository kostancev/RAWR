
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    public class Level3
    {
        public int score = 0;
        public int points = 0;
        public Dinosaur enche;
        public FinishLvl turtle;
        public List<Enemy> enemies = new List<Enemy>();
        public List<Box> boxes = new List<Box>();
        public List<Coin> coins = new List<Coin>();
        public int[] yLine = new int[5000];
       
   
        Bitmap groundImg = (Bitmap)Bitmap.FromFile("Images\\ground.png");
        Bitmap boxImg = (Bitmap)Bitmap.FromFile("Images\\box.jpg");
        Bitmap enemyImg = (Bitmap)Bitmap.FromFile("Images\\vino.png");
        Bitmap coinImg = (Bitmap)Bitmap.FromFile("Images\\coin.gif");
        Bitmap endImg = (Bitmap)Bitmap.FromFile("Images\\turtle.png");

        public Level3()
        {
            enche = new Dinosaur();
            turtle = new FinishLvl(endImg);

            boxes.Add(new Box(boxImg, 1100, 360));
            boxes.Add(new Box(boxImg, 1200, 260));
            boxes.Add(new Box(boxImg, 1200, 360));
            boxes.Add(new Box(boxImg, 1300, 260));
            boxes.Add(new Box(boxImg, 1300, 360));
            boxes.Add(new Box(boxImg, 1400, 160));
            boxes.Add(new Box(boxImg, 1400, 260));
            boxes.Add(new Box(boxImg, 1400, 360));
            boxes.Add(new Box(boxImg, 1500, 260));
            boxes.Add(new Box(boxImg, 1500, 360));
            boxes.Add(new Box(boxImg, 1600, 360));
            boxes.Add(new Box(boxImg, 3200, 360));
            boxes.Add(new Box(boxImg, 3300, 260));
            boxes.Add(new Box(boxImg, 3300, 360));
            boxes.Add(new Box(boxImg, 3400, 160));
            boxes.Add(new Box(boxImg, 3400, 260));
            boxes.Add(new Box(boxImg, 3400, 360));
            boxes.Add(new Box(boxImg, 3500, 60));
            boxes.Add(new Box(boxImg, 3500, 160));
            boxes.Add(new Box(boxImg, 3500, 360));
            boxes.Add(new Box(boxImg, 3600, 160));
            boxes.Add(new Box(boxImg, 3600, 260));
            boxes.Add(new Box(boxImg, 3600, 360));
            boxes.Add(new Box(boxImg, 3700, 260));
            boxes.Add(new Box(boxImg, 3700, 360));
            boxes.Add(new Box(boxImg, 3800, 360));


            enemies.Add(new Enemy(enemyImg, 400, 410));
            enemies.Add(new Enemy(enemyImg, 800, 410));
            enemies.Add(new Enemy(enemyImg, 2000, 410));
            enemies.Add(new Enemy(enemyImg, 2300, 410));
            enemies.Add(new Enemy(enemyImg, 2600, 410));


            coins.Add(new Coin(coinImg, 325, 360));
            coins.Add(new Coin(coinImg, 725, 360));
            coins.Add(new Coin(coinImg, 1225, 160));
            coins.Add(new Coin(coinImg, 1425, 60));
            coins.Add(new Coin(coinImg, 1625, 160));
            coins.Add(new Coin(coinImg, 1925, 360));
            coins.Add(new Coin(coinImg, 2225, 360));
            coins.Add(new Coin(coinImg, 2525, 360));
            coins.Add(new Coin(coinImg, 3425, 60));
            coins.Add(new Coin(coinImg, 3625, 60));

        }
    }
}


