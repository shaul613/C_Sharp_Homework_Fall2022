using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distance_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //When the exit button is clicked
            this.Close();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            //distance == user's input, convertedDistance == output
            double distance, convertedDistance;
            //Checking for valid input
            if(double.TryParse(input.Text, out distance))
            {
                //Validating selection from listbox
                if(fromList.SelectedIndex != -1 && toList.SelectedIndex != -1)
                {
                    //Assigning initial value to output
                    switch (fromList.SelectedIndex)
                    {
                        case 1: //Feet
                            convertedDistance = distance * 12;
                            break;
                        case 2: //Yards
                            convertedDistance = distance * 36;
                            break;
                        default: //Inches
                            convertedDistance = distance;
                            break;
                    }
                    //Calculating final result
                    switch (toList.SelectedIndex)
                    {
                        case 1: //Feet
                            convertedDistance = convertedDistance / 12;
                            break;
                        case 2: //Yards
                            convertedDistance = convertedDistance / 36;
                            break;
                        default: //Inches
                            break;
                    }
                    //Showing results in output box
                    outputBox.Text = convertedDistance.ToString();

                }
                else //Invalid selection
                {
                    MessageBox.Show("Please select measurements");
                }
            }
            else //Invalid user input (empty, non-numeric, etc.)
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
