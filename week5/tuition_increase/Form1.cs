using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuition_increase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double tuition = 2000; // Tuition amount for year 1
            for(int i = 0; i < 6; i++) // Current year and next 5 years
            {
                // Displaying tuition amount in listbox
                tuitionList.Items.Add("Tuition for  year " + (i+1) + " - " + tuition);
                // Increasing tuition variable by 1.02 (2%)
                tuition *= 1.02;
            }
            
        }
    }
}
