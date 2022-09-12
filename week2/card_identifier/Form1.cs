using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card_identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void twoOfSpades_Click(object sender, EventArgs e)
        {
            imageName.Text = "Two Of Spades";
        }

        private void tenOfDimonds_Click(object sender, EventArgs e)
        {
            imageName.Text = "Ten Of Dimonds";
        }

        private void eightOfHearts_Click(object sender, EventArgs e)
        {
            imageName.Text = "Eight Of Hearts";
        }

        private void nineOfClubs_Click(object sender, EventArgs e)
        {
            imageName.Text = "Nine Of Clubs";
        }

        private void aceOfDimonds_Click(object sender, EventArgs e)
        {
            imageName.Text = "Ace Of Dimonds";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
