using System;
using NO._5_homework1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No._8_homework
{
    public partial class Form2 : Form
    {
       // OrderService a = new OrderService();

        public Form2()
        {

            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();

        }


        private void addbutton_Click(object sender, EventArgs e)
        {
            string ordernum = ordernumbox.Text;
            int b = Convert.ToInt32(ordernumbox.Text);
            string orderamount = orderamountbox.Text;
            int c = Convert.ToInt32(orderamountbox.Text);
            string[] information = new string[orderitembox.Lines.Length];
            // List<OrderItem> orderitem = new List<OrderItem>();
            for (int i = 0; i < orderitembox.Lines.Length; i++)
            {
                information[i] = orderitembox.Lines[i];
            }
            Form1.a.addorder(b, c, goodsnamebox.Text, customerbox.Text, information);
            
            //this.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
