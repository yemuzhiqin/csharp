using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_Struct
{
    class Program
    {
        public struct StructStudent //结构（值类型，栈）
        {
            /// <summary>
            /// 1.结构与类的区别：
            /// （1）结构属于值类型，它可以有方法和构造函数，但不能实现继承；类属于引用类型，可以实现继承
            /// （2）结构可以不使用new实例化，定义成员变量不能赋初值；类必须使用new实例化
            /// （3）结构没有默认的构造函数，但可以添加构造函数；类有默认的构造函数
            /// （4）结构没有析构函数；类有析构函数
            /// （5）结构不能使用abstract、protected和sealed修饰符；类可以使用abstract、protected和sealed修饰符
            /// 2.结构和类的共同点：都能实现接口
            /// </summary>

            public string Name;
            public string Sex;
            public int Age;
            public string Addr;

            public void Show()
            {
                Console.WriteLine("Show()方法显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}",Name,Sex,Age,Addr);
            }

            public StructStudent(string name, string sex, int age, string addr)//结构的有参构造函数
            {
                Name = name;
                Sex = sex;
                Age = age;
                Addr=addr;
            }

        }

        static void Main(string[] args)//栈
        {
            StructStudent stu;//定义一个结构变量，没有使用new

            stu.Name = "夜幕之琴";
            stu.Sex = "女";
            stu.Age = 20;
            stu.Addr = "地球";

            stu.Show();
            Console.WriteLine("Main()方法显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", stu.Name, stu.Sex, stu.Age, stu.Addr);


            StructStudent stu1 = new StructStudent("yemuzhiqin","women",20,"world");

            stu1.Show();
            Console.WriteLine("Main()方法显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", stu1.Name, stu1.Sex, stu1.Age, stu1.Addr);

            System.Console.ReadKey();

        }
    }
}
