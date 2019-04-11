using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {2,5,1,19,81,23,4,6};

            ArrayList List = new ArrayList(a); 

            Console.WriteLine("数组的原始值：");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();

            Console.WriteLine("List的原始值：");
            foreach (int x in List)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
			
            List.Add(66);
            List.Insert(3, 44);
            Console.WriteLine("List的新增和插入数据后：");
            foreach (int x in List)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
			
            List.Remove(5);
            List.RemoveAt(3);

            Console.WriteLine("List的删除2个数据后：");
            foreach (int x in List)
            {
                Console.Write(x+" ");
            }

            Console.WriteLine();

            List.RemoveRange(3, 2);
            Console.WriteLine("List的删除一段数据：");
            foreach (int x in List)
            {
                Console.Write(x+" ");
            }

			
            Console.WriteLine();
            List.Sort();
            Console.WriteLine("List排序之后的值：");
            foreach (int x in List)
            {
                Console.Write(x + " ");
            }

            Console.ReadKey();

        }
    }
}
