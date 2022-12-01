using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TextBox txt = new TextBox();
            //txt.Text = "hello";
            //Form1.Controls.Add(txt);

            Random rand = new Random();
            int[,] box = new int[3,3];
            for(int r = 0; r < 3; r++)
            {
                for(int c = 0; c < 3; c++)
                {
                    box[r, c] = rand.Next(0, 2);
                    winner_box.Text += box[r, c];
                }
            }
            
        }
    }
}
