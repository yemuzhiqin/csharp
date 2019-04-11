using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            int[] arr3 = { 1,2,3,4,5,6};

            for(int i=0;i<arr1.Length;i++)
            {
                arr1[i] = i * i;
                Console.Write("{0} ",arr1[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
                Console.Write("{0} ",arr2[i]);
            Console.WriteLine();

            foreach (int x in arr3)
                Console.Write("{0} ",x);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
