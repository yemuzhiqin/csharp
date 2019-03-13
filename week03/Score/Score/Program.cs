using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = 78,Csharp = 90,JAVA = 63;
            int sub=Csharp - JAVA;
            int avg=(C + Csharp + JAVA)/3;
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("\tC\tCsharp\t\tJAVA");
            System.Console.WriteLine("\t{0}\t{1}\t\t{2}", C, Csharp, JAVA);
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("Csharp和JAVA课程的成绩分差为：{0}",sub);
            System.Console.WriteLine("三门课程的平均分为：{0}",avg);
            System.Console.ReadKey();
            
        }
    }
}
