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
            //1.字符串的比较
            string str1 = "abc";
            string str2 = "Abc";
            Console.WriteLine("str1==str2的结果为：{0}",str1==str2);
            Console.WriteLine("str1.Equals(str2)的结果为:{0}", str1.Equals(str2));
            Console.WriteLine("str1.CompareTo(str2)的结果为：{0}", str1.CompareTo(str2));//若str1==str2,则返回0；若str1<str2，则返回-1；若str1>str2，则返回1
            Console.WriteLine("string.Compare(str1,str2)的结果为：{0}",string.Compare(str1,str2));//默认比较是区分大小写的；比较同上
            Console.WriteLine("string.Compare(str1,str2)的结果为：{0}", string.Compare(str1, str2,true));//比较是不区分字符的大小写的
            Console.WriteLine("str1.ToLower()==str2.ToLower()的结果为：{0}", str1.ToLower() == str2.ToLower());//先转换成小写再进行比较
            Console.WriteLine("str1.ToUpper() == str2.ToUpper()的结果为：{0}", str1.ToUpper() == str2.ToUpper());//先转换成大写再进行比较

            ///2.判断一个字符串是空值还是空字符串
            ///str = null;//空值
            ///str = "";//空字符串
            ///(1)if(str==null || str=="")
            ///(2)if(string.IsNullOrEmpty(str))
            ///(3)if(str.Equals(string.Empty))
            
            ///3.转义字符：以反斜杠(\)开头
            ///\n:回车换行  \t:横向跳到下一制表位置  \b:退格  \r:回车  \f:换页  \\:反斜杠符  \":双引号  \':单引号符
            string str = "abc\tdef\trjk";
            Console.WriteLine("str={0}", str);
            Console.ReadKey();
        }
    }
}
