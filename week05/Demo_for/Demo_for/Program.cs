using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数：");
            int iMax = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= iMax; i++)
            {
                sum += i;
            }
            Console.WriteLine("for()循环执行结果：");
            Console.WriteLine("1~所输入正整数的和为：{1}",iMax,sum);
            Console.WriteLine();

            sum = 0;
            int j = 1;
            while (j <= iMax)
            {
                sum += j;
                j++;
            }
            Console.WriteLine("while()循环执行结果：");
            Console.WriteLine("1~所输入正整数的和为：{1}", iMax, sum);
            Console.WriteLine();

            sum = 0;
            j = 1;
            do
            {
                sum += j;
                j++;
            } while (j <= iMax) ;
            Console.WriteLine("while()循环执行结果：");
            Console.WriteLine("1~所输入正整数的和为：{1}", iMax, sum);

            Console.ReadKey();
        }
    }
}
