using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Devide(double a, double b)
        {
            return a / b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Calculate(double a, double b)
        {
            return a - b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Multiply(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Devide(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Calculate(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
    }
}
