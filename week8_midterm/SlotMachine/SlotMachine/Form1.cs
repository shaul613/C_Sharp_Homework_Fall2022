﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        int option1, option2, option3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("C:\\Users\\USER\\source\\repos\\SlotMachine\\SlotMachine\\Images\\1.png");
            pictureBox2.Image = new Bitmap("C:\\Users\\USER\\source\\repos\\SlotMachine\\SlotMachine\\Images\\1.png");
            pictureBox3.Image = new Bitmap("C:\\Users\\USER\\source\\repos\\SlotMachine\\SlotMachine\\Images\\1.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtAmount.Text))
            {
                imagenUno();
                imagenDos();
                imagenTres();
                checkSpin();
            }
            else
            {
                MessageBox.Show("Place the amount on the field");
                txtAmount.Focus();
            }
        }

        private void imagenUno()
        {
            //RANDOM CHOOSE THE IMAGES
            string ruta1 = @"C:\\Users\\USER\\source\\repos\\SlotMachine\\SlotMachine\\Images\\filename.png";
            
            Random random1 = new Random();
            int number1 = random1.Next(1, 24);
            while(number1>12)
            {
                number1 = number1 - 12;
            }
            option1 = number1;
            ruta1 = ruta1.Replace("filename", number1.ToString().Trim());

            pictureBox1.Image = new Bitmap(ruta1);
        }

        private void imagenDos()
        {
            //RANDOM CHOOSE THE IMAGES
            string ruta2 = @"C:\\Users\\USER\\source\\repos\\SlotMachine\\SlotMachine\\Images\\filename.png";

            Random random2 = new Random();
            int number2 = random2.Next(1, 48);
            while (number2 > 12)
            {
                number2 = number2 - 12;
            }
            option2 = number2;
            ruta2 = ruta2.Replace("filename", number2.ToString().Trim());

            pictureBox2.Image = new Bitmap(ruta2);
        }

        private void imagenTres()
        {
            //RANDOM CHOOSE THE IMAGES
            string ruta3 = @"C:\\Users\\USER\\source\\repos\\SlotMachine\\SlotMachine\\Images\\filename.png";

            Random random3 = new Random();
            int number3 = random3.Next(1, 24);
            while (number3 > 12)
            {
                number3 = number3 - 12;
            }
            option3 = number3;
            ruta3 = ruta3.Replace("filename", number3.ToString().Trim());

            pictureBox3.Image = new Bitmap(ruta3);
        }

        private void checkSpin()
        {
            if((option1 == option2) && (option1 == option3))
            {
                decimal wonAmount = Convert.ToDecimal(txtAmount.Text) * 3;
                MessageBox.Show("You have won US $ " + wonAmount.ToString().Trim());
            }
            else
            {
                if (
                    ((option1 == option2) || (option1 == option3)) ||
                    ((option2 == option1) || (option2 == option3)) ||
                    ((option3 == option1) || (option3 == option2))
                    )
                {
                    decimal wonAmount = Convert.ToDecimal(txtAmount.Text) * 2;
                    MessageBox.Show("You have won US $ " + wonAmount.ToString().Trim());
                }
                else
                {
                    MessageBox.Show("You have won US $0,00");

                }

            }
        }
    }
}