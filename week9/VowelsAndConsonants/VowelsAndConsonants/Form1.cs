using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelsAndConsonants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countVowels(this.txtCharacters.Text.ToString().Trim().ToUpper());
        }

        public void count(string characters)
        {
            int numberOfVowels = 0; 
            int numberOfConsonants = 0;
            characters = characters.ToUpper().Trim();

            for (int i = 0; i < characters.Length; i++)
            {
                int characterAscciCode = (int)characters[i];
                if (characterAscciCode >= 65 && characterAscciCode <= 90)
                {
                    if((characterAscciCode==65) || (characterAscciCode == 69) || (characterAscciCode == 73) || (characterAscciCode == 79) || (characterAscciCode == 85))
                    {
                        numberOfVowels++;
                    }
                    else
                    {
                        numberOfConsonants++;
                    }
                }
            }

            txtNumAll.Text = "There are " + numberOfVowels.ToString().Trim() + " vowels and " + numberOfConsonants.ToString().Trim() + " consonants";
        }

        public void countVowels(string characters)
        {
            int numberOfVowels = 0;
            characters = characters.ToUpper().Trim();

            for (int i = 0; i < characters.Length; i++)
            {
                int characterAscciCode = (int)characters[i];
                if (characterAscciCode >= 65 && characterAscciCode <= 90)
                {
                    if ((characterAscciCode == 65) || (characterAscciCode == 69) || (characterAscciCode == 73) || (characterAscciCode == 79) || (characterAscciCode == 85))
                    {
                        numberOfVowels++;
                    }
                }
            }

            txtNumVowels.Text = "There are " + numberOfVowels.ToString().Trim() + " vowels";
        }

        public void countConsonants(string characters)
        {
            int numberOfConsonants = 0;
            characters = characters.ToUpper().Trim();

            for (int i = 0; i < characters.Length; i++)
            {
                int characterAscciCode = (int)characters[i];
                if (characterAscciCode >= 65 && characterAscciCode <= 90)
                {
                    if ((characterAscciCode != 65) && (characterAscciCode != 69) && (characterAscciCode != 73) && (characterAscciCode != 79) && (characterAscciCode != 85))
                    {
                        numberOfConsonants++;
                    }
                }
            }

            txtNumConsonants.Text = "There are " + numberOfConsonants.ToString().Trim() + " consonants";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            countConsonants(this.txtCharacters.Text.ToString().Trim().ToUpper());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count(this.txtCharacters.Text.ToString().Trim().ToUpper());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtCharacters.Text = string.Empty;
            this.txtNumAll.Text = string.Empty;
            this.txtNumConsonants.Text = string.Empty;
            this.txtNumVowels.Text = string.Empty;
            this.txtCharacters.Focus();
        }
    }
}
