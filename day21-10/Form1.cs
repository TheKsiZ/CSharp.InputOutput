using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace day21_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string surname = textBox5.Text; 
                string name = textBox6.Text;
                string otchestvo = textBox7.Text;

                if(surname == "" || name == "" || otchestvo == "")
                {
                    throw new Exception("Введите данные");
                }

                //List<string> sotrudniki = new List<string>();
                using (StreamReader sr = new StreamReader("sotrudniki.txt", System.Text.Encoding.Default))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] lines;
                        lines = line.Split(' ');
                        if(lines[0] == surname)
                        {
                            if(lines[1] == name)
                            {
                                if(lines[2] == otchestvo)
                                {
                                    Form2 form2 = new Form2(surname, name, otchestvo, lines[3]);
                                    form2.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }
                    throw new Exception("Сотрудник не найден");
                }

                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
