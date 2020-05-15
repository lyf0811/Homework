using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Dynamic;
using System.Configuration.Assemblies;

namespace source
{
    public class Order
    {
        [Key]
        public string ordernum { get; set; }
        public string orderamount { get; set; }
        public string goodsname { get; set; }
        public string customer { get; set; }
        public List<OrderItem> orderitem { get; set; }
      
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.ordernum == ordernum && order.goodsname == goodsname && order.customer == customer && order.orderamount == orderamount;
        }
       /* public override int GetHashCode()
        {
            //int a = Int32.Parse(goodsname);
            //int b = Int32.Parse(customer);
            // return ordernum * 1000 + orderamount * 100;//+ a * 10 + b;
            return GetHashCode();
        }*/
        public Order() { }
        public Order(string ordernum, string orderamount, string goodsname, string customer, List<OrderItem> orderitem)
        {
            this.orderamount = orderamount;
            this.ordernum = ordernum;
            this.goodsname = goodsname;
            this.customer = customer;
            this.orderitem = orderitem;
        }

        public override string ToString()
        {
            string s = ordernum.ToString();
            string a = orderamount.ToString();

            return "订单号：" + ordernum + " 货物名：" + goodsname + " 客户名：" + customer + " 订单总金额：" + a;
        }
    }
    public class OrderItem
    {
        [Key]
        public string item { get; set; }
        public OrderItem() { }
        public OrderItem(string item)
        {
            this.item = item;
        }

        public override bool Equals(object obj)
        {
            OrderItem orderitem = obj as OrderItem;
            return orderitem != null && orderitem.item == item;
        }
        /*public override int GetHashCode()
        {
            int a = Int32.Parse(item);

            return a * 1324;
        }*/
        public override string ToString()
        {
            return "订单明细" + item;
        }
    }

    public class OrderService
    {
        public List<Order> orderlist = new List<Order>();


        public void addorder(string ordernum, string orderamount, string goodsname, string customer, params string[] information)
        {
            bool ifhasorder = false;
            bool ifhasorderitem = false;
            List<OrderItem> orderitem = new List<OrderItem>();
            for (int i = 0; i < information.Length; i++)
            {
                OrderItem item = new OrderItem(information[i]);
                for (int m = 0; m < i; m++)
                {
                    if (item == null)
                    {
                        orderitem.Add(item);
                    }
                    if (item.Equals(orderitem[m]))
                    {
                        Console.WriteLine("订单明细已存在");
                        ifhasorderitem = true;
                    }

                }
                if (ifhasorderitem == false)
                {
                    orderitem.Add(item);//orderitem[i] = item;
                }
            }
            Order order = new Order(ordernum, orderamount, goodsname, customer, orderitem);
            for (int i = 0; i < orderlist.Count; i++)
            {
                if (order.Equals(orderlist[i]))
                {
                    Console.WriteLine("订单已存在");
                    ifhasorder = true;
                }
            }
             if (ifhasorder == false)
             {
                 orderlist.Add(order);
                // orderlist.Sort((p1, p2) => p1.ordernum - p2.ordernum);
             }
        }
        public void deleteorder(string ordernum)
         {
             for (int i = 0; i < orderlist.Count; i++)
             {
                 if (orderlist[i].ordernum == ordernum)
                 {
                     orderlist.Remove(orderlist[i]);
                 }
             }
         }
         public void modifyorder(int num, string ordernum, string orderamount, string goodsname, string customer)
         {
             orderlist[num].ordernum = ordernum;
             orderlist[num].goodsname = goodsname;
             orderlist[num].customer = customer;
             orderlist[num].orderamount = orderamount;
         }
        /*
         public void searchorder(int funcnum)
         {
             if (funcnum == 0)
             {
                 string a = Console.ReadLine();
                 int ordernum = Int32.Parse(a);
                 var order = from s in orderlist
                             where s.ordernum == ordernum
                             orderby s.orderamount
                             select s;
                 foreach (var s in order)
                 {
                     Console.WriteLine(s);
                 }

             }
             else if (funcnum == 1)
             {
                 string a = Console.ReadLine();
                 var order = from s in orderlist
                             where s.goodsname == a
                             orderby s.orderamount
                             select s;
                 foreach (var s in order)
                 {
                     Console.WriteLine(s);
                 }
             }
             else if (funcnum == 2)
             {
                 string a = Console.ReadLine();
                 var order = from s in orderlist
                             where s.customer == a
                             orderby s.orderamount
                             select s;
                 foreach (var s in order)
                 {
                     Console.WriteLine(s);
                 }
             }
         }
         public void Export()
         {
             XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
             using (FileStream fs = new FileStream("orderlist.xml", FileMode.Create))
             {
                 xmlSerializer.Serialize(fs, orderlist);
             }
             Console.WriteLine("\nSerialized as xml:");
             Console.WriteLine(File.ReadAllText("orderlist.xml"));

         }
         public void Import()
         {
             XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
             using (FileStream fs = new FileStream("orderlist.xml", FileMode.Open))
             {
                 List<Order> orderlist1 = (List<Order>)xmlSerializer.Deserialize(fs);
                 Console.WriteLine("\nDeserialized from orderlist.xml");
                 for (int i = 0; i < orderlist1.Count; i++)
                 {
                     Console.WriteLine(orderlist1[i]);
                     for (int m = 0; m < orderlist1[i].orderitem.Count; m++)
                     {
                         Console.WriteLine(orderlist1[i].orderitem[m]);
                     }
                 }
             }
         }
     }*/

        class Program
        {
            static void Main(string[] args)
            {
                 start: Console.WriteLine("现存订单为");
                     OrderService a = new OrderService();
                     a.addorder("123", "1000000", "asdd", "sdw23e", "ssddfd", "dfwerwettg", "fwefrtt");
                     a.addorder("124", "10000", "asdd", "sdw32e", "12ed", "SDFERG");
                     a.addorder("125", "100000", "as346d", "sdw23e", "wrttr", "SDF");
                     a.addorder("123", "1000", "as235dd", "sdw4567e", "sddd", "drgdtg");
                     a.addorder("126", "1000000", "asd767d", "sdw45e", "asdsd", "SDFRG");
                
                     for (int i = 0; i < a.orderlist.Count; i++)
                     {
                         Console.WriteLine(a.orderlist[i]);
                         for (int m = 0; m < a.orderlist[i].orderitem.Count; m++)
                         {
                             Console.WriteLine(a.orderlist[i].orderitem[m]);
                         }
                     }
                    
            }
        }
    }
}
        
