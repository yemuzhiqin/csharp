using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //格式化日期数据
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0}",dt);
            Console.WriteLine("{0:d}", dt);//简短日期格式（YYYY-MM-dd）
            Console.WriteLine("{0:D}", dt);//完整日期格式（YYYY年MM月dd日）
            Console.WriteLine("{0:t}", dt);//简短时间格式（hh:mm）
            Console.WriteLine("{0:T}", dt);//完整时间格式（hh:mm:ss）
            Console.WriteLine("{0:f}", dt);//简短的日期/时间格式（YYYY年MM月dd日 hh:mm）
            Console.WriteLine("{0:F}", dt);//完整的日期/时间格式（YYYY年MM月dd日 hh:mm：ss）
            Console.WriteLine("{0:g}", dt);//简短的可排序的日期/时间格式（YYYY-MM-dd hh:mm）
            Console.WriteLine("{0:G}", dt);//完整的可排序的日期/时间格式（YYYY-MM-dd hh:mm：ss）
            Console.WriteLine("{0:y}", dt);//年/月格式（YYYY年MM月）
            Console.WriteLine("{0:Y}", dt);//年/月格式（YYYY年MM月）
            Console.WriteLine("{0:m}", dt);//月/日格式（MM月dd日）
            Console.WriteLine("{0:M}", dt);//月/日格式（MM月dd日）

            Console.ReadKey();
        }
    }
}
