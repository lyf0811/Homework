using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._3_homework2
{
    abstract class Shape
    {
        public abstract double area(int i);

    }
    class Quadrilateral : Shape
    {
        public override double area(int i)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            double width = rnd.Next(1, 100);
            double length = rnd.Next(1, 100);
            Console.WriteLine(width);
            Console.WriteLine(length);
            Console.WriteLine("-------------------------");
            double area = width * length;
            return area;
        }
    }
    class Triangle : Shape
    {
        public override  double area(int i)
        {
            while (true)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                double side1 = rnd.Next(1, 100);
                double side2 = rnd.Next(1, 100);
                double side3 = rnd.Next(1, 100);
               
                double p = (side1 + side2 + side3) / 2;
                if (side1 + side2 > side3 && side1 + side3 > side2 && side3 + side2 > side1&&p>0||p>side1 && p > side2 && p > side3)
                {
                    Console.WriteLine(side1);
                    Console.WriteLine(side2);
                    Console.WriteLine(side3);
                    Console.WriteLine("-------------------------");
                    double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                    return area;
                }
            }
        }
        class Circle : Shape
        {
            public override double area(int i)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                double radius= rnd.Next(1, 100);
                double area = 3.14 * radius * radius;
                Console.WriteLine(radius);
                Console.WriteLine("-------------------------");
                return area;
            }
        }
        class Factory
        {
            public static Shape CreateShape(string arg)
            {
                Shape shape = null;
                switch (arg)
                {
                    case "四边形":
                        shape = new Quadrilateral();
                        break;
                    case "三角形":
                        shape = new Triangle();
                        break;
                    case "圆形":
                        shape = new Circle();
                        break;
                }
                return shape;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("随机生成10个图形，其中以------------分界线隔开，1个参数的为圆，两个参数的为四边形，三个参数的为三角形");
                double result=0;
                double[] sumarea = new double[10];
                Shape[] shape = new Shape[10];
                for (int i=0;i<10;i++)
                {
                    
                    
                    Random rnd = new Random(i);
                    int a = rnd.Next(1, 100);
                    int b = i % 3;
                    switch(b)
                    {
                        case 0:
                            shape[i] = Factory.CreateShape("四边形");
                            sumarea[i] = shape[i].area(i);
                            break;
                        case 1:
                            shape[i] = Factory.CreateShape("三角形");
                            sumarea[i] = shape[i].area(i);
                            break;
                        case 2:
                            shape[i] = Factory.CreateShape("圆形");
                            sumarea[i] = shape[i].area(i);
                            break;
                    }

                   // result += sumarea[i];
                }
                for(int i=0;i<10;i++)
                {
                    result += sumarea[i];
                }
                Console.WriteLine("总面积为");
                Console.WriteLine(result);
                Console.ReadLine();

            }
        }
    }
}
