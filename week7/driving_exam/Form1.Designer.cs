namespace driving_exam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.TextBox();
            this.ans_pass = new System.Windows.Forms.TextBox();
            this.ans_fail = new System.Windows.Forms.TextBox();
            this.all_fail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(44, 41);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(195, 26);
            this.result.TabIndex = 0;
            this.result.Text = "Result: ";
            // 
            // ans_pass
            // 
            this.ans_pass.Location = new System.Drawing.Point(256, 41);
            this.ans_pass.Name = "ans_pass";
            this.ans_pass.ReadOnly = true;
            this.ans_pass.Size = new System.Drawing.Size(195, 26);
            this.ans_pass.TabIndex = 1;
            this.ans_pass.Text = "Total Correct: ";
            // 
            // ans_fail
            // 
            this.ans_fail.Location = new System.Drawing.Point(469, 41);
            this.ans_fail.Name = "ans_fail";
            this.ans_fail.ReadOnly = true;
            this.ans_fail.Size = new System.Drawing.Size(195, 26);
            this.ans_fail.TabIndex = 2;
            this.ans_fail.Text = "Total Incorrect: ";
            // 
            // all_fail
            // 
            this.all_fail.Location = new System.Drawing.Point(44, 83);
            this.all_fail.Multiline = true;
            this.all_fail.Name = "all_fail";
            this.all_fail.ReadOnly = true;
            this.all_fail.Size = new System.Drawing.Size(620, 29);
            this.all_fail.TabIndex = 3;
            this.all_fail.Text = "List of wrong answers: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.all_fail);
            this.Controls.Add(this.ans_fail);
            this.Controls.Add(this.ans_pass);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox ans_pass;
        private System.Windows.Forms.TextBox ans_fail;
        private System.Windows.Forms.TextBox all_fail;
    }
}

