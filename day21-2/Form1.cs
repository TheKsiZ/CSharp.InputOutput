using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day21_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    int p = Convert.ToInt32(textBox4.Text);
                    int n = Convert.ToInt32(textBox2.Text);
                    double answer = 0;
                    double drob = 1;

                    if(n == 1)
                    {
                        textBox1.Text = Convert.ToString(p);
                        return;
                    }

                    if(n <= 0)
                    {
                        throw new Exception("Введите положительное число");
                    }

                    for(int i = 2; i <= n; i++)
                    {
                        drob *= i;
                        if (i % 2 == 0)
                        {
                            answer += -1 * ( Math.Pow(p,i) / drob );
                        }
                        else
                        {
                            answer += Math.Pow(p,i) / drob;
                        }
                    }
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (radioButton2.Checked)
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    int r = Convert.ToInt32(textBox3.Text);
                    double b = Convert.ToDouble(comboBox1.Text);
                    double c = Convert.ToDouble(listBox1.Text);
                    
                    if((n <= 0) || (r <= 0))
                    {
                        throw new Exception("Введите положительное число");
                    }

                    double answer = 0;
                    for(int i = 1; i <= n; i++)
                    {
                        for(int j = 1; j <= r; j++)
                        {
                            answer += (Math.Pow(i, 2) + Math.Pow(j, 2)) / (Math.Pow(i,3) + Math.Pow(j,3));
                        }
                    }
                    textBox1.Text = Convert.ToString(answer);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
