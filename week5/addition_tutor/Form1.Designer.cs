namespace addition_tutor
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
            this.numBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.equals = new System.Windows.Forms.Label();
            this.numBox2 = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numBox1
            // 
            this.numBox1.Location = new System.Drawing.Point(144, 102);
            this.numBox1.Name = "numBox1";
            this.numBox1.ReadOnly = true;
            this.numBox1.Size = new System.Drawing.Size(100, 26);
            this.numBox1.TabIndex = 0;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(250, 105);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(18, 20);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Location = new System.Drawing.Point(380, 105);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(18, 20);
            this.equals.TabIndex = 2;
            this.equals.Text = "=";
            // 
            // numBox2
            // 
            this.numBox2.Location = new System.Drawing.Point(274, 102);
            this.numBox2.Name = "numBox2";
            this.numBox2.ReadOnly = true;
            this.numBox2.Size = new System.Drawing.Size(100, 26);
            this.numBox2.TabIndex = 3;
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(404, 105);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(100, 26);
            this.resBox.TabIndex = 4;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(274, 161);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(95, 39);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 372);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.numBox2);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.numBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numBox1;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.TextBox numBox2;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Button submitBtn;
    }
}

