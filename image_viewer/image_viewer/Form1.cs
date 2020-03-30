using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_viewer
{
    public partial class image_viewer : Form
    {   
        // run all elements
        public image_viewer()
        {
            InitializeComponent();
        }
        // our  button for opening of picture 
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(this.ClientRectangle.Width / 2 - pictureBox1.Width / 2, this.ClientRectangle.Height / 2 - pictureBox1.Height / 2); 
        }
        // output of picture 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (opfd.ShowDialog (this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opfd.FileName);
            }
            
        }
    }
}
