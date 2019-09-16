namespace OpenGL_helper
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenGLLeftText = new System.Windows.Forms.TextBox();
            this.OpenGLRightText = new System.Windows.Forms.TextBox();
            this.OpenGLTopText = new System.Windows.Forms.TextBox();
            this.OpenGLBottomText = new System.Windows.Forms.TextBox();
            this.MapingTopText = new System.Windows.Forms.TextBox();
            this.MapingBottomText = new System.Windows.Forms.TextBox();
            this.MapingRightText = new System.Windows.Forms.TextBox();
            this.MapingLeftText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 291);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox14);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.MapingTopText);
            this.tabPage1.Controls.Add(this.MapingBottomText);
            this.tabPage1.Controls.Add(this.MapingRightText);
            this.tabPage1.Controls.Add(this.MapingLeftText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.OpenGLTopText);
            this.tabPage1.Controls.Add(this.OpenGLBottomText);
            this.tabPage1.Controls.Add(this.OpenGLRightText);
            this.tabPage1.Controls.Add(this.OpenGLLeftText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Coordinates maping";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OpenGL Coordinates : ";
            // 
            // OpenGLLeftText
            // 
            this.OpenGLLeftText.Location = new System.Drawing.Point(180, 15);
            this.OpenGLLeftText.Name = "OpenGLLeftText";
            this.OpenGLLeftText.Size = new System.Drawing.Size(100, 22);
            this.OpenGLLeftText.TabIndex = 1;
            this.OpenGLLeftText.Text = "left";
            // 
            // OpenGLRightText
            // 
            this.OpenGLRightText.Location = new System.Drawing.Point(286, 15);
            this.OpenGLRightText.Name = "OpenGLRightText";
            this.OpenGLRightText.Size = new System.Drawing.Size(100, 22);
            this.OpenGLRightText.TabIndex = 2;
            this.OpenGLRightText.Text = "right";
            // 
            // OpenGLTopText
            // 
            this.OpenGLTopText.Location = new System.Drawing.Point(498, 15);
            this.OpenGLTopText.Name = "OpenGLTopText";
            this.OpenGLTopText.Size = new System.Drawing.Size(100, 22);
            this.OpenGLTopText.TabIndex = 4;
            this.OpenGLTopText.Text = "top";
            // 
            // OpenGLBottomText
            // 
            this.OpenGLBottomText.Location = new System.Drawing.Point(392, 15);
            this.OpenGLBottomText.Name = "OpenGLBottomText";
            this.OpenGLBottomText.Size = new System.Drawing.Size(100, 22);
            this.OpenGLBottomText.TabIndex = 3;
            this.OpenGLBottomText.Text = "bottom";
            // 
            // MapingTopText
            // 
            this.MapingTopText.Location = new System.Drawing.Point(498, 50);
            this.MapingTopText.Name = "MapingTopText";
            this.MapingTopText.Size = new System.Drawing.Size(100, 22);
            this.MapingTopText.TabIndex = 9;
            // 
            // MapingBottomText
            // 
            this.MapingBottomText.Location = new System.Drawing.Point(392, 50);
            this.MapingBottomText.Name = "MapingBottomText";
            this.MapingBottomText.Size = new System.Drawing.Size(100, 22);
            this.MapingBottomText.TabIndex = 8;
            // 
            // MapingRightText
            // 
            this.MapingRightText.Location = new System.Drawing.Point(286, 50);
            this.MapingRightText.Name = "MapingRightText";
            this.MapingRightText.Size = new System.Drawing.Size(100, 22);
            this.MapingRightText.TabIndex = 7;
            // 
            // MapingLeftText
            // 
            this.MapingLeftText.Location = new System.Drawing.Point(180, 50);
            this.MapingLeftText.Name = "MapingLeftText";
            this.MapingLeftText.Size = new System.Drawing.Size(100, 22);
            this.MapingLeftText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maping Coordinates : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input Coordinates : ";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(286, 93);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 12;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(180, 93);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(286, 128);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 15;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(180, 128);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output Coordinates : ";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(416, 93);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 16;
            this.textBox13.Text = "0,0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "or";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(416, 128);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "or";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "LRBT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 311);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "OpenGL Helper";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MapingTopText;
        private System.Windows.Forms.TextBox MapingBottomText;
        private System.Windows.Forms.TextBox MapingRightText;
        private System.Windows.Forms.TextBox MapingLeftText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OpenGLTopText;
        private System.Windows.Forms.TextBox OpenGLBottomText;
        private System.Windows.Forms.TextBox OpenGLRightText;
        private System.Windows.Forms.TextBox OpenGLLeftText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

