using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motion
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y <= 10) return;
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            pictureBox1.Image = Properties.Resources.Up;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y >= 480) return;
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            pictureBox1.Image = Properties.Resources.Down;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X >= 530) return;
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            pictureBox1.Image = Properties.Resources.Right;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X <= 10) return;
            pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            pictureBox1.Image = Properties.Resources.Left;
        }
    }
}
