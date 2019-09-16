using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenGL_helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float oLeft = float.Parse(OpenGLLeftText.Text);
            float oRight = float.Parse(OpenGLRightText.Text);
           // float oTop = float.Parse(OpenGLTopText.Text);
            //float oBottom = float.Parse(OpenGLBottomText.Text);

            float oLeftPositive = oLeft * -1;
            float offset = (oLeftPositive + oRight) / 2;
            MessageBox.Show(offset+"");

        }
    }
}
