using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._2_homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            int length = 0;
            int max = 0, min = 0;
            int sum = 0, average = 0;

            Console.WriteLine("请输入该数组的长度");
            string s = Console.ReadLine();
            length = Int32.Parse(s);
            array = new int[length];
            Console.WriteLine("请输入该数组每个数字");
            for (int i = 0; i < length; i++)
            {
                string a;
                a = Console.ReadLine();
                array[i] = Int32.Parse(a);  
            }
            function(array, length, out  max,out  min, out  average, out sum);
        }
        public static void function(int [] array,int length,out int max,out int min,out int average,out int sum)
        {
            max = 0;
            min = 0;
            sum = 0;
            average = 0;
            Console.WriteLine("该数组最大值为：");
            foreach (int number in array)
            {
                if (number >= max)
                {
                    max = number;

                }
            }
            Console.WriteLine(max);
            min = max;
            Console.WriteLine("该数组最小值为：");
            foreach (int number in array)
            {
                if (number <= min)
                {
                    min = number;

                }
            }
            Console.WriteLine(min);
            Console.WriteLine("该数组的平均值为：");
            foreach (int number in array)
            {
                sum += number;

            }
            average = sum / length;
            Console.WriteLine(average);
            Console.WriteLine("该数组的所有元素和为：");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
