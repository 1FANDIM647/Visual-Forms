using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTip_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            // location of this pictue 
            pictureBox1.Location = new Point(this.ClientRectangle.Width / 2 - pictureBox1.Width / 2, this.ClientRectangle.Height / 2 - pictureBox1.Height / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1,"This is picture");
            toolTip1.SetToolTip(button1, "Click to open picture");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // condition of opnennig of image
            OpenFileDialog opfd = new OpenFileDialog();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (opfd.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opfd.FileName);
            }
        }
    }
}
