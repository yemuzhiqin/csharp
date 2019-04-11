using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输出九九乘法表：");
            Console.WriteLine();
            for(int row=1;row<=9;row++)
            {
                for(int col=1;col<=row;col++)
                {
                    Console.Write("{0}*{1}={2}\t",row,col,row*col);
                }
                Console.WriteLine();//换行
            }
            Console.ReadKey();
        }
    }
}
