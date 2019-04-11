using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入银行的英文简称：");
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
                    Console.WriteLine("输入的银行简称有误！");
                    break;
            }
            Console.ReadKey();
        }
    }
}
