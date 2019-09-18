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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outXY = new System.Windows.Forms.TextBox();
            this.outYText = new System.Windows.Forms.TextBox();
            this.outXText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inY = new System.Windows.Forms.TextBox();
            this.inX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MapingTopText = new System.Windows.Forms.TextBox();
            this.MapingBottomText = new System.Windows.Forms.TextBox();
            this.MapingRightText = new System.Windows.Forms.TextBox();
            this.MapingLeftText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenGLTopText = new System.Windows.Forms.TextBox();
            this.OpenGLBottomText = new System.Windows.Forms.TextBox();
            this.OpenGLRightText = new System.Windows.Forms.TextBox();
            this.OpenGLLeftText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.copyCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 236);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.copyCheckBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.outXY);
            this.tabPage1.Controls.Add(this.outYText);
            this.tabPage1.Controls.Add(this.outXText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.inY);
            this.tabPage1.Controls.Add(this.inX);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(490, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Coordinates maping";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "LRBT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "or";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // outXY
            // 
            this.outXY.Location = new System.Drawing.Point(312, 104);
            this.outXY.Margin = new System.Windows.Forms.Padding(2);
            this.outXY.Name = "outXY";
            this.outXY.Size = new System.Drawing.Size(76, 20);
            this.outXY.TabIndex = 18;
            // 
            // outYText
            // 
            this.outYText.Location = new System.Drawing.Point(214, 104);
            this.outYText.Margin = new System.Windows.Forms.Padding(2);
            this.outYText.Name = "outYText";
            this.outYText.Size = new System.Drawing.Size(76, 20);
            this.outYText.TabIndex = 15;
            // 
            // outXText
            // 
            this.outXText.Location = new System.Drawing.Point(135, 104);
            this.outXText.Margin = new System.Windows.Forms.Padding(2);
            this.outXText.Name = "outXText";
            this.outXText.Size = new System.Drawing.Size(76, 20);
            this.outXText.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output Coordinates : ";
            // 
            // inY
            // 
            this.inY.Location = new System.Drawing.Point(214, 76);
            this.inY.Margin = new System.Windows.Forms.Padding(2);
            this.inY.Name = "inY";
            this.inY.Size = new System.Drawing.Size(76, 20);
            this.inY.TabIndex = 12;
            this.inY.Text = "50";
            this.inY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InY_KeyDown);
            // 
            // inX
            // 
            this.inX.Location = new System.Drawing.Point(135, 76);
            this.inX.Margin = new System.Windows.Forms.Padding(2);
            this.inX.Name = "inX";
            this.inX.Size = new System.Drawing.Size(76, 20);
            this.inX.TabIndex = 11;
            this.inX.Text = "50";
            this.inX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InX_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input Coordinates : ";
            // 
            // MapingTopText
            // 
            this.MapingTopText.Location = new System.Drawing.Point(374, 41);
            this.MapingTopText.Margin = new System.Windows.Forms.Padding(2);
            this.MapingTopText.Name = "MapingTopText";
            this.MapingTopText.Size = new System.Drawing.Size(76, 20);
            this.MapingTopText.TabIndex = 9;
            this.MapingTopText.Text = "0";
            // 
            // MapingBottomText
            // 
            this.MapingBottomText.Location = new System.Drawing.Point(294, 41);
            this.MapingBottomText.Margin = new System.Windows.Forms.Padding(2);
            this.MapingBottomText.Name = "MapingBottomText";
            this.MapingBottomText.Size = new System.Drawing.Size(76, 20);
            this.MapingBottomText.TabIndex = 8;
            this.MapingBottomText.Text = "100";
            // 
            // MapingRightText
            // 
            this.MapingRightText.Location = new System.Drawing.Point(214, 41);
            this.MapingRightText.Margin = new System.Windows.Forms.Padding(2);
            this.MapingRightText.Name = "MapingRightText";
            this.MapingRightText.Size = new System.Drawing.Size(76, 20);
            this.MapingRightText.TabIndex = 7;
            this.MapingRightText.Text = "100";
            // 
            // MapingLeftText
            // 
            this.MapingLeftText.Location = new System.Drawing.Point(135, 41);
            this.MapingLeftText.Margin = new System.Windows.Forms.Padding(2);
            this.MapingLeftText.Name = "MapingLeftText";
            this.MapingLeftText.Size = new System.Drawing.Size(76, 20);
            this.MapingLeftText.TabIndex = 6;
            this.MapingLeftText.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maping Coordinates : ";
            // 
            // OpenGLTopText
            // 
            this.OpenGLTopText.Location = new System.Drawing.Point(374, 12);
            this.OpenGLTopText.Margin = new System.Windows.Forms.Padding(2);
            this.OpenGLTopText.Name = "OpenGLTopText";
            this.OpenGLTopText.Size = new System.Drawing.Size(76, 20);
            this.OpenGLTopText.TabIndex = 4;
            this.OpenGLTopText.Text = "1";
            // 
            // OpenGLBottomText
            // 
            this.OpenGLBottomText.Location = new System.Drawing.Point(294, 12);
            this.OpenGLBottomText.Margin = new System.Windows.Forms.Padding(2);
            this.OpenGLBottomText.Name = "OpenGLBottomText";
            this.OpenGLBottomText.Size = new System.Drawing.Size(76, 20);
            this.OpenGLBottomText.TabIndex = 3;
            this.OpenGLBottomText.Text = "-1";
            // 
            // OpenGLRightText
            // 
            this.OpenGLRightText.Location = new System.Drawing.Point(214, 12);
            this.OpenGLRightText.Margin = new System.Windows.Forms.Padding(2);
            this.OpenGLRightText.Name = "OpenGLRightText";
            this.OpenGLRightText.Size = new System.Drawing.Size(76, 20);
            this.OpenGLRightText.TabIndex = 2;
            this.OpenGLRightText.Text = "1";
            // 
            // OpenGLLeftText
            // 
            this.OpenGLLeftText.Location = new System.Drawing.Point(135, 12);
            this.OpenGLLeftText.Margin = new System.Windows.Forms.Padding(2);
            this.OpenGLLeftText.Name = "OpenGLLeftText";
            this.OpenGLLeftText.Size = new System.Drawing.Size(76, 20);
            this.OpenGLLeftText.TabIndex = 1;
            this.OpenGLLeftText.Text = "-1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OpenGL Coordinates : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.browseButton);
            this.tabPage2.Controls.Add(this.filePathText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(490, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image to coordinates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(410, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(410, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // filePathText
            // 
            this.filePathText.Enabled = false;
            this.filePathText.Location = new System.Drawing.Point(5, 5);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(399, 20);
            this.filePathText.TabIndex = 0;
            // 
            // copyCheckBox
            // 
            this.copyCheckBox.AutoSize = true;
            this.copyCheckBox.Location = new System.Drawing.Point(18, 164);
            this.copyCheckBox.Name = "copyCheckBox";
            this.copyCheckBox.Size = new System.Drawing.Size(189, 17);
            this.copyCheckBox.TabIndex = 22;
            this.copyCheckBox.Text = "Copy calculated value to clipboard";
            this.copyCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 253);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "OpenGL Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outXY;
        private System.Windows.Forms.TextBox outYText;
        private System.Windows.Forms.TextBox outXText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inY;
        private System.Windows.Forms.TextBox inX;
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
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox copyCheckBox;
    }
}

