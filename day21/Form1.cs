using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            textBox1.Text = (e.X + e.Y).ToString();
            */
            textBox1.Text = (e.X).ToString();
            textBox2.Text = (e.Y).ToString();
            try
            {
                int x = e.X;
                int y = e.Y;
                double q = Convert.ToDouble(textBox3.Text) * Math.PI / 180;
                double s = Convert.ToDouble(textBox4.Text) * Math.PI / 180;
                double g = Convert.ToDouble(textBox5.Text) * Math.PI / 180;

                Text = "R = " + Convert.ToString(q + Math.Abs( Math.Pow(Math.Sin(x),2) + Math.Cos(y)) * Math.Cos(s + g));
            }catch (Exception ex)
            {
                Text = "ERROR";
            }
        }
    }
}
