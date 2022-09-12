using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace headsOrTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            heads.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void showHeads_Click(object sender, EventArgs e)
        {
            heads.Visible=true;
            tails.Visible=false;
        }

        private void showTails_Click(object sender, EventArgs e)
        {
            heads.Visible = false;
            tails.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
