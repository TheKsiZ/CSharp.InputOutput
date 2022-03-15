using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day21_10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string surname, string name, string otchestvo, string zp)
        {
            InitializeComponent();
            label5.Text = surname;
            label6.Text = name;
            label7.Text = otchestvo;
            label8.Text = Convert.ToString(Convert.ToInt32(zp)*24) + "$";
        }
    }
}
