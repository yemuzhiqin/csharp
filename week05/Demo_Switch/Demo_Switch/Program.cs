using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入银行的英文简称：");
            string bank = Console.ReadLine();
            switch (bank)
            {
                case "ICBC":
                    Console.WriteLine("中国工商银行");
                    break;
                case "CBC":
                    Console.WriteLine("中国建设银行");
                    break;
                case "ABC":
                    Console.WriteLine("中国农业银行");
                    break;
                case "BOC":
                    Console.WriteLine("中国银行");
                    break;
                default:
                    Console.WriteLine("银行简称输入错误！");
                    break;
            }
            Console.ReadKey();
        }
    }
}
