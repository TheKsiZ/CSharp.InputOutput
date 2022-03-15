using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day21_32
{
    public partial class Form1 : Form
    {
        int choice = 1;
        public double function(int choice, int x, int y)
        {
            double answer = 0;
            switch (choice)
            {
                case 1:
                    answer = Math.Sqrt(x) + Math.Pow(y, 2);
                    break;
                case 2:
                    answer = Math.Sqrt(y);
                    break;
                case 3:
                    answer = Math.Pow(x,3);
                    break;
                default:
                    break;
            }
            return answer;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripLabel1.Text = "X: " + e.X;
            toolStripLabel2.Text = "Y: " + e.Y;
            toolStripLabel3.Text = Convert.ToString(function(choice, e.X, e.Y));
        }


        private void zxY2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void fyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = 2;
        }

        private void zX3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = 3;
        }
    }
}
