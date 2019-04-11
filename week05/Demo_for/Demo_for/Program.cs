using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数：");
            int iMax = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= iMax; i++)
            {
                s += i;
            }
            Console.WriteLine("for()执行结果：");
            Console.WriteLine("1+2+3+..+{0}={1}", iMax, s);

            s = 0;
            int ii=1;
            while (ii<=iMax)
            {
                s += ii;
                ii++;
            }
            Console.WriteLine("while执行结果：");
            Console.WriteLine("1+2+3+..+{0}={1}", iMax, s);

            s = 0;
            ii = 1;
            do
            {
                s += ii;
                ii++;
            } while (ii <= iMax);
            Console.WriteLine("do ... while执行结果：");
            Console.WriteLine("1+2+3+..+{0}={1}", iMax, s);

            Console.ReadKey();
        }
    }
}
