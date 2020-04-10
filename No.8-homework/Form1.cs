using NO._5_homework1;
using System;
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
    public partial class Form1 : Form
    {
        public int funcnum;
        public static OrderService a = new OrderService();
        public Form1()
        {


            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            a.addorder(123, 1000000, "asdd", "sdw23e", "ssddfd", "dfwerwettg", "fwefrtt");
            a.addorder(124, 10000, "asdd", "sdw32e", "12ed", "SDFERG");
            a.addorder(125, 100000, "as346d", "sdw23e", "wrttr", "SDF");
            a.addorder(123, 1000, "as235dd", "sdw4567e", "sddd", "drgdtg");
            a.addorder(126, 1000000, "asd767d", "sdw45e", "asdsd", "SDFRG");
            a.addorder(128, 100000, "arrhd", "sd675e", "asdffggd", "S5486G");
            orderbinding.DataSource = a.orderlist;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderitembinding_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void funcnumbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (funcnumbox.Text == "订单号") funcnum = 1;
            else if (funcnumbox.Text == "客户名") funcnum = 3;
            else if (funcnumbox.Text == "商品名") funcnum = 2;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            

            if (funcnum == 1)
            {
                
                string s = searchbox.Text;
                int n = Int32.Parse(s);
                orderbinding.DataSource = a.orderlist.Where(m => m.ordernum == n);
            }
            else if (funcnum == 2)
            {
                orderbinding.DataSource = a.orderlist.Where(m => m.goodsname == searchbox.Text);
            }
            else if (funcnum == 3)
            {
                orderbinding.DataSource = a.orderlist.Where(m => m.customer== searchbox.Text);
            }

        }


        private void backbutton_Click(object sender, EventArgs e)
        {
            orderbinding.DataSource = a.orderlist;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(dr);
              
            }
            MessageBox.Show("删除成功！");
        }
    }

}

