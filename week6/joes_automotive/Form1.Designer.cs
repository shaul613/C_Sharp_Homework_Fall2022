namespace joes_automotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lubeBox = new System.Windows.Forms.CheckBox();
            this.oilBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transmissionBox = new System.Windows.Forms.CheckBox();
            this.radiatorBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tireBox = new System.Windows.Forms.CheckBox();
            this.mufflerBox = new System.Windows.Forms.CheckBox();
            this.inspectionBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.laborBox = new System.Windows.Forms.TextBox();
            this.partsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lubeBox);
            this.groupBox1.Controls.Add(this.oilBox);
            this.groupBox1.Location = new System.Drawing.Point(57, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil And Lube";
            // 
            // lubeBox
            // 
            this.lubeBox.AutoSize = true;
            this.lubeBox.Location = new System.Drawing.Point(18, 62);
            this.lubeBox.Name = "lubeBox";
            this.lubeBox.Size = new System.Drawing.Size(134, 24);
            this.lubeBox.TabIndex = 1;
            this.lubeBox.Text = "Lube ($18.00)";
            this.lubeBox.UseVisualStyleBackColor = true;
            // 
            // oilBox
            // 
            this.oilBox.AutoSize = true;
            this.oilBox.Location = new System.Drawing.Point(18, 32);
            this.oilBox.Name = "oilBox";
            this.oilBox.Size = new System.Drawing.Size(116, 24);
            this.oilBox.TabIndex = 0;
            this.oilBox.Text = "Oil ($26.00)";
            this.oilBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transmissionBox);
            this.groupBox2.Controls.Add(this.radiatorBox);
            this.groupBox2.Location = new System.Drawing.Point(281, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // transmissionBox
            // 
            this.transmissionBox.AutoSize = true;
            this.transmissionBox.Location = new System.Drawing.Point(23, 62);
            this.transmissionBox.Name = "transmissionBox";
            this.transmissionBox.Size = new System.Drawing.Size(191, 24);
            this.transmissionBox.TabIndex = 5;
            this.transmissionBox.Text = "Transmission ($80.00)";
            this.transmissionBox.UseVisualStyleBackColor = true;
            // 
            // radiatorBox
            // 
            this.radiatorBox.AutoSize = true;
            this.radiatorBox.Location = new System.Drawing.Point(23, 26);
            this.radiatorBox.Name = "radiatorBox";
            this.radiatorBox.Size = new System.Drawing.Size(159, 24);
            this.radiatorBox.TabIndex = 6;
            this.radiatorBox.Text = "Radiator ($30.00)";
            this.radiatorBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tireBox);
            this.groupBox3.Controls.Add(this.mufflerBox);
            this.groupBox3.Controls.Add(this.inspectionBox);
            this.groupBox3.Location = new System.Drawing.Point(530, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // tireBox
            // 
            this.tireBox.AutoSize = true;
            this.tireBox.Location = new System.Drawing.Point(20, 102);
            this.tireBox.Name = "tireBox";
            this.tireBox.Size = new System.Drawing.Size(189, 24);
            this.tireBox.TabIndex = 2;
            this.tireBox.Text = "Tire Rotation ($20.00)";
            this.tireBox.UseVisualStyleBackColor = true;
            // 
            // mufflerBox
            // 
            this.mufflerBox.AutoSize = true;
            this.mufflerBox.Location = new System.Drawing.Point(20, 62);
            this.mufflerBox.Name = "mufflerBox";
            this.mufflerBox.Size = new System.Drawing.Size(219, 24);
            this.mufflerBox.TabIndex = 3;
            this.mufflerBox.Text = "Replace Muffler ($100.00)";
            this.mufflerBox.UseVisualStyleBackColor = true;
            // 
            // inspectionBox
            // 
            this.inspectionBox.AutoSize = true;
            this.inspectionBox.Location = new System.Drawing.Point(20, 26);
            this.inspectionBox.Name = "inspectionBox";
            this.inspectionBox.Size = new System.Drawing.Size(172, 24);
            this.inspectionBox.TabIndex = 4;
            this.inspectionBox.Text = "Inspection ($15.00)";
            this.inspectionBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.laborBox);
            this.groupBox4.Controls.Add(this.partsBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(530, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts And Labor";
            // 
            // laborBox
            // 
            this.laborBox.Location = new System.Drawing.Point(123, 99);
            this.laborBox.Name = "laborBox";
            this.laborBox.Size = new System.Drawing.Size(100, 26);
            this.laborBox.TabIndex = 3;
            // 
            // partsBox
            // 
            this.partsBox.Location = new System.Drawing.Point(95, 51);
            this.partsBox.Name = "partsBox";
            this.partsBox.Size = new System.Drawing.Size(114, 26);
            this.partsBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor (Hours):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts ($):";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(57, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(449, 242);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(174, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(241, 26);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(174, 190);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(241, 26);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(241, 26);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(174, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(241, 26);
            this.textBox3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Parts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tax (on parts):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service And Labor:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox lubeBox;
        private System.Windows.Forms.CheckBox oilBox;
        private System.Windows.Forms.CheckBox transmissionBox;
        private System.Windows.Forms.CheckBox radiatorBox;
        private System.Windows.Forms.CheckBox tireBox;
        private System.Windows.Forms.CheckBox mufflerBox;
        private System.Windows.Forms.CheckBox inspectionBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox laborBox;
        private System.Windows.Forms.TextBox partsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
