using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objecj
{
    class Program
    {
        static void Main(string[] args)
        {
            ///类型转换分为两类：（1）隐式类型转换 （2）显式（强制）类型转换：a.（类型名）表达式 b.Convert.To类型名（表达式） c.类型名.Parse(表达式)
            int i = 1;//值类型
            object obj;//引用类型
            obj = i;//装箱：把值类型赋给引用类型
            int x = (int)obj;//拆箱：把引用类型赋给值类型
            System.Console.WriteLine("x={0}",x);
            System.Console.ReadKey();
        }
    }
}
