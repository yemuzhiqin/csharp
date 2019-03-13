using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week01
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Hello World编写
            //System.Console.WriteLine("Hello World!");

            ///运算符
            //int x = 2, y = 1;
            //int z;
            //z = x + y;
            //System.Console.WriteLine("x={0},y={1}", x, y);
            //System.Console.WriteLine("x+y={0}", x + y);
            //System.Console.WriteLine(z);

            ///变量的作用域
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //string S1 = "Welcome!";
            //string S2 = "NET AND C#";
            //char c = S1[0];
            //System.Console.WriteLine(c);

            ///string类型
            //string s1 = "a string";
            //string s2 = s1;
            //Console.WriteLine("s1 is " + s1);
            //Console.WriteLine("s2 is " + s2);
            //s1 = "another string";
            //Console.WriteLine("s1 is now " + s1);
            //Console.WriteLine("s2 is now " + s2);

            ///if条件语句
            //        Console.WriteLine("Type in a string");
            //        string input;
            //        input = Console.ReadLine();
            //        if (input == "")
            //        {
            //            Console.WriteLine("You typed in an empty string");
            //        }
            //        else if (input.Length < 5)
            //        {
            //            Console.WriteLine("The string had less than 5 characters");
            //        }
            //        else if (input.Length < 10)
            //        {
            //            Console.WriteLine("The string had at least 5 but less than 10 characters");
            //        }
            //        Console.WriteLine("The string was " + input);

            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}

            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.ReadLine();
        }
    }


}
