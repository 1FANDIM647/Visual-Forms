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

/*Button Migrations*/

namespace WindowsFormsApptest
{
    public partial class Form1 : Form
    {
        Thread th; 
        public Form1()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openform2()
        {
            Application.Run(new Form3());
        }
    }
}
