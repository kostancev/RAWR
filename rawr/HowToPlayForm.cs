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
    public partial class howtoplayform : Form
    {
        public howtoplayform()
        {
            InitializeComponent();
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
    }
}
