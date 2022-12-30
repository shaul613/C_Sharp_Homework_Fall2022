namespace VowelsAndConsonants
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCharacters = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumVowels = new System.Windows.Forms.TextBox();
            this.txtNumConsonants = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNumAll = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter initial string";
            // 
            // txtCharacters
            // 
            this.txtCharacters.Location = new System.Drawing.Point(50, 45);
            this.txtCharacters.Name = "txtCharacters";
            this.txtCharacters.Size = new System.Drawing.Size(454, 20);
            this.txtCharacters.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "# of Vowels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumVowels
            // 
            this.txtNumVowels.Location = new System.Drawing.Point(188, 94);
            this.txtNumVowels.Name = "txtNumVowels";
            this.txtNumVowels.Size = new System.Drawing.Size(316, 20);
            this.txtNumVowels.TabIndex = 3;
            // 
            // txtNumConsonants
            // 
            this.txtNumConsonants.Location = new System.Drawing.Point(188, 146);
            this.txtNumConsonants.Name = "txtNumConsonants";
            this.txtNumConsonants.Size = new System.Drawing.Size(316, 20);
            this.txtNumConsonants.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "# of Consonants";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNumAll
            // 
            this.txtNumAll.Location = new System.Drawing.Point(188, 204);
            this.txtNumAll.Name = "txtNumAll";
            this.txtNumAll.Size = new System.Drawing.Size(316, 20);
            this.txtNumAll.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "# of Consonants and Vowels";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 325);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtNumAll);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNumConsonants);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNumVowels);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCharacters);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Count Vowels and/or Consonants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCharacters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumVowels;
        private System.Windows.Forms.TextBox txtNumConsonants;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNumAll;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

