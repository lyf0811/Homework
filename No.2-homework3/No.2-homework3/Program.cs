using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._2_homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("根据埃氏筛法求2-100以内的素数，用根号100，即去除10以内的素数的倍数，即2，3，5，7的倍数");
            int []array = new int[100];
            array[2] = 0;
            int k = 2;
            while (true)
            {
                for (int i = 2; i < 100; i++) //将不是素数的数筛出
                    if (i % k == 0 && i != k) array[i] = 1;

                if (k * k > 100 - 1)  //如果现在这个序列中最大数小于最后一个标出的素数的平方，
                    break;                          //那么剩下的序列中所有的数都是素数

                for (int i = 2; i < 100; i++) //将筛选后的第一个数当做新的筛子
                    if (i > k && array[i] == 0)
                    {
                        k = i;
                        break;
                    }
            }
            for (int i = 2; i < 100; i++)
            {
                if (array[i] == 0)
                    Console.WriteLine(i);
            }
           Console.ReadKey();
        }
    }
}
