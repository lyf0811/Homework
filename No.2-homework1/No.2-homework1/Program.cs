using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._2_homework1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int i = 2;
            string input;
            
            start: try
            {
                Console.WriteLine("请输入一个整数数字");
                input = Console.ReadLine();
                num = Int32.Parse(input);
                if (num == 1)
                {
                    Console.WriteLine("1没有素数因子");
                    goto start;
                }
                Console.WriteLine("这个数字的所有素数因子为：");
            }
            catch
            {
                Console.WriteLine("请输入正确的数字");
                goto start;
            }
            while (num>= i)
            {
              
                if (num % i == 0)
                {
                    //Console.WriteLine(i);
                    while (num % i == 0)
                    {
                        num /= i;
                        Console.WriteLine(i);
                    }
                }
                i++;
            }
            Console.ReadKey();
        }
    }
    }

