using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dunix_OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void hideSubMenu()
        {
            panel3.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3 );
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
