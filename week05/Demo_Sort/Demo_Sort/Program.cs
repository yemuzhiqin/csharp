using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Sort
{
    class Program
    {
        //冒泡排序法
        static void Main(string[] args)
        {
            int[] arr = { 9,4,6,8,10,13,2,1,3};
            Console.WriteLine("原始数据：");
            foreach(int x in arr)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();

            MySort(arr, false);

            Console.WriteLine("升序排序后数据：");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            MySort(arr, true);

            Console.WriteLine("降序排序后数据：");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.ReadKey();

        }

        public static void MySort(int[] arr,bool descIndex)
        {
            //冒泡排序法
            int tmp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((descIndex && (arr[i] < arr[j])) || (!descIndex && (arr[i] > arr[j])))
                    //if (arr[i] < arr[j]) //降序
                    //if (arr[i] > arr[j]) //升序
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }
    }
}
