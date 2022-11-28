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
            // Getting data
            Dictionary<string, string> data = getResults(correctAnswers, submittedAnswers);
            // Applying data from dictionary to the form
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
            int correct = 0; // Total correct
            int incorrect = 0; // Total incorrect
            string incorrectList = ""; // List of incorrect
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
            // Adding data to dictionary
            string passFail = correct >= 15 ? "Pass" : "Fail";
            result.Add("result", passFail);
            result.Add("correct", correct.ToString());
            result.Add("incorrect", incorrect.ToString());
            result.Add("incorrectList", incorrectList);

            return result;
        }
        
    }
}
