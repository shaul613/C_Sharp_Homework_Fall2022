namespace headsOrTails
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
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.showHeads = new System.Windows.Forms.Button();
            this.showTails = new System.Windows.Forms.Button();
            this.tails = new System.Windows.Forms.PictureBox();
            this.heads = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heads)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heads Or Tails";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(560, 394);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 60);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // showHeads
            // 
            this.showHeads.Location = new System.Drawing.Point(66, 394);
            this.showHeads.Name = "showHeads";
            this.showHeads.Size = new System.Drawing.Size(119, 60);
            this.showHeads.TabIndex = 2;
            this.showHeads.Text = "SHOW HEADS";
            this.showHeads.UseVisualStyleBackColor = true;
            this.showHeads.Click += new System.EventHandler(this.showHeads_Click);
            // 
            // showTails
            // 
            this.showTails.Location = new System.Drawing.Point(299, 394);
            this.showTails.Name = "showTails";
            this.showTails.Size = new System.Drawing.Size(130, 60);
            this.showTails.TabIndex = 3;
            this.showTails.Text = "SHOW TAILS";
            this.showTails.UseVisualStyleBackColor = true;
            this.showTails.Click += new System.EventHandler(this.showTails_Click);
            // 
            // tails
            // 
            this.tails.Image = global::headsOrTails.Properties.Resources.Tails1;
            this.tails.Location = new System.Drawing.Point(443, 140);
            this.tails.Name = "tails";
            this.tails.Size = new System.Drawing.Size(191, 187);
            this.tails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tails.TabIndex = 4;
            this.tails.TabStop = false;
            this.tails.Visible = false;
            this.tails.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // heads
            // 
            this.heads.Image = global::headsOrTails.Properties.Resources.Heads1;
            this.heads.Location = new System.Drawing.Point(130, 140);
            this.heads.Name = "heads";
            this.heads.Size = new System.Drawing.Size(191, 187);
            this.heads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heads.TabIndex = 5;
            this.heads.TabStop = false;
            this.heads.Visible = false;
            this.heads.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.heads);
            this.Controls.Add(this.tails);
            this.Controls.Add(this.showTails);
            this.Controls.Add(this.showHeads);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SL Heads Or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.tails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button showHeads;
        private System.Windows.Forms.Button showTails;
        private System.Windows.Forms.PictureBox tails;
        private System.Windows.Forms.PictureBox heads;
    }
}

