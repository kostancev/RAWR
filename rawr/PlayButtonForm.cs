using System;
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
    public partial class PlayButtonForm : Form
    {
        public PlayButtonForm()
        {
            InitializeComponent();
        }

        //selectlevel1
        private void picturebox1_MouseHover(object sender, EventArgs e)
        {
            picturebox1.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\11.png");
        }

        private void picturebox1_MouseLeave(object sender, EventArgs e)
        {
            picturebox1.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\1.png");
        }

        //selectlevel2
        private void picturebox2_MouseHover(object sender, EventArgs e)
        {
            picturebox2.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\22.png");
        }

        private void picturebox2_MouseLeave(object sender, EventArgs e)
        {
            picturebox2.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\2.png");
        }

        //selectlevel3
        private void picturebox3_MouseHover(object sender, EventArgs e)
        {
            picturebox3.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\33.png");
        }

        private void picturebox3_MouseLeave(object sender, EventArgs e)
        {
            picturebox3.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\3.png");
        }

        //selectlevel4
        private void picturebox4_MouseHover(object sender, EventArgs e)
        {
            picturebox4.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\44.png");
        }

        private void picturebox4_MouseLeave(object sender, EventArgs e)
        {
            picturebox4.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\4.png");
        }

        //leftarrow1
        private void leftarrow1_MouseHover(object sender, EventArgs e)
        {
            leftarrow1.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\leftarrow1.png");
        }

        private void leftarrow1_MouseLeave(object sender, EventArgs e)
        {
            leftarrow1.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\leftarrow.png");
        }


        private void leftarrow1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm f = new MainMenuForm();
            f.Show();
        }

        private void picturebox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Level1 lvl1 = new Level1();
            Level lvl = new Level(lvl1.enemies, lvl1.boxes, lvl1.coins);
            Game g = new Game(lvl,1,0);
            g.Show();
        }

        private void picturebox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Level2 lvl2 = new Level2();
            Level lvl = new Level(lvl2.enemies, lvl2.boxes, lvl2.coins);
            Game g = new Game(lvl, 2,0);
            g.Show();
        }

        private void picturebox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Level3 lvl3 = new Level3();
            Level lvl = new Level(lvl3.enemies, lvl3.boxes, lvl3.coins);
            Game g = new Game(lvl, 3,0);
            g.Show();

        }

        private void picturebox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Level4 lvl4 = new Level4();
            Level lvl = new Level(lvl4.enemies, lvl4.boxes, lvl4.coins);
            Game g = new Game(lvl, 4,0);
            g.Show();
        }
    }
}
