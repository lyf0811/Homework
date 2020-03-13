using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._4_homework1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public List()
        {
            tail = head = null;
        }
        public Node<T> Head { get; set; }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)

            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void Foreach(Action<T> action)
        {
            Node<T> E = head;
            while (E != null)
            {
                action(E.Data);
                E = E.Next;
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> intlist = new List<int>();
            for(int i=0;i<10;i++)
            {
                intlist.Add(i);
            }
            Console.WriteLine("链表顺序为");
            intlist.Foreach(data => Console.WriteLine(data));
            int max = 0;int min = 0;int sum = 0;

            intlist.Foreach(data => { if (max < data) max = data; });
            Console.WriteLine("最大值="+max);
            intlist.Foreach(data => { if (min > data) min = data; });
            Console.WriteLine("最小值="+min);
            intlist.Foreach(data => { sum += data; });
            Console.WriteLine("和="+sum);
            Console.ReadKey();




        }
    }
}
