using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "人生若只如初见,";

            //1.字符串的插入（Insert()）
            string s = str.Insert(8, "何事秋风悲画扇。");//在字符串中间或者末尾插入
            Console.WriteLine("s={0}", s);

            s = "何事秋风悲画扇" + str;//在字符串前面插入
            Console.WriteLine("s={0}", s);

            //2.字符串的替换（Replace()）
            s = str.Replace(",", ",何事秋风悲画扇。");
            Console.WriteLine("s={0}", s);

            //3.字符串的删除（Remove()）
            s = str.Remove(5,3);
            Console.WriteLine("s={0}", s);

            //4.字符串的添加填充（PadLeft(),PadRight()）
            string s1 = str.PadLeft(9, '【');//宽度不足时并不会删除原始的字符串
            s=s1.PadRight(10,'】');
            Console.WriteLine("s={0}", s);

            //5.字符串的截取（Substring()）
            s = str.Substring(5, 2);//索引号从0开始
            Console.WriteLine("s={0}", s);
            string str1 = "yemuzhiqin@qq.com";
            int y = str1.IndexOf('@');
            s = str1.Substring(0,y);//截取邮箱号（即@之前所有的字符）
            Console.WriteLine("s={0}", s);

            //6.字符串的分割（Split()）
            string str2 = "人生若只如初见,何事秋风悲画扇,等闲变却故人心,却道故人心易变,骊山语罢清宵半,泪雨零铃终不怨,何如薄幸锦衣郎,比翼连枝当日愿,";
            int[] x = { 1, 2, 3 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            string[] sList=str2.Split(',');
            for (int i = 0; i < sList.Length; i++)
            {
                Console.WriteLine(sList[i]);
            }

            Console.ReadKey();

        }
    }
}
