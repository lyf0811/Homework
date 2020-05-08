using System;
using source;
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
    public partial class Form3 : Form
    {

        public string ordernum{ get; set;}
        public string orderamount { get; set; }
        public string goodsname { get; set; }
        public string customer { get; set; }
        public Order order { get; set; }
        public string[] information { get; set; }
        // public List<OrderItem> orderitem1{ get; set; }
        //public string[] information { get; set; }



        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordernum = ordernumbox.Text;
            orderamount = orderamountbox.Text;
            goodsname = goodsnamebox.Text;
            customer = customerbox.Text;
            information = new string[orderitembox.Lines.Length];
            List<OrderItem> orderitem1 = new List<OrderItem>();
            for (int i = 0; i <orderitembox.Lines.Length; i++)
            {
                information[i] = orderitembox.Lines[i];
                OrderItem item = new OrderItem(orderitembox.Lines[i]);
                orderitem1.Add(item);
            }


            order = new Order(ordernum, orderamount, goodsnamebox.Text, customerbox.Text, orderitem1);
            Order order1 = new Order();
            order1 = order;
            //Form1.a.orderlist.Add(order);
            this.DialogResult = DialogResult.OK;
        
          
            //this.Close();
        }
    }
}
