using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串的比较
            string str1 = "abc";
            string str2 = "Abc";
            Console.WriteLine("str1==str2的结果为：{0}",str1==str2);
            Console.WriteLine("str1.Equals(str2)的结果为:{0}", str1.Equals(str2));
            Console.WriteLine("str1.CompareTo(str2)的结果为：{0}", str1.CompareTo(str2));//若str1==str2,则返回0；若str1<str2，则返回-1；若str1>str2，则返回1
            Console.WriteLine("string.Compare(str1,str2)的结果为：{0}",string.Compare(str1,str2));//默认比较是区分大小写的；比较同上
            Console.WriteLine("string.Compare(str1,str2)的结果为：{0}", string.Compare(str1, str2,true));//比较是不区分字符的大小写的
            Console.WriteLine("str1.ToLower()==str2.ToLower()的结果为：{0}", str1.ToLower() == str2.ToLower());//先转换成小写再进行比较
            Console.WriteLine("str1.ToUpper() == str2.ToUpper()的结果为：{0}", str1.ToUpper() == str2.ToUpper());//先转换成大写再进行比较



            Console.ReadKey();
        }
    }
}
