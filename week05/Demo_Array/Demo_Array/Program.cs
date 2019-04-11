using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr3 = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("arr1[{0}]={1}  ", i, arr1[i]);
            }
            Console.WriteLine();

            arr2[2] = 89;
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("arr2[{0}]={1}  ", i, arr2[i]);
            }
            Console.WriteLine();

            arr3[4] = 77;
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("arr3[{0}]={1}  ", i, arr3[i]);
            }

            Console.ReadKey();
        }
    }
}
