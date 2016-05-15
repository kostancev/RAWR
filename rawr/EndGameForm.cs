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
    public partial class EndGameForm : Form
    {
        
        public Highscore newHighscore { get; set; }
        public EndGameForm(String score)
        {
            InitializeComponent();
            label3.Text = score.ToString();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Retry;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            newHighscore = new Highscore(textBox1.Text+" ", label3.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
           
        }
    }
}
