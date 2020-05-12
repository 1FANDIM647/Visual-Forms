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

namespace Notepad
{
    public partial class Form1 : Form
    {
        private string FilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {  // OPEN file wit openFileDialog
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    FilePath = dialog.FileName;
                    textBox1.Text = File.ReadAllText(FilePath);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               
        }

       

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Gold;
        }
        // function ,to save file  
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(FilePath))
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    if (dialog.ShowDialog()== DialogResult.OK)
                    {
                        FilePath = dialog.FileName;
                        File.WriteAllText(FilePath, textBox1.Text);
                    }
                }
            }

        }
        // move to words
        private void moveWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveWordsToolStripMenuItem = moveWordsToolStripMenuItem;
            textBox1.WordWrap = moveWordsToolStripMenuItem.Checked;
        }
        // function  , to  save as
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog dialog = new SaveFileDialog())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = dialog.FileName;
                    File.WriteAllText(FilePath, textBox1.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
    }
}
