using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No._1_homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string a = textBox1.Text;
                int a1 = Int32.Parse(a);
                string b = textBox2.Text;
                int b1 = Int32.Parse(b);
            
                switch (comboBox1.Text)
                {
                    case "+":
                        label1.Text ="结果为"+ Convert.ToString(a1 + b1) ;
                        break;
                    case "-":
                        label1.Text = "结果为" + Convert.ToString(a1 - b1);
                        break;
                    case "*":
                        label1.Text = "结果为" + Convert.ToString(a1 * b1);
                        break;
                    default:
                        if (a1 == 0)
                        {
                            label1.Text = "被除数不能为0";
                            return;
                        }
                        label1.Text = "结果为" + Convert.ToString(a1 / b1);
                        break;
                }

            }
            catch
            {
                label1.Text = "输入数字有误或超出int范围";
            }
        }
    }
}
