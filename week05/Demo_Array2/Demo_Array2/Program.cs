using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = {1,43,64,7,22,10,5};

            //二维数组的定义及分配空间
            int[,] arr1 = new int[2, 3];//定长二维数组
            int[][]arr2 = new int[2][];//非定长二维数组
            arr2[0] = new int[3];
            arr2[1] = new int[8];

            //二维数组的赋值
            int[,] a = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //二维数组的遍历（foreach）
            Console.WriteLine("使用foreach遍历数组元素的结果为：");
            foreach (int x in a)
            {
                Console.WriteLine(x+" ");
            }
            Console.WriteLine();

            //二维数组的遍历(for)
            Console.WriteLine("使用for遍历定长数组元素的结果为：");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)//取得定长数组元素的列数
                {
                    arr1[i, j] = i + j;
                    Console.Write("arr1[{0},{1}]={2}  ",i,j,arr1[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("使用GetLength获取数组的行列数：");
            Console.WriteLine("arr2.Length={0},arr2.GetLength(0)={1},arr2[0].GetLength(0)={2},arr2[1].GetLength(0)={3}",
                arr2.Length,arr2.GetLength(0),arr2[0].GetLength(0),arr2[1].GetLength(0));
            Console.WriteLine();

            Console.WriteLine("使用for遍历非定长数组元素的结果为：");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2[i].GetLength(0); j++)//取得非定长数组某一行的元素个数
                {
                    arr2 [i][j] = i + j;
                    Console.Write("arr2[{0},{1}]={2}  ", i, j, arr2[i][j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
