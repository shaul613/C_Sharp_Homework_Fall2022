namespace prime_numbers
{
    partial class form_1
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
            this.primeNumberBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // primeNumberBox
            // 
            this.primeNumberBox.FormattingEnabled = true;
            this.primeNumberBox.ItemHeight = 20;
            this.primeNumberBox.Location = new System.Drawing.Point(117, 55);
            this.primeNumberBox.Name = "primeNumberBox";
            this.primeNumberBox.Size = new System.Drawing.Size(533, 364);
            this.primeNumberBox.TabIndex = 0;
            // 
            // form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.primeNumberBox);
            this.Name = "form_1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox primeNumberBox;
    }
}

