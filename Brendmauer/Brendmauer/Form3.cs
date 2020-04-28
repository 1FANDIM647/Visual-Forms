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
using System.Threading;


namespace Brendmauer
{
    public partial class Form3 : Form
    {
        Thread th;
        public Form3()
        {
            InitializeComponent();
        }

      


        private void button3_Click(object sender, EventArgs e)
        {
            string textBox1 = "version 1.0";
            MessageBox.Show(textBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Openfile 
            openFileDialog1.ShowDialog();
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // pause
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //play
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //stop
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open(object obj)
        {
            Application.Run(new Form2());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opena);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opena(object obj)
        {
            Application.Run(new Form1());
        }
    }
     
}
