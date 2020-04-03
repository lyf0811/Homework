using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No._7_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(n, 200, 310, length, -Math.PI / 2);
        }
        private Graphics graphics;
        double th1;
        double th2;
        //double tm1 = th1 * Math.PI / 180;
        //double tm2 = th2 * Math.PI / 180;
        double per1;// = 0.6;
        double per2;// = 0.7;
        int n;
        string colour;
        double length;
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1 * Math.PI / 180);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th1 * Math.PI / 180);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            switch (colour) {
                case "蓝色" : 
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "红色":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "黑色":
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "紫色":
                    graphics.DrawLine(Pens.Purple, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string s = depth.Text;
            try
            {
                n = Int32.Parse(s);
            }
            catch
            {
                Console.WriteLine("wrong number");
                   
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = leng.Text;
                    try
            {
                length = Double.Parse(s);
            }
            catch
            {
                Console.WriteLine("wrong number");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            string s = per1box.Text;
            try
            {
                per1 = Double.Parse(s);
            }
            catch
            {
                Console.WriteLine("wrong number");

            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string s = per2box.Text;
            try
            {
                per2 = Double.Parse(s);
            }
            catch
            {
                Console.WriteLine("wrong number");

            }
        }

        private void th1box_TextChanged(object sender, EventArgs e)
        {
            string s = th1box.Text;
            try
            {
               th1 = Double.Parse(s);
            }
            catch
            {
                Console.WriteLine("wrong number");

            }
        }

        private void th2box_TextChanged(object sender, EventArgs e)
        {
            string s = th2box.Text;
            try
            {
               th2 = Double.Parse(s);
            }
            catch
            {
                Console.WriteLine("wrong number");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //penbox.Items.Add("蓝色");
            //penbox.Items.Add("红色");
            //penbox.Items.Add("黑色");
           // penbox.Items.Add("紫色");
            
            colour = penbox.Text;
           
        }
    }
}
