using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Brendmauer
{
    public partial class Form2 : Form
    {
        Thread th;
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (opfd.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opfd.FileName);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textBox1 = "version 1.0";
            MessageBox.Show(textBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open(object obj)
        {
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opens);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opens(object obj)
        {
            Application.Run(new Form3());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(opena);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opena(object obj)
        {
            Application.Run(new Form3());
        }
    }
}
