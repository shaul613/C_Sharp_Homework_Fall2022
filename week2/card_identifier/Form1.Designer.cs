namespace card_identifier
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
            this.title = new System.Windows.Forms.Label();
            this.twoOfSpades = new System.Windows.Forms.PictureBox();
            this.aceOfDimonds = new System.Windows.Forms.PictureBox();
            this.nineOfClubs = new System.Windows.Forms.PictureBox();
            this.eightOfHearts = new System.Windows.Forms.PictureBox();
            this.tenOfDimonds = new System.Windows.Forms.PictureBox();
            this.imageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.twoOfSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfDimonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineOfClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightOfHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenOfDimonds)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(270, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(206, 20);
            this.title.TabIndex = 0;
            this.title.Text = "Click a card to see its name!";
            // 
            // twoOfSpades
            // 
            this.twoOfSpades.Image = global::card_identifier.Properties.Resources._2_Spades;
            this.twoOfSpades.Location = new System.Drawing.Point(82, 214);
            this.twoOfSpades.Name = "twoOfSpades";
            this.twoOfSpades.Size = new System.Drawing.Size(50, 70);
            this.twoOfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twoOfSpades.TabIndex = 5;
            this.twoOfSpades.TabStop = false;
            this.twoOfSpades.Click += new System.EventHandler(this.twoOfSpades_Click);
            // 
            // aceOfDimonds
            // 
            this.aceOfDimonds.Image = global::card_identifier.Properties.Resources.Ace_Diamonds;
            this.aceOfDimonds.Location = new System.Drawing.Point(581, 214);
            this.aceOfDimonds.Name = "aceOfDimonds";
            this.aceOfDimonds.Size = new System.Drawing.Size(50, 70);
            this.aceOfDimonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aceOfDimonds.TabIndex = 4;
            this.aceOfDimonds.TabStop = false;
            this.aceOfDimonds.Click += new System.EventHandler(this.aceOfDimonds_Click);
            // 
            // nineOfClubs
            // 
            this.nineOfClubs.Image = global::card_identifier.Properties.Resources._9_Clubs;
            this.nineOfClubs.Location = new System.Drawing.Point(462, 214);
            this.nineOfClubs.Name = "nineOfClubs";
            this.nineOfClubs.Size = new System.Drawing.Size(50, 70);
            this.nineOfClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nineOfClubs.TabIndex = 3;
            this.nineOfClubs.TabStop = false;
            this.nineOfClubs.Click += new System.EventHandler(this.nineOfClubs_Click);
            // 
            // eightOfHearts
            // 
            this.eightOfHearts.Image = global::card_identifier.Properties.Resources._8_Hearts;
            this.eightOfHearts.Location = new System.Drawing.Point(331, 214);
            this.eightOfHearts.Name = "eightOfHearts";
            this.eightOfHearts.Size = new System.Drawing.Size(50, 70);
            this.eightOfHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.eightOfHearts.TabIndex = 2;
            this.eightOfHearts.TabStop = false;
            this.eightOfHearts.Click += new System.EventHandler(this.eightOfHearts_Click);
            // 
            // tenOfDimonds
            // 
            this.tenOfDimonds.Image = global::card_identifier.Properties.Resources._10_Diamonds;
            this.tenOfDimonds.Location = new System.Drawing.Point(190, 214);
            this.tenOfDimonds.Name = "tenOfDimonds";
            this.tenOfDimonds.Size = new System.Drawing.Size(50, 70);
            this.tenOfDimonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tenOfDimonds.TabIndex = 1;
            this.tenOfDimonds.TabStop = false;
            this.tenOfDimonds.Click += new System.EventHandler(this.tenOfDimonds_Click);
            // 
            // imageName
            // 
            this.imageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageName.Location = new System.Drawing.Point(151, 327);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(451, 52);
            this.imageName.TabIndex = 6;
            this.imageName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.twoOfSpades);
            this.Controls.Add(this.aceOfDimonds);
            this.Controls.Add(this.nineOfClubs);
            this.Controls.Add(this.eightOfHearts);
            this.Controls.Add(this.tenOfDimonds);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.twoOfSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfDimonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineOfClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightOfHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenOfDimonds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox tenOfDimonds;
        private System.Windows.Forms.PictureBox eightOfHearts;
        private System.Windows.Forms.PictureBox nineOfClubs;
        private System.Windows.Forms.PictureBox aceOfDimonds;
        private System.Windows.Forms.PictureBox twoOfSpades;
        private System.Windows.Forms.Label imageName;
    }
}

