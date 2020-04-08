using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (checkBox1.Visible)
            {
                MessageBox.Show("Choose Technology");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Your Technology is C",checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("Your Technology is  C++", checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                MessageBox.Show("Your Technology is Python", checkBox3.Text);
            }
            if(checkBox4.Checked)
            {
                MessageBox.Show("Your Technology is Java", checkBox4.Text);
            }
        }
    }
}
