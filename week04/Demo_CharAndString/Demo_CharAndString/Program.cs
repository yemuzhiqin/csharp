using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CharAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            ///char为值类型，使用单引号（''）  string为引用类型，使用双引号（""）
            
            Test t1 = new Test();//引用类型
            Test t2 = t1;

            Console.WriteLine("t1.x={0},t1.y={1}", t1.x, t1.y);
            Console.WriteLine("t2.x={0},t2.y={1}", t2.x, t2.y);

            t2.x = 11;
            t2.y = 22;
            Console.WriteLine("t1.x={0},t1.y={1}", t1.x, t1.y);
            Console.WriteLine("t2.x={0},t2.y={1}", t2.x, t2.y);

            string name = "夜幕之琴";
            char sex = '女';
            double score = 86.5;
            string s = name;
            Console.WriteLine("name={0},sex={1},score={2}",name,sex,score);
            s = "yemuzhiqin";//这一操作并不会改变name变量的值
            Console.WriteLine("name={0},sex={1},score={2}", name, sex, score);//此时输出的name值仍然为夜幕之琴

            Console.ReadKey();

        }
    }
    class Test
    {
        public int x = 10;
        public int y = 20;
    }
}
