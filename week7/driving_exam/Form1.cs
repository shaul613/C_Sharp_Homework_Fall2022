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
            Dictionary<string, string> data = getResults(correctAnswers, submittedAnswers);
            result.Text += data["result"];
            ans_pass.Text += data["correct"];
            ans_fail.Text += data["incorrect"];
            all_fail.Text += data["incorrectList"];

        }

        public string[] correctAnswers = "b d a a c a b a c d b c d a d c c b d a".Split();
        public string[] submittedAnswers = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "..\\..\\answers.txt")).Split(',');
        
        public static Dictionary<string, string> getResults(string[] answers, string[] submission)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            int correct = 0;
            int incorrect = 0;
            string incorrectList = "";
            for(int i = 0; i < 20; i++)
            {
                if (answers[i] == submission[i])
                {
                    correct++;
                }
                else
                {
                    incorrect++;
                    incorrectList += i.ToString() + " ";
                }
            }
            string passFail = correct >= 15 ? "Pass" : "Fail";
            result.Add("result", passFail);
            result.Add("correct", correct.ToString());
            result.Add("incorrect", incorrect.ToString());
            result.Add("incorrectList", incorrectList);

            return result;
        }
        
    }
}
