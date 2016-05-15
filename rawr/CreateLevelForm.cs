using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAWR
{
    public partial class CreateLevelForm : Form
    {
        public static Bitmap enemyImg = (Bitmap)Bitmap.FromFile("Images\\vino.png");
        public static Bitmap otherBg = (Bitmap)Bitmap.FromFile("Images\\otherBg.png");
        public static Bitmap coinImg = (Bitmap)Bitmap.FromFile("Images\\coin.gif");
        public static Bitmap boxImg = (Bitmap)Bitmap.FromFile("Images\\box.jpg");
        Bitmap background = (Bitmap)Bitmap.FromFile("Images\\backgroundD&D.jpg");
        Bitmap ground = (Bitmap)Bitmap.FromFile("Images\\ground.png");
       List<Enemy> enemies = new List<Enemy>();
        Enemy enemy = new Enemy(enemyImg,57,219);
        List<Coin> coins = new List<Coin>();
        Coin coin = new Coin(coinImg, 57, 293);
        List<Box> boxes = new List<Box>();
        Box box = new Box(boxImg, 30, 371);
        int curr=0;
        bool enemyBool = false,coinBool=false,boxBool=false;

        public CreateLevelForm()
        {
            InitializeComponent();
            Invalidate();
            DoubleBuffered = true;

        }
        private void playbutton1_MouseHover(object sender, EventArgs e)
        {
            playbutton1.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\play1.png");
        }


        private void playbutton1_MouseLeave(object sender, EventArgs e)
        {
            playbutton1.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\play.png");
        }

        private void leftarrow1_MouseHover(object sender, EventArgs e)
        {
            leftarrow1.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\leftarrow1.png");
        }
        private void leftarrow1_MouseLeave(object sender, EventArgs e)
        {
            leftarrow1.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\leftarrow.png");
        }

        private void leftarrow1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm f = new MainMenuForm();
            f.Show();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(otherBg, 37, 273, 90, 90);
            e.Graphics.DrawImage(otherBg, 37, 199, 90, 90);
            e.Graphics.DrawImage(otherBg, 5, 340, 150, 150);
            e.Graphics.DrawImage(ground, 162, 450, 810, 100);
            e.Graphics.DrawImage(enemy.picture, 57, 219, 50, 50);
            foreach (Enemy en in enemies) {
                e.Graphics.DrawImage(enemyImg, en.x, en.y, 25, 25);
            }
            e.Graphics.DrawImage(coin.picture, 57, 293, 50, 50);
        
            foreach (Coin c in coins)
            {
                e.Graphics.DrawImage(coinImg, c.x, c.y, 25, 25);
            }

            e.Graphics.DrawImage(box.picture, 40, 375, 80, 80);

            foreach (Box b in boxes)
            {
                e.Graphics.DrawImage(boxImg, b.x, b.y, 50, 50);
            }
            e.Graphics.DrawRectangle(new Pen(Color.Black,5), 162, 118, 810, 431);

        }

        private void playbutton1_Click(object sender, EventArgs e)

        {

            foreach (Enemy en in enemies) {
                en.x *= 2;
                en.y -= 20;
            }
            foreach (Coin c in coins)
            {
                c.x*= 2;
                c.y -= 80;
            }
            foreach (Box b in boxes)
            {
                b.x *= 2;
                b.y= (((b.y/50)-4)*100)-40 ;
               
            }
            Level lvl = new Level(this.enemies, this.boxes, this.coins);
            lvl.turtle.x = 2500;
            this.Hide();
            Game game = new Game(lvl,0,0);
            game.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.X > 57 && e.Location.X < 107 && e.Location.Y < 269 && e.Location.Y > 219)
            {

                enemies.Add(new Enemy(enemyImg, e.X, e.Y));
                curr=enemies.Count()-1;
                
                enemyBool = true;
            }
            if (e.Location.X > 57 && e.Location.X < 107 && e.Location.Y < 343 && e.Location.Y > 293)
            {

                coins.Add(new Coin(coinImg, e.X, e.Y));
                curr = coins.Count() - 1;

                coinBool = true;
            }

            if (e.Location.X > 30 && e.Location.X < 130 && e.Location.Y < 471 && e.Location.Y > 371)
            {

                boxes.Add(new Box(boxImg, e.X, e.Y));
                curr = boxes.Count() - 1;
               
                boxBool = true;
            }
        }

   

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (enemyBool) {
                enemies[curr].x = e.X;
                enemies[curr].y= e.Y;
                Invalidate();
            }
            if (coinBool)
            {
                coins[curr].x = e.X;
                coins[curr].y = e.Y;
                Invalidate();
            }
            if (boxBool)
            {
                boxes[curr].x = e.X;
                boxes[curr].y = e.Y;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (enemyBool && e.Location.X > 162 && e.Location.X < 972 && e.Location.Y < 450 && e.Location.Y > 118)
            {
                enemies[curr].x = e.X;
                enemies[curr].y = e.Y;
                enemies[curr].enemyStart = e.X*2;
                Invalidate();
                enemyBool = false;
            }
            if (coinBool && e.Location.X > 162 && e.Location.X < 972 && e.Location.Y < 450 && e.Location.Y > 118)
            {
                coins[curr].x = e.X;
                coins[curr].y = e.Y;
                Invalidate();
                coinBool = false;
            }
            if (boxBool && e.Location.X > 162 && e.Location.X < 972 && e.Location.Y < 450 && e.Location.Y > 118)
            {
                boxes[curr].x = e.X;
                boxes[curr].y = e.Y;
                Invalidate();
                boxBool = false;
            }
        }

       


    }
}
