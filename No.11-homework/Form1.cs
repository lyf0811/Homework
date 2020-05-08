using source;

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
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

            a.addorder("123", "1000000", "asdd", "sdw23e", "ssddfd", "dfwerwettg", "fwefrtt");
            a.addorder("124", "10000", "asdd", "sdw32e", "12ed", "SDFERG");
            a.addorder("125", "100000", "as346d", "sdw23e", "wrttr", "SDF");
            a.addorder("127", "1000", "as235dd", "sdw4567e", "sddd", "drgdtg");
            a.addorder("126", "1000000", "asd767d", "sdw45e", "asdsd", "SDFRG");
            a.addorder("128", "100000", "arrhd", "sd675e", "asdffggd", "S5486G");
            orderbinding.DataSource = a.orderlist;
            MessageBox.Show("欢迎使用该订单管理系统。                                                                                                     " +
                "注1：我将不为订单详细信息(orderitem)分配各种详细的意义与值，而是直接插入一条条注释，使用字符串将属性与值直接连接，方便各个订单插入不同的属性。                           " +
                "注2：删除订单功能为选中所要删除的条目，点击一下删除订单即可,导入导出功能待完善");

     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
               
                List<OrderItem> orderitem = new List<OrderItem>();
              
                orderbinding.Add(f2.order);
                Console.WriteLine(f2.ordernum);
                a.addorder(f2.ordernum, f2.orderamount, f2.goodsname, f2.customer, f2.information);
                a.addorder("129", "100000", "arrhd", "sd75e", "asdd", "S56G");

            }
            MessageBox.Show("添加成功");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                a.deleteorder(a.orderlist[dr.Index].ordernum);
                dataGridView1.Rows.Remove(dr);

            }
            Form3 f2 = new Form3();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                List<OrderItem> orderitem = new List<OrderItem>();
                orderbinding.Add(f2.order);

            }
            MessageBox.Show("修改成功");

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
                
                orderbinding.DataSource = a.orderlist.Where(m => m.ordernum == s);
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
                string s=a.orderlist[dr.Index].ordernum;
                Console.WriteLine(s);
                a.deleteorder(s);
                dataGridView1.Rows.Remove(dr);
                //orderbinding.Remove(dr);

                MessageBox.Show("删除成功！");

            }
            
        }

        private void textbutton_Click(object sender, EventArgs e)
        {

        }

        private void savefiletbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                a.Export(fileName);
            }

        }







        public static DataTable TxtToDataTable(string strFileName, char strSplit, ref string strErrorMessage)
        {
            DataTable dtReturn = new DataTable();

            try
            {
                string[] strFileTexts = File.ReadAllLines(strFileName, System.Text.Encoding.UTF8);

                if (strFileTexts.Length == 0) // 如果没有数据
                {
                    strErrorMessage = "文件中没有数据！";
                    return null;
                }

                string[] strLineTexts = strFileTexts[0].Split(strSplit);
                if (strLineTexts.Length == 0)
                {
                    strErrorMessage = "文件中数据格式不正确！";
                    return null;
                }


                for (int i = 0; i < strLineTexts.Length; i++)
                {
                    dtReturn.Columns.Add("Columns" + i.ToString());
                }



                for (int i = 0; i < strFileTexts.Length; i++)
                {
                    strLineTexts = strFileTexts[i].Split(strSplit);
                    DataRow dr = dtReturn.NewRow();
                    for (int j = 0; j < strLineTexts.Length; j++)
                    {
                        dr[j] = strLineTexts[j].ToString();
                    }
                    dtReturn.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                strErrorMessage = "读入数据出错！" + ex.Message;

                return null;
            }

            return dtReturn;
        }











        public static bool DataTableToTxt(DataGridView gridview, string strFileName, char strSplit)
        {
            if (gridview == null || gridview.Rows.Count == 0)
                return false;

            FileStream fileStream = new FileStream(strFileName, FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fileStream, System.Text.Encoding.UTF8);

            StringBuilder strBuilder = new StringBuilder();

            try
            {
                for (int i = 0; i < gridview.Rows.Count; i++)
                {
                    strBuilder = new StringBuilder();
                    for (int j = 0; j < gridview.Columns.Count; j++)
                    {
                        strBuilder.Append(gridview.Rows[i].Cells[j].Value.ToString() + strSplit);
                    }
                    strBuilder.Remove(strBuilder.Length - 1, 1); // 将最后添加的一个strSplit删除掉
                    streamWriter.WriteLine(strBuilder.ToString());
                }
            }
            catch (Exception ex)
            {
                string strErrorMessage = ex.Message;
                return false;
            }
            finally
            {
                streamWriter.Close();
                fileStream.Close();
            }

            return true;
        }

        private void loadinbutton_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                a.Import(fileName);
               
            }
        }
    }

}

