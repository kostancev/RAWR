using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    public class Level1
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

        public Level1() {
            enche = new Dinosaur();
            //pictureBox1.Image = enche.picture;

            turtle = new FinishLvl(endImg);

            //enemy.Image = marche.picture;
            boxes.Add(new Box(boxImg, 500, 360));
            boxes.Add(new Box(boxImg, 600, 260));
            boxes.Add(new Box(boxImg, 600, 360));

            //box3 = new Box(300, 160);


            boxes.Add(new Box(boxImg, 1300, 360));

            boxes.Add(new Box(boxImg, 1800, 360));
            boxes.Add(new Box(boxImg, 1900, 260));
            boxes.Add(new Box(boxImg, 1900, 360));
            boxes.Add(new Box(boxImg, 2000, 160));
            boxes.Add(new Box(boxImg, 2000, 260));
            boxes.Add(new Box(boxImg, 2000, 360));



            boxes.Add(new Box(boxImg, 3000, 360));
            boxes.Add(new Box(boxImg, 3100, 260));
            boxes.Add(new Box(boxImg, 3100, 360));
            boxes.Add(new Box(boxImg, 3200, 160));
            boxes.Add(new Box(boxImg, 3200, 260));
            boxes.Add(new Box(boxImg, 3200, 360));
            boxes.Add(new Box(boxImg, 3300, 260));
            boxes.Add(new Box(boxImg, 3300, 360));
            boxes.Add(new Box(boxImg, 3400, 360));


            coins.Add(new Coin(coinImg, 625, 160));
            coins.Add(new Coin(coinImg, 1325, 260));
            coins.Add(new Coin(coinImg, 1825, 260));
            coins.Add(new Coin(coinImg, 1925, 160));
            coins.Add(new Coin(coinImg, 2025, 60));
            coins.Add(new Coin(coinImg, 3025, 260));
            coins.Add(new Coin(coinImg, 3125, 160));
            coins.Add(new Coin(coinImg, 3225, 60));
            coins.Add(new Coin(coinImg, 3325, 160));
            coins.Add(new Coin(coinImg, 3425, 260));


            enemies.Add(new Enemy(enemyImg, 900, 410));
            enemies.Add(new Enemy(enemyImg, 4000, 410));

           


        }
    }
}
