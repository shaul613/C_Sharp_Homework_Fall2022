using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addition_tutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generateNums(); // calling method
        }
        // Method for displaying random numbers
        private void generateNums()
        {
            Random rand = new Random();
            numBox1.Text = Convert.ToString(rand.Next(400) + 100);
            numBox2.Text = Convert.ToString(rand.Next(400) + 100);
            resBox.Text = ""; // Clearing input box upon submission
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int correctAnswer, input;
            // Checking if input is valid
            bool validInput = int.TryParse(resBox.Text, out input);
            if (!validInput) // If not valid
            {
                MessageBox.Show("Invalid input.");
                resBox.Text = "";
                return;
            }
            // Checking if answered correctly
            correctAnswer = int.Parse(numBox1.Text) + int.Parse(numBox2.Text);
            if(input == correctAnswer)
            {
              MessageBox.Show("Correct!!");
            }
            else
            {
              MessageBox.Show("Wrong answer.");
            }
            // Generating new numbers
            generateNums();
        }
    }
}
