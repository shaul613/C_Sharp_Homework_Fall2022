using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabeticPhoneTranslator
{
    public partial class Form1 : Form
    {
        Helper helper = new Helper();

        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(!helper.TextBoxLimit(e))
            {
                MessageBox.Show("Please enter only numbers or letters");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newNumber = string.Empty;
            for(int i = 0; i<maskedTextBox1.TextLength; i++)
            {
                newNumber = newNumber + helper.translatePhoneNumber(maskedTextBox1.Text.ToString().Trim().Substring(i, 1).ToUpper());
            }

            this.maskedTextBox2.Text = newNumber.ToString().Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.maskedTextBox1.Text = String.Empty;
            this.maskedTextBox2.Text = String.Empty;

            this.maskedTextBox1.Focus();
        }
    }
}
