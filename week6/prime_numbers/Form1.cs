using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime_numbers
{
    public partial class form_1 : Form
    {
        // Creating method for checking for prime
        public static Boolean IsPrime(int num)
        {
            bool res = true; // Default is prime
            //For 0, 1, and 2, defult will be returned
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    // If devisible by a number other than 1 and num, return fasle
                    return false;
                }
                else
                {
                    res = true;
                }
            }
            return res;
        }
        public form_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 101; i++)
            {
                // Getting results using method
                String prime = IsPrime(i) ? "prime" : "not prime";
                primeNumberBox.Items.Add(i + " is " + prime);
            }
        }
    }
}
