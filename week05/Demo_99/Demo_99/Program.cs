using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("打印九九乘法表：");
            Console.WriteLine();
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);
                }
                Console.WriteLine();//换行
            }
            Console.ReadKey();
        }
    }
}
