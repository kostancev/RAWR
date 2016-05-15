using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
        public class Level2
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

        public Level2()
            {
                enche = new Dinosaur();
            turtle = new FinishLvl(endImg);

            boxes.Add(new Box(boxImg, 500, 360));
                boxes.Add(new Box(boxImg, 600, 260));
                boxes.Add(new Box(boxImg, 600, 360));
                boxes.Add(new Box(boxImg, 700, 360));
                boxes.Add(new Box(boxImg, 800, 360));
                boxes.Add(new Box(boxImg, 2400, 260));
                boxes.Add(new Box(boxImg, 2400, 260));
                boxes.Add(new Box(boxImg, 2300, 360));
                boxes.Add(new Box(boxImg, 2400, 360));
                boxes.Add(new Box(boxImg, 3200, 360));
                boxes.Add(new Box(boxImg, 3300, 360));
                boxes.Add(new Box(boxImg, 3400, 260));
                boxes.Add(new Box(boxImg, 3400, 360));
                boxes.Add(new Box(boxImg, 3500, 160));
                boxes.Add(new Box(boxImg, 3500, 260));
                boxes.Add(new Box(boxImg, 3500, 360));

                enemies.Add(new Enemy(enemyImg, 1100, 410));
                enemies.Add(new Enemy(enemyImg, 1600, 410));
                enemies.Add(new Enemy(enemyImg, 2100, 410));
                enemies.Add(new Enemy(enemyImg, 2800, 410));


                coins.Add(new Coin(coinImg, 625, 160));
                coins.Add(new Coin(coinImg, 825, 260));
                coins.Add(new Coin(coinImg, 1020, 360));
                coins.Add(new Coin(coinImg, 1520, 360));
                coins.Add(new Coin(coinImg, 2020, 360));
                coins.Add(new Coin(coinImg, 2400, 150));
                coins.Add(new Coin(coinImg, 2710, 360));
                coins.Add(new Coin(coinImg, 3525, 60));
                coins.Add(new Coin(coinImg, 3225, 160));
                coins.Add(new Coin(coinImg, 3900, 360));
                
        }
        }
 }

