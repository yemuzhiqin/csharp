using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("sbyte类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}",typeof(sbyte),sizeof(sbyte),sbyte.MinValue,sbyte.MaxValue);
            System.Console.WriteLine("short类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(short), sizeof(short), short.MinValue, short.MaxValue);
            System.Console.WriteLine("int类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(int), sizeof(int), int.MinValue, int.MaxValue);
            System.Console.WriteLine("long类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(long), sizeof(long), long.MinValue, long.MaxValue);
            System.Console.WriteLine("byte类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(byte), sizeof(byte), byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("ushort类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(ushort), sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            System.Console.WriteLine("uint类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(uint), sizeof(uint), uint.MinValue, uint.MaxValue);
            System.Console.WriteLine("ulong类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(ulong), sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            System.Console.WriteLine("float类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(float), sizeof(float), float.MinValue, float.MaxValue);
            System.Console.WriteLine("double类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(double), sizeof(double), double.MinValue, double.MaxValue);
            System.Console.WriteLine("decimal类型原型为{0}，占用字节数{1}，取值范围：{2}~{3}", typeof(decimal), sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            System.Console.WriteLine("char类型原型为{0}，占用字节数{1}", typeof(char), sizeof(char));
            System.Console.ReadKey();
        }
    }
}