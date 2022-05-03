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

namespace txtEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Bold);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"c:\txtEditor\" + txtFileName.Text + ".txt", rtbUpis.Text);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(ofd.FileName);
                rtbUpis.Text = text;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Underline);
        }
    }
}
