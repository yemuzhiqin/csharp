using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入银行的英文简称：");
            string bank = Console.ReadLine();
            if (bank == "ICBC")
                Console.WriteLine("中国工商银行");
            else if (bank == "CBC")
                Console.WriteLine("中国建设银行");
            else if (bank == "ABC")
                Console.WriteLine("中国农业银行");
            else if (bank == "BOC")
                Console.WriteLine("中国银行");
            else
                Console.WriteLine("银行简称输入有误！");

            Console.ReadKey();
        }
    }
}
