namespace tic_tac_toe
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
            this.new_game_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.winner_box = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.TextBox();
            this.b8 = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.TextBox();
            this.b6 = new System.Windows.Forms.TextBox();
            this.b5 = new System.Windows.Forms.TextBox();
            this.b4 = new System.Windows.Forms.TextBox();
            this.b3 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // new_game_btn
            // 
            this.new_game_btn.Location = new System.Drawing.Point(118, 551);
            this.new_game_btn.Name = "new_game_btn";
            this.new_game_btn.Size = new System.Drawing.Size(153, 45);
            this.new_game_btn.TabIndex = 0;
            this.new_game_btn.Text = "New Game";
            this.new_game_btn.UseVisualStyleBackColor = true;
            this.new_game_btn.Click += new System.EventHandler(this.new_game_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(342, 551);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(153, 45);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // winner_box
            // 
            this.winner_box.Location = new System.Drawing.Point(199, 494);
            this.winner_box.Name = "winner_box";
            this.winner_box.Size = new System.Drawing.Size(220, 26);
            this.winner_box.TabIndex = 2;
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(104, 47);
            this.b0.Multiline = true;
            this.b0.Name = "b0";
            this.b0.ReadOnly = true;
            this.b0.Size = new System.Drawing.Size(115, 115);
            this.b0.TabIndex = 3;
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(422, 345);
            this.b8.Multiline = true;
            this.b8.Name = "b8";
            this.b8.ReadOnly = true;
            this.b8.Size = new System.Drawing.Size(115, 115);
            this.b8.TabIndex = 4;
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(265, 345);
            this.b7.Multiline = true;
            this.b7.Name = "b7";
            this.b7.ReadOnly = true;
            this.b7.Size = new System.Drawing.Size(115, 115);
            this.b7.TabIndex = 5;
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(104, 345);
            this.b6.Multiline = true;
            this.b6.Name = "b6";
            this.b6.ReadOnly = true;
            this.b6.Size = new System.Drawing.Size(115, 115);
            this.b6.TabIndex = 6;
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(422, 197);
            this.b5.Multiline = true;
            this.b5.Name = "b5";
            this.b5.ReadOnly = true;
            this.b5.Size = new System.Drawing.Size(115, 115);
            this.b5.TabIndex = 7;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(265, 197);
            this.b4.Multiline = true;
            this.b4.Name = "b4";
            this.b4.ReadOnly = true;
            this.b4.Size = new System.Drawing.Size(115, 115);
            this.b4.TabIndex = 8;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(104, 197);
            this.b3.Multiline = true;
            this.b3.Name = "b3";
            this.b3.ReadOnly = true;
            this.b3.Size = new System.Drawing.Size(115, 115);
            this.b3.TabIndex = 9;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(422, 47);
            this.b2.Multiline = true;
            this.b2.Name = "b2";
            this.b2.ReadOnly = true;
            this.b2.Size = new System.Drawing.Size(115, 115);
            this.b2.TabIndex = 10;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(265, 47);
            this.b1.Multiline = true;
            this.b1.Name = "b1";
            this.b1.ReadOnly = true;
            this.b1.Size = new System.Drawing.Size(115, 115);
            this.b1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 675);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.winner_box);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.new_game_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_game_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TextBox winner_box;
        private System.Windows.Forms.TextBox b0;
        private System.Windows.Forms.TextBox b8;
        private System.Windows.Forms.TextBox b7;
        private System.Windows.Forms.TextBox b6;
        private System.Windows.Forms.TextBox b5;
        private System.Windows.Forms.TextBox b4;
        private System.Windows.Forms.TextBox b3;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox b1;
    }
}

