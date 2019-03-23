using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder类的使用
            string str = "string:";
            TimeSpan ts = DateTime.UtcNow - new DateTime(1999, 1, 2);
            long startDT, endDT;
            startDT = ts.Milliseconds;
            for (int i = 1; i <= 10000; i++)
            {
                str += Convert.ToString(i);
                //Console.WriteLine(str);
            }
            endDT = ts.Milliseconds;
            Console.WriteLine("string赋值10000次花费的时间:{0}", endDT - startDT);

            StringBuilder sb = new StringBuilder("StringBuilder:");
            startDT = ts.Milliseconds;
            for (int i = 1; i < 10000; i++)
            {
                sb.Clear();
                sb.Append("StringBuilder:" + Convert.ToString(i));
                //Console.WriteLine(sb.ToString());
            }
            endDT = ts.Milliseconds;
            Console.WriteLine("StringBuilder赋值10000次花费的时间:{0}", endDT - startDT);

            Console.ReadKey();
        }
    }
}
