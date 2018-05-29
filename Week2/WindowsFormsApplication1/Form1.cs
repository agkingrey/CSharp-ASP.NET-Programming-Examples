using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class formHeadsTails : Form
    {
        public formHeadsTails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            picHeads.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            picTails.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void picTails_Click(object sender, EventArgs e)
        {

        }
    }
}
