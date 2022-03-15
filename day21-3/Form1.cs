using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day21_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(toolStripComboBox1.Text);
                int b = Convert.ToInt32(toolStripComboBox2.Text);
                int x = Convert.ToInt32(toolStripTextBox1.Text);
                int y = Convert.ToInt32(toolStripTextBox2.Text);
                int z = Convert.ToInt32(toolStripTextBox3.Text);

                Text = Convert.ToString( Math.Sqrt( Math.Abs( a*x + b*y + Math.Sin(z*Math.PI/180) ) ) );
            }
            catch (Exception ex)
            {
                Text = "";
            }
        }
    }
}
