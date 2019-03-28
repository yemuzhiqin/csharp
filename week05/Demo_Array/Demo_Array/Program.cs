using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //一维数组的定义以及初始化
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr3 = { 1, 2, 3, 4, 5 };

            //一维数组的遍历
            foreach (int x in arr1)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();


            //一维数组的元素的输出
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("arr1[{0}]={1} ",i,arr1[i]);
            }
            Console.WriteLine();

            arr2[2] = 11;
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("arr2[{0}]={1} ", i, arr2[i]);
            }
            Console.WriteLine();

            arr3[4] = 22;
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("arr3[{0}]={1} ", i, arr3[i]);
            }


            Console.ReadKey();
        }
    }
}
