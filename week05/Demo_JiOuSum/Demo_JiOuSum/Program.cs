using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_JiOuSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jsum = 0, Osum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Osum += i;
                }
                else
                {
                    Jsum += i;
                }
            }
            Console.WriteLine("1~100之间的奇数和为：{0}",Jsum);
            Console.WriteLine();
            Console.WriteLine("1~100之间的偶数和为：{0}", Osum);
            Console.ReadKey();
        }
    }
}
