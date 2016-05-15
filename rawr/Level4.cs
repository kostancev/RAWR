using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    public class Level4
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

        public Level4()
        {
            enche = new Dinosaur();
            turtle = new FinishLvl(endImg);
            boxes.Add(new Box(boxImg, 500, 360));
            boxes.Add(new Box(boxImg, 600, 260));
            boxes.Add(new Box(boxImg, 600, 360));
            boxes.Add(new Box(boxImg, 700, 160));
            boxes.Add(new Box(boxImg, 700, 260));
            boxes.Add(new Box(boxImg, 700, 360));
            boxes.Add(new Box(boxImg, 800, 260));
            boxes.Add(new Box(boxImg, 800, 360));
            boxes.Add(new Box(boxImg, 900, 160));
            boxes.Add(new Box(boxImg, 900, 260));
            boxes.Add(new Box(boxImg, 900, 360));
            boxes.Add(new Box(boxImg, 1000, 360));
            boxes.Add(new Box(boxImg, 1100, 260));
            boxes.Add(new Box(boxImg, 1100, 360));
            boxes.Add(new Box(boxImg, 2000, 360));
            boxes.Add(new Box(boxImg, 2100, 260));
            boxes.Add(new Box(boxImg, 2100, 360));
            boxes.Add(new Box(boxImg, 2200, 160));
            boxes.Add(new Box(boxImg, 2200, 260));
            boxes.Add(new Box(boxImg, 2200, 360));
            boxes.Add(new Box(boxImg, 2300, 160));
            boxes.Add(new Box(boxImg, 2300, 260));
            boxes.Add(new Box(boxImg, 2300, 360));
            boxes.Add(new Box(boxImg, 2400, 360));


            enemies.Add(new Enemy(enemyImg, 1600, 410));
            enemies.Add(new Enemy(enemyImg, 2700, 410));
            enemies.Add(new Enemy(enemyImg, 3000, 410));

        
            coins.Add(new Coin(coinImg, 525, 260));
            coins.Add(new Coin(coinImg, 725, 60));
            coins.Add(new Coin(coinImg, 925, 60));
            coins.Add(new Coin(coinImg, 1125, 160));
            coins.Add(new Coin(coinImg, 1525, 360));
            coins.Add(new Coin(coinImg, 2225, 60));
            coins.Add(new Coin(coinImg, 2325, 60));
            coins.Add(new Coin(coinImg, 2425, 260));
            coins.Add(new Coin(coinImg, 2725, 360));
            coins.Add(new Coin(coinImg, 3025, 360));
        }
    }
}


