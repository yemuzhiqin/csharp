using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_Ref
{
    class Program
    {
        //数据的交换
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine("原始数据为:");
            Console.WriteLine("x={0},y={1}",x,y);

            SwapByValue(x, y);
            Console.WriteLine("调用SwapByValue(x,y)函数后的数据为:");
            Console.WriteLine("x={0},y={1}", x, y);//并没有交换x,y的值

            SwapByRef(ref x, ref y);//ref相当于指针
            Console.WriteLine("调用SwapByRef(ref x, ref y)函数后的数据为:");
            Console.WriteLine("x={0},y={1}", x, y);//已经交换了x,y的值

            Console.ReadKey();
        }

        public static void SwapByValue(int a,int b)//a,b为值类型参数
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        //使用ref进行数据的交换
        public static void SwapByRef(ref int a, ref int b)//a,b为引用类型参数
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
