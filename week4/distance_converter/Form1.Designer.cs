namespace distance_converter
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
            this.fromList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromList
            // 
            this.fromList.FormattingEnabled = true;
            this.fromList.ItemHeight = 20;
            this.fromList.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromList.Location = new System.Drawing.Point(91, 135);
            this.fromList.Name = "fromList";
            this.fromList.Size = new System.Drawing.Size(87, 104);
            this.fromList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // toList
            // 
            this.toList.FormattingEnabled = true;
            this.toList.ItemHeight = 20;
            this.toList.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toList.Location = new System.Drawing.Point(315, 135);
            this.toList.Name = "toList";
            this.toList.Size = new System.Drawing.Size(87, 104);
            this.toList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(302, 69);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 26);
            this.input.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter a distance to convert";
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(91, 341);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(106, 33);
            this.convertBtn.TabIndex = 6;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Converted distance:";
            // 
            // outputBox
            // 
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Location = new System.Drawing.Point(273, 286);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(200, 30);
            this.outputBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fromList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox toList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputBox;
    }
}

