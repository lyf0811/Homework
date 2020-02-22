using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string s = "";
                int a = 0, b = 0;
                try
                {
                    Console.Write("请输入第一个数字：");
                    s = Console.ReadLine();
                    a = Int32.Parse(s);
                    Console.Write("请输入第二个数字：");
                    s = Console.ReadLine();
                    b = Int32.Parse(s);
                    int result = 0;
                    Console.Write("请输入运算符：");
                    s = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("请输入正确的数字");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("输入数字溢出");
                }

                if (s == "+")
                {
                    Console.WriteLine($"result:{a + b}");
                }
                else if (s == "-")
                {
                    Console.WriteLine($"result:{a - b}");
                }
                else if (s == "*")
                {
                    Console.WriteLine($"result:{a * b}");
                }
                else if (s == "/")
                {
                    if (b == 0)
                    {
                        Console.WriteLine("被除数不能是0");
                    }
                    Console.WriteLine($"result:{a / b}");
                }
                else if (s != "+" || s != "-" || s != "*" || s != "/")
                {
                    Console.WriteLine("输入正确的运算符");
                }
                Console.ReadKey();
            }
        }
    }
}
