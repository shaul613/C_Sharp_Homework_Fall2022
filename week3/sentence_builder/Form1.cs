using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sentence_builder
{
    public partial class Form1 : Form
    {
        public String sentence;
        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Text == "(Space)")
                    output.Text += " ";
                else
                    output.Text += button.Text;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
}
