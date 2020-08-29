using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newFile();
        }
        private void newFile()
        {
            richTextBox1.Text = null;//Remove any text box when strating a new file
            toolStripStatusLabel1.Text = "Ready";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
        {
            openFileDialog1.Filter = "Text Files | *.txt";//Filters text files with .txt extension from file system
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//Display the file system so a file can be selected
            {
                //Open a plain text file in the text box
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            saveFileDialog1.Filter = "Text | *.txt";//Filters files with .txt extension from file system
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)// Display the file system so a file can be selected
            {
                //Save the currently entered text in the text box in a file
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
