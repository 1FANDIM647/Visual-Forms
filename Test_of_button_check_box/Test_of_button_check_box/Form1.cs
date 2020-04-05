using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_of_button_check_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String misha = "";

            if (checkBox1.CheckState == CheckState.Checked)
            {
                misha += "M";
            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                misha += "i";
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                misha += "s";
            }
            if (checkBox4.CheckState == CheckState.Checked)
            {
                misha += "h";
            }
            if (checkBox5.CheckState == CheckState.Checked)
            {
                misha += "a";
            }
            // output of the variable
            MessageBox.Show(misha);
        } 
    }
}
