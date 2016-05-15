using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAWR
{
    public partial class HighScoreForm : Form
    {
        Highscores gameHighscores;
        public HighScoreForm()
        {
            InitializeComponent();
            
          
            openHighscore();
            int size = gameHighscores.highscores.Count;
            if (size >= 1) {
                label1.Text = gameHighscores.highscores.ElementAt(0).name;
                label5.Text = gameHighscores.highscores.ElementAt(0).score.ToString();
            }
            if (size >= 2)
            {
                label2.Text = gameHighscores.highscores.ElementAt(1).name;
                label6.Text = gameHighscores.highscores.ElementAt(1).score.ToString();
            }
            if (size >= 3)
            {
                label3.Text = gameHighscores.highscores.ElementAt(2).name;
                label7.Text = gameHighscores.highscores.ElementAt(2).score.ToString();
            }
            if (size >= 4)
            {
                label4.Text = gameHighscores.highscores.ElementAt(3).name;
                label8.Text = gameHighscores.highscores.ElementAt(3).score.ToString();
            }

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
            
            this.Close();
            MainMenuForm f = new MainMenuForm();
            f.Show();
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

       
    }
}
