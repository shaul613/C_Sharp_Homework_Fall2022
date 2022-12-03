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

        public static bool checkForWinner(int[,] arr, int xo)
        {
            bool result = false;
            for(int i = 0; i < 3; i++)
            {
                if (arr[0,i] == xo && arr[1,i] == xo && arr[2,i] == xo)
                {
                    result = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (arr[i,0] == xo && arr[i,1] == xo && arr[i,2] == xo)
                {
                    result = true;
                }
            }
            if (arr[0,0] == xo && arr[1,1] == xo && arr[2,2] == xo) result = true;
            if (arr[2,0] == xo && arr[1,1] == xo && arr[0,2] == xo) result = true;
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[,] box = new int[3,3];
            for(int r = 0; r < 3; r++)
            {
                for(int c = 0; c < 3; c++)
                {
                    box[r, c] = rand.Next(0, 2);
                }
            }
            bool xWins = checkForWinner(box, 1);
            bool oWins = checkForWinner(box, 0);
            string winnerText;
            if(xWins && oWins)
            {
                winnerText = "Tie - both are winners!";
            }
            else if (xWins)
            {
                winnerText = "X wins!";
            }
            else if (oWins)
            {
                winnerText = "O wins!";
            }
            else
            {
                winnerText = "Tie - nobody wins.";
            }
            winner_box.Text = winnerText;
        }

        private void new_game_btn_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
