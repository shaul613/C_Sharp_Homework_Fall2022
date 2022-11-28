using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driving_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(text);
        }

        public String[] answers = "b d a a c a b a c d b c d a d c c b d a".Split();
        string text = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "..\\..\\answers.txt"));
        
        
        
    }
}
