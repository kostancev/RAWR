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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?",
                  "Leaving? :(",
                   MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);
              if (result == DialogResult.Yes)
              {
                  Application.Exit();

              }

        }


        //quitbutton
        private void quitbutton_MouseHover (object sender, System.EventArgs e)
        {
          quitbutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\quit1.png");
            }

        private void quitbutton_MouseLeave(object sender, System.EventArgs e)
        {
            quitbutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\quit.png");
        }



        //playbutton
        private void playbutton_MouseHover(object sender, EventArgs e)
        {
            playbutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\play1.png");
        }

        private void playbutton_MouseLeave(object sender, EventArgs e)
        {
            playbutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\play.png");
        }


        //createlevel
        private void createlevelbutton_MouseHover(object sender, EventArgs e)
        {
            createlevelbutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\createlevel1.png");
        }

        private void createlevelbutton_MouseLeave(object sender, EventArgs e)
        {
            createlevelbutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\createlevel.png");
        }


        //highscorebutton
        private void highscorebutton_MouseHover(object sender, EventArgs e)
        {
            highscorebutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\highscore1.png");
        }

        private void highscorebutton_MouseLeave(object sender, EventArgs e)
        {
            highscorebutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\highscore.png");
        }


        //howtoplaybutton
        private void howtoplaybutton_MouseHover(object sender, EventArgs e)
        {
            howtoplaybutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\howtoplay1.png");
        }

        private void howtoplaybutton_MouseLeave(object sender, EventArgs e)
        {
            howtoplaybutton.BackgroundImage = (Bitmap)Bitmap.FromFile("Images\\howtoplay.png");
        }



        private void playbutton_Click(object sender, EventArgs e)
        { 
            this.Hide();
           PlayButtonForm pf = new PlayButtonForm();
            pf.ShowDialog();
            
        }

        private void howtoplaybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            howtoplayform ht = new howtoplayform();
            ht.Show();
        }

        private void highscorebutton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            HighScoreForm hsc = new HighScoreForm();
            hsc.Show();
        }

        private void createlevelbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form clf = new CreateLevelForm();
            clf.Show();
            
        }
    }
}
