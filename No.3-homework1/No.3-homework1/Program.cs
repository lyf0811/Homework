using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._3_homework1
{
    public interface Shape
    {
        void judge();
        void area();
    }
    class Rectangle:Shape
    {
        public int length { get; set; }
        public int width  { get; set; }
         public void judge()
        {
            if(width<=0||length<=0)
            {
                Console.WriteLine("该图形不是长方形");
            }
            else
            {
                Console.WriteLine("该图形是长方形");
            }
        }
        public void area()
        {
            int area = width * length;
            Console.WriteLine("面积为" + area);
        }

    }
    class Square:Rectangle,Shape
    {
        new public void judge()
        {
            if (width <= 0 || length <= 0||width!=length)
            {
                Console.WriteLine("该图形不是正方形");
                return;
            }
            else
            {
                Console.WriteLine("该图形是正方形");
            }
        }
    }
    class Triangle:Shape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public void judge()
        {
            if(side1+side2<=side3|| side1 + side3 <= side2 || side2 + side3 <= side1 )
            {
                Console.WriteLine("该图形不是三角形");
            }
            else
            {
                Console.WriteLine("该图形是三角形");
            }
        }
        public void area()
        {
            double p = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            Console.WriteLine("面积为"+area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入想要构造的图形:1.长方形，2.正方形，3.三角形。");
            string s = Console.ReadLine();
            int num = Int32.Parse(s);
            switch(num)
            {
                case 1:
                    {
                        Console.WriteLine("请输入长方形的长和宽");
                        string leng = Console.ReadLine();
                        string wide = Console.ReadLine();
                        int a = Int32.Parse(leng);
                        int b = Int32.Parse(wide);
                        Rectangle rectangle = new Rectangle();
                        rectangle.length = a;
                        rectangle.width = b;
                        rectangle.judge();
                        rectangle.area();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("请输入正方形的长和宽");
                        string leng = Console.ReadLine();
                        string wide = Console.ReadLine();
                        int a = Int32.Parse(leng);
                        int b = Int32.Parse(wide);
                        Square square = new Square();
                        square.length = a;
                        square.width = b;
                        square.judge();
                        square.area();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("请输入三角形的三边");
                        string sid1 = Console.ReadLine();
                        string sid2 = Console.ReadLine();
                        string sid3 = Console.ReadLine();
                        double a = Double.Parse(sid1);
                        double b = Double.Parse(sid2);
                        double c = Double.Parse(sid3);
                       Triangle triangle = new Triangle();
                        triangle.side1 = a;
                        triangle.side2 = b;
                        triangle.side3 = c;
                        triangle.judge();
                        triangle.area();
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
