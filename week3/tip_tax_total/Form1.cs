using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_tax_total
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void outputBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total, tax, tip;
            total = double.Parse(inputBox.Text);
            tax = total * 0.07;
            tip = total * 0.15;
            outputBox.Text = "Sales tax: " + tax + ", tip: " + tip + ", total: " + (total+tip+tax) + ".";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
