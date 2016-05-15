using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAWR
{

    public partial class Game : Form
    {
        Level lvl;
        static int rst_lvl;
        private int[] yLine = new int[5000];
        int groundY = 435;
        int groundX;
        bool goesLeft;
        Bitmap groundImg = (Bitmap)Bitmap.FromFile("Images\\ground.png");
        public int score = 0, sec = 0;
        public Highscores gameHighscores;
        public Game(Level gameLvl, int lvlNumber,int Score)
        {
            score = Score;
            goesLeft = true;
            groundX = 0;
            InitializeComponent();
            timer1.Start();
            lvl = gameLvl;
            rst_lvl = lvlNumber;
            DoubleBuffered = true;
            gameHighscores = new Highscores();
            calculateY();

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (lvl.enche.side != 'l')
                        lvl.enche.changeSide();
                    if (!(yLine[lvl.enche.x - 1] < lvl.enche.y + 100) && lvl.enche.x > 30 && lvl.enche.x > 100)
                        lvl.enche.coords = new Point(lvl.enche.x -= 10, lvl.enche.y);
                    if (yLine[lvl.enche.x + 90] > lvl.enche.y + 100)
                    {
                        while (lvl.enche.y + 100 < yLine[lvl.enche.x])
                        {


                            lvl.enche.coords = new Point(lvl.enche.x, lvl.enche.y += 10);
                            Thread.Sleep(10);

                            Invalidate(true);
                            Application.DoEvents();
                        }
                    }

                    if (lvl.enche.x < 500 && !(yLine[lvl.enche.x - 10] < lvl.enche.y + 100) && groundX < 0)
                    {
                        lvl.turtle.x += 10;
                        foreach (Box b in lvl.boxes)
                        {
                            b.moveRight();
                        }
                        foreach (Coin c in lvl.coins)
                        {
                            c.moveRight();
                        }

                        groundX += 9;
                        foreach (Enemy en in lvl.enemies)
                        {
                            en.x += 9;
                            en.enemyStart += 9;
                        }
                        calculateY();
                    }
                    foreach (Enemy en in lvl.enemies)
                    {
                        if (en.hitEnemy(lvl.enche.x, lvl.enche.y, 'l'))
                        {
                            timer1.Stop();
                            EndGameForm egf = new EndGameForm(score.ToString());
                            DialogResult result = egf.ShowDialog();
                            lvl.enche.x = 0;
                            lvl.enche.y = 0;
                            if (result == DialogResult.OK)
                            {

                                openHighscore();
                                gameHighscores.addHighScore(egf.newHighscore);
                                saveHighscore();
                                HighScoreForm hsf = new HighScoreForm();
                                this.Close();
                                hsf.Show();


                            }
                            else if (egf.ShowDialog() == DialogResult.No)
                            {
                                MainMenuForm mm = new MainMenuForm();
                                this.Close();
                                mm.Show();

                            }
                            else if (result == DialogResult.Retry)
                            {
                                if (rst_lvl == 1)
                                {
                                    Level1 rstLvl = new Level1();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 1,0);
                                    this.Close();
                                    g.Show();
                                }
                                else if (rst_lvl == 2)
                                {
                                    Level2 rstLvl = new Level2();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 2,0);
                                    this.Close();
                                    g.Show();
                                }
                                else if (rst_lvl == 3)
                                {
                                    Level3 rstLvl = new Level3();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 3,0);
                                    this.Close();
                                    g.Show();

                                }
                                else if (rst_lvl == 4)
                                {
                                    Level4 rstLvl = new Level4();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 4,0);
                                    this.Close();
                                    g.Show();

                                }


                            }


                        }

                        Invalidate(true);
                    }

                }




                else if (e.KeyCode == Keys.Right)
                {
                    if (lvl.enche.side != 'r')
                        lvl.enche.changeSide();
                    if (!(yLine[lvl.enche.x + 101] < lvl.enche.y + 100) && lvl.enche.x + 100 < this.Width && (lvl.enche.x + 100 < this.Width - 700 || lvl.turtle.isVisible()))
                        lvl.enche.coords = new Point(lvl.enche.x += 10, lvl.enche.y);

                    if (yLine[lvl.enche.x + 1] > lvl.enche.y + 100)
                    {
                        while (lvl.enche.y + 100 < yLine[lvl.enche.x + 50])
                        {


                            lvl.enche.coords = new Point(lvl.enche.x, lvl.enche.y += 10);
                            // Thread.Sleep(10);

                            Invalidate(true);
                            Application.DoEvents();
                        }
                    }
                    if (!lvl.turtle.isVisible() && lvl.enche.x + 100 > this.Width - 800 && !(yLine[lvl.enche.x + 10 + 100] < lvl.enche.y + 100))
                    {
                        lvl.turtle.x -= 10;
                        foreach (Box b in lvl.boxes)
                        {
                            b.moveLeft();
                        }
                        foreach (Coin c in lvl.coins)
                        {
                            c.moveLeft();
                        }

                        groundX -= 9;
                        foreach (Enemy en in lvl.enemies)
                        {
                            en.x -= 9;
                            en.enemyStart -= 9;
                        }

                        calculateY();
                    }


                    foreach (Enemy en in lvl.enemies)
                    {

                        if (en.hitEnemy(lvl.enche.x, lvl.enche.y, 'r'))
                        {

                            timer1.Stop();
                            EndGameForm egf = new EndGameForm(score.ToString());
                            DialogResult result = egf.ShowDialog();
                            lvl.enche.x = 0;
                            lvl.enche.y = 0;



                            if (result == System.Windows.Forms.DialogResult.OK)
                            {

                                openHighscore();
                                gameHighscores.addHighScore(egf.newHighscore);
                                saveHighscore();
                                HighScoreForm hsf = new HighScoreForm();

                                hsf.Show();
                                this.Close();

                            }
                            else if (result == System.Windows.Forms.DialogResult.No)
                            {
                                this.Close();
                                MainMenuForm mm = new MainMenuForm();
                                mm.Show();

                            }
                            else if (result == System.Windows.Forms.DialogResult.Retry)
                            {
                                if (rst_lvl == 1)
                                {
                                    Level1 rstLvl = new Level1();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 1,0);
                                    this.Close();
                                    g.Show();
                                }
                                else if (rst_lvl == 2)
                                {
                                    Level2 rstLvl = new Level2();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 2,0);
                                    this.Close();
                                    g.Show();
                                }
                                else if (rst_lvl == 3)
                                {
                                    Level3 rstLvl = new Level3();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 3,0);
                                    this.Close();
                                    g.Show();

                                }
                                else if (rst_lvl == 4)
                                {
                                    Level4 rstLvl = new Level4();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 4,0);
                                    this.Close();
                                    g.Show();

                                }


                            }

                        }
                        break;
                    }


                }









                else if (e.KeyCode == Keys.Up)
                {
                    int jumpX = 0, goDown = 0;
                    if (lvl.enche.x - 100 == 0 && (yLine[lvl.enche.x - 10] < lvl.enche.y - 10) || (yLine[lvl.enche.x + 100] == lvl.enche.y - 10)) { jumpX = 0; goDown = 100; }
                    else if (lvl.enche.side == 'r') { jumpX = 6; goDown = 100; }
                    else if (lvl.enche.side == 'l') { jumpX = -6; goDown = 0; }
                    else if ((yLine[lvl.enche.x - 10] < lvl.enche.y + 100) || (yLine[lvl.enche.x + 100] == lvl.enche.y + 100)) { jumpX = 0; goDown = 100; }


                    for (int i = 0; i < 5; i++)
                    {
                        lvl.enche.coords = new Point(lvl.enche.x += jumpX, lvl.enche.y -= 30);
                        Invalidate(true);
                        Application.DoEvents();


                    }


                    while (lvl.enche.x > 0 && lvl.enche.y + 100 < yLine[lvl.enche.x + 20 + goDown])
                    {

                        lvl.enche.coords = new Point(lvl.enche.x += jumpX, lvl.enche.y += 10);
                        Invalidate(true);
                        Application.DoEvents();
                       

                    }



                    Invalidate(true);
                }



                foreach (Coin c in lvl.coins)
                {
                    if (c.catchCoin(lvl.enche.x, lvl.enche.y, lvl.enche.side)) { score++; label1.Text = score.ToString(); lvl.coins.Remove(c); break; }
                    Invalidate();
                }


                if (lvl.turtle.isFinished(lvl.enche.x))
                {

                    NextLevelForm nlf = new NextLevelForm();
                    DialogResult result = nlf.ShowDialog();
                    if (result == DialogResult.No)
                    {
                        MainMenuForm mm = new MainMenuForm();
                        this.Close();
                        mm.Show();
                    }
                    else if (result == DialogResult.Retry)
                    {
                        if (rst_lvl == 1)
                        {
                            Level1 rstLvl = new Level1();
                            lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                            Game g = new Game(lvl, 1, 0);
                            this.Close();
                            g.Show();
                        }
                        else if (rst_lvl == 2)
                        {
                            Level2 rstLvl = new Level2();
                            lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                            Game g = new Game(lvl, 2, 0);
                            this.Close();
                            g.Show();
                        }
                        else if (rst_lvl == 3)
                        {
                            Level3 rstLvl = new Level3();
                            lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                            Game g = new Game(lvl, 3, 0);
                            this.Close();
                            g.Show();

                        }
                        else if (rst_lvl == 4)
                        {
                            Level4 rstLvl = new Level4();
                            lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                            Game g = new Game(lvl, 4, 0);
                            this.Close();
                            g.Show();

                        }

                    }
                    else if (result == DialogResult.Yes)
                    {
                        if (rst_lvl == 1)
                        {
                            Level2 rstLvl = new Level2();
                            lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                            Game g = new Game(lvl, 2, score);
                            this.Close();
                            g.Show();
                        }
                        else if (rst_lvl == 2)
                        {
                            Level3 rstLvl = new Level3();
                            lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                            Game g = new Game(lvl, 3, score);
                            this.Close();
                            g.Show();

                        }
                        else if (rst_lvl == 3)
                        {
                            Level4 rstLvl = new Level4();
                            lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                            Game g = new Game(lvl, 4, score);
                            this.Close();
                            g.Show();

                        }
                        else if (rst_lvl == 4)
                        {
                            timer1.Stop();
                            EndGameForm egf = new EndGameForm(score.ToString());
                            result = egf.ShowDialog();
                            lvl.enche.x = 0;
                            lvl.enche.y = 0;



                            if (result == System.Windows.Forms.DialogResult.OK)
                            {

                                openHighscore();
                                gameHighscores.addHighScore(egf.newHighscore);
                                saveHighscore();
                                HighScoreForm hsf = new HighScoreForm();

                                hsf.Show();
                                this.Close();

                            }
                            else if (result == System.Windows.Forms.DialogResult.No)
                            {
                                this.Close();
                                MainMenuForm mm = new MainMenuForm();
                                mm.Show();

                            }
                            else if (result == System.Windows.Forms.DialogResult.Retry)
                            {
                                if (rst_lvl == 1)
                                {
                                    Level1 rstLvl = new Level1();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 1,0);
                                    this.Close();
                                    g.Show();
                                }
                                else if (rst_lvl == 2)
                                {
                                    Level2 rstLvl = new Level2();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 2,0);
                                    this.Close();
                                    g.Show();
                                }
                                else if (rst_lvl == 3)
                                {
                                    Level3 rstLvl = new Level3();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 3,0);
                                    this.Close();
                                    g.Show();

                                }
                                else if (rst_lvl == 4)
                                {
                                    Level4 rstLvl = new Level4();
                                    lvl = new Level(rstLvl.enemies, rstLvl.boxes, rstLvl.coins);
                                    Game g = new Game(lvl, 4,0);
                                    this.Close();
                                    g.Show();

                                }
                            }
                        }
                    }
                }











            }
            catch (Exception ex)
            {

            }
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawImage(lvl.enche.picture, lvl.enche.x, lvl.enche.y,100,100);
            e.Graphics.DrawImage(lvl.turtle.picture, lvl.turtle.x, lvl.turtle.y, 100, 50);

            for (int i = 0; i < lvl.enemies.Count; i++)
                e.Graphics.DrawImage(lvl.enemies[i].picture, lvl.enemies[i].x, lvl.enemies[i].y, 50, 50);
           

            for (int i=0;i< lvl.boxes.Count;i++)
            e.Graphics.DrawImage(lvl.boxes[i].picture, lvl.boxes[i].x, lvl.boxes[i].y,100,100);

            for (int i = 0; i < lvl.coins.Count; i++)
                e.Graphics.DrawImage(lvl.coins[i].picture, lvl.coins[i].x, lvl.coins[i].y, 50, 50);



            e.Graphics.DrawImage(groundImg, groundX, groundY, 5000, 318);

        }

        public Box pixelInBoxes(int X) {

            foreach (Box b in lvl.boxes) {
                if (b.pixelInBox(X)) return b;
             
            }
            return null;
        }





        public void calculateY() {

            for (int i = 0; i < 5000; i+=1) {
                if (pixelInBoxes(i) == null) yLine[i] = 460;
                else yLine[i] = pixelInBoxes(i).y;
               
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        { foreach (Enemy en in lvl.enemies)
            {
                int enemyPath = 0;


                if (en.x == en.enemyStart - 100) { goesLeft = false;  }
                else if (en.x == en.enemyStart + 100) { goesLeft = true; }

                    if (goesLeft) enemyPath = -10;
                else enemyPath = 10;
                en.x += enemyPath;
                en.coords = new Point(en.x, en.y);
            }
            sec++;
            Invalidate();
        }

        public void saveHighscore() {
            System.Runtime.Serialization.IFormatter fmt = new
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream("Highscores", FileMode.Create,
            FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, gameHighscores);
            strm.Close();
            
        }

        private void openHighscore()
        {
            
                System.Runtime.Serialization.IFormatter fmt = new
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                FileStream strm = new FileStream("Highscores", FileMode.Open,
                FileAccess.Read, FileShare.None);
                gameHighscores = (Highscores)fmt.Deserialize(strm);
                strm.Close();
            
           
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

    }
}
