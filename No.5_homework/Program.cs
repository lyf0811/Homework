using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NO._5_homework1
{
    public class Order
    {
        public int ordernum;
        public int orderamount;
        public string goodsname;
        public string customer;
        public OrderItem[] orderitem = new OrderItem[10];
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.ordernum == ordernum && order.goodsname == goodsname && order.customer == customer && order.orderamount == orderamount;
        }
        public override int GetHashCode()
        {
            int a = Int32.Parse(goodsname);
            int b = Int32.Parse(customer);
            return ordernum * 1000 + orderamount * 100 + a * 10 + b;
        }
        public Order(int ordernum, int orderamount, string goodsname, string customer, OrderItem[] orderitem)
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
        public string item;
        public OrderItem(string item)
        {
            this.item = item;
        }
        public override bool Equals(object obj)
        {
            OrderItem orderitem = obj as OrderItem;
            return orderitem != null && orderitem.item == item;
        }
        public override int GetHashCode()
        {
            int a = Int32.Parse(item);

            return a * 1324;
        }
        public override string ToString()
        {
            return "订单明细" + item;
        }
    }
    public class OrderService
    {
        public List<Order> orderlist = new List<Order>();
        public void addorder(int ordernum, int orderamount, string goodsname, string customer, params string[] information)
        {
            bool ifhasorder = false;
            bool ifhasorderitem = false;
            OrderItem[] orderitem = new OrderItem[10];

            for (int i = 0; i < information.Length; i++)
            {
                OrderItem item = new OrderItem(information[i]);
                for (int m = 0; m < i + 1; m++)
                {
                    if (item == null)
                    {
                        orderitem[m] = item;
                    }
                    if (item.Equals(orderitem[m]))
                    {
                        Console.WriteLine("订单明细已存在");
                        ifhasorderitem = true;
                    }

                }
                if (ifhasorderitem == false)
                {
                    orderitem[i] = item;
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
                orderlist.Sort((p1, p2) => p1.ordernum - p2.ordernum);
            }
        }
        public void deleteorder(int ordernum)
        {
            for (int i = 0; i < orderlist.Count; i++)
            {
                if (orderlist[i].ordernum == ordernum)
                {
                    orderlist.Remove(orderlist[i]);
                }
            }
        }
        public void modifyorder(int num, int ordernum, int orderamount, string goodsname, string customer)
        {
            orderlist[num].ordernum = ordernum;
            orderlist[num].goodsname = goodsname;
            orderlist[num].customer = customer;
            orderlist[num].orderamount = orderamount;
        }
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
    }
    public class UI
    {
        OrderService a = new OrderService();

        int n = 0, m = 0;
        string s = Console.ReadLine();
        string x = Console.ReadLine();
        a.addorder(n, m, s, x);

    }
    class Program
    {
        static void Main(string[] args)
        {
            OrderService a = new OrderService();
            a.addorder(123, 1000000, "asdd", "sdw23e", "ssddfd", "dfwerwettg", "fwefrtt");
            a.addorder(124, 10000, "asdd", "sdw32e", "12ed");
            a.addorder(125, 100000, "as346d", "sdw23e", "wrttr");
            a.addorder(123, 1000, "as235dd", "sdw4567e", "sddd", "drgdtg");
            a.addorder(126, 1000000, "asd767d", "sdw45e", "asdsd");



            a.orderlist.ForEach(p => Console.WriteLine(p));
            ; Console.WriteLine(a.orderlist[1].orderitem[0]);
            Console.WriteLine(a.orderlist[1].orderitem[1]);
            Console.WriteLine(a.orderlist[1].orderitem[2]);
            a.searchorder(1);
            Console.ReadKey();

        }
    }
}
