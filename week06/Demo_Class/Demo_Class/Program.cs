using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_Class
{
    class Program
    {
        public class Student //类（引用类型）
        {
            /// <summary>
            /// 类的访问权限：public(公有），private(私有），protected(可保护），internal(内部的)
            /// 在C#中修饰符默认为private
            /// </summary>
            private string _Name;//private 字段
            private string _Sex;
            private int _Age;
            private string _Addr;

            public string Name//public属性
            {
                //get控制读属性，set控制写属性
                get {return _Name;}//若只有get没有set，则为只读属性
                set { _Name = value; }//若只有set没有get，则为只写属性
            }

            public string Sex
            {
                get { return _Sex; }
                set {
                    if (value != "男" && value != "女")
                    {
                        Console.WriteLine("Sex属性只能赋值【男】或者【女】。");
                        _Sex = "女";
                    }
                    else
                    {
                        _Sex = value;
                    } 
                }//value是set方法中的隐型默认变量
            }

            public int Age
            {
                get { return _Age; }
                set 
                {
                    if (value < 18 || value > 100)
                    {
                        Console.WriteLine("Age的取值范围为：18~100");
                        _Age = 18;
                    }
                    else
                    {
                        _Age = value;
                    }
                }
            }

            public string Addr
            {
                get { return _Addr; }
                set { _Addr = value; }
            }

            public void Show()
            {
                Console.WriteLine("Show()方法显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", _Name, _Sex, _Age, _Addr);
            }

            public Student()//类的无参构造函数
            {
                _Name = "";
                _Sex = "";
                _Age = 0;
                _Addr = "";
            }

            public Student(string name,string sex,int age,string addr)//类的有参构造函数
            {
                _Name = name;
                if (sex != "男" && sex != "女")
                    {
                        Console.WriteLine("Sex属性只能赋值【男】或者【女】。");
                        _Sex = "女";
                    }
                    else
                    {
                        _Sex = sex;
                    } 
                _Age = age;
                _Addr = addr;
            }

        }

            

        static void Main(string[] args)//栈
        {

            Student stu=new Student();//定义一个类对象，使用new进行实例化
            stu.Name = "夜幕之琴";
            stu.Sex = "女";
            stu.Age = 120;
            stu.Addr = "地球";

            stu.Show();
            Console.WriteLine("Main()方法显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", stu.Name, stu.Sex, stu.Age, stu.Addr);


            Student stu1 = new Student("yemuzhiqin", "women", 20, "world");

            stu1.Show();
            Console.WriteLine("Main()方法显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", stu1.Name, stu1.Sex, stu1.Age, stu1.Addr);

            System.Console.ReadKey();

        }
    }
}