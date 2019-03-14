using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    class Program
    {
        public enum Mrkj   //枚举类型
        {
            csharp,app=4,c,java
        }
        public enum SEX    //枚举类型
        {
            M,W
        }
        public class Student
        {
            public string Name = "qd";
            public SEX Sex = SEX.W;
            public int Age = 18;
        }
        static void Main(string[] args)
        {
            //枚举类型的值默认从0开始
            System.Console.WriteLine("Mrkj.csharp={0},索引值={1}",Mrkj.csharp,(int)Mrkj.csharp);
            System.Console.WriteLine("Mrkj.app={0},索引值={1}", Mrkj.app, (int)Mrkj.app);
            System.Console.WriteLine("Mrkj.c={0},索引值={1}", Mrkj.c, (int)Mrkj.c);
            System.Console.WriteLine("Mrkj.java={0},索引值={1}", Mrkj.java, (int)Mrkj.java);

            Student stu1 = new Student();
            System.Console.WriteLine("stu1中的原始值：{0},{1},{2}",stu1.Name,stu1.Sex,stu1.Age);

            //修改成员变量的值
            stu1.Name = "夜幕之琴";
            stu1.Age = 20;

            System.Console.WriteLine("stu1修改后的值：{0},{1},{2}", stu1.Name, stu1.Sex, stu1.Age);

            System.Console.ReadKey();
        }
    }
}
