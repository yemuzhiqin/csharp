using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 13,2,5,8,4,26,10};

            int[,] arr1 = new int[2,3];//定长二维数组
            int[][] arr2 = new int[2][];//非定长二维数组
            arr2[0] = new int[3];
            arr2[1] = new int[8];

            int[,] a = new int[2,3] { {78,2,3},{4,26,6}};

            for(int i=0;i<arr1.GetLength(0);i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)//取得定义数组元素的列数
                {
                    arr1[i, j] = i + j;
                    Console.Write("arr1[{0},{1}]={2}  ", i, j, arr1[i, j]);
                }
                Console.WriteLine();
            }

            

            foreach (int x in a)
            {
                {
                    Console.Write(x+"  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("arr2.Length={0},arr2.GetLength(0)={1},arr2[0].GetLength(1)={2},arr2[0].GetLength(1)={3}",
                arr2.Length, arr2.GetLength(0), arr2[0].GetLength(0), arr2[1].GetLength(0));
            //Console.ReadKey();

            
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2[i].GetLength(0); j++)//取得非定长数组某一行的元素个数
                {
                    arr2[i][j] = i + j;
                    Console.Write("arr2[{0}][{1}]={2}  ", i, j, arr2[i][j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
