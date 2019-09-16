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
            float oTop = float.Parse(OpenGLTopText.Text);
            float oBottom = float.Parse(OpenGLBottomText.Text);

            float oLeftPositive = oLeft * -1;
            float oBottomPositive = oBottom * -1;
            float leftRightOffset = (oLeftPositive + oRight) / 2;
            float bottomTopOffset = (oBottomPositive + oTop) / 2;
            float oLeftRightTotal = oLeftPositive + oRight;
            float oBottomTopTotal = oBottomPositive + oTop;

            float mLeft = float.Parse(MapingLeftText.Text);
            float mRight = float.Parse(MapingRightText.Text);
            float mTop = float.Parse(MapingTopText.Text);
            float mBottom = float.Parse(MapingBottomText.Text);

            float mLeftRightMax = mRight - mLeft;
            float mBottomTopMax = mBottom - mTop;


            float iX = float.Parse(inX.Text);
            float iY = float.Parse(inY.Text);

            //getting %
            float oXPercentage = (iX / mLeftRightMax);
            float oYPercentage = (iY / mBottomTopMax);

            float outX1 = oXPercentage * oLeftRightTotal;
            float outX = outX1 - leftRightOffset;


            float outY1 = oYPercentage * oBottomTopTotal;
            float outY = outY1 - bottomTopOffset;
            outY = outY * -1;
            outXText.Text = outX + "";
            outYText.Text = outY + "";
            outXY.Text = outX + "," + outY;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InX_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                Button1_Click(null, null);
            }
        }

        private void InY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Button1_Click(null, null);
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            if(o.FileName != "")
            {
                filePathText.Text = o.FileName;
            }
        }
    }
}
