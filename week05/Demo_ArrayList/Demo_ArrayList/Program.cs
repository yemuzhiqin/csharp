using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Demo_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList的类为：Collections
            int[] a = { 3, 5, 65, 32, 7, 4, 54, 23 };
            ArrayList List = new ArrayList(a);

            Console.WriteLine("数组的原始值为：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("List的原始值为：");
            foreach (int x in List)
            {
                Console.Write(x+ " ");
            }
            Console.WriteLine();

            List.Add(43);
            List.Insert(3, 80);
            Console.WriteLine("增加和插入数据后的List值为：");
            foreach (int x in List)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            //Clear方法——全部删除  Clear()
            List.Remove(5);//删除指定元素  Remove(Object obj)
            List.RemoveAt(4);//删除指定索引处元素  RemoveAt(int index)
            Console.WriteLine("删除两个数据后的List值为：");
            foreach (int x in List)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            //RemoveRange方法——删除部分元素  RemoveRange(int index,int count)
            List.RemoveRange(3, 2);
            Console.WriteLine("删除一段数据后的List值为：");
            foreach (int x in List)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();


            Console.WriteLine("List升序排序后的值为：");
            List.Sort();
            foreach (int x in List)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();


            Console.WriteLine("List降序排序后的值为：");
            List.Reverse();
            foreach (int x in List)
            {
                Console.Write(x + " ");
            }
            

            Console.ReadKey();
        }
    }
}
