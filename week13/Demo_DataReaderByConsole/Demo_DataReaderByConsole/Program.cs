using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Demo_DataReaderByConsole
{
    /// <summary>
    /// 程序功能：数据库的连接和数据表的读取
    /// 注意事项：须引入System.Data.SqlClient命名空间
    /// </summary>
    class Program
    {

        private static void ReadCzyTableInfo()
        {
            string connStr = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=myDB;Persist Security Info=True;User ID=myDB_sa;Password=sbq123456;";
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = connStr;

            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("数据库连接失败！请检查配置文件信息！" + e.Message);
                Console.WriteLine(connStr);
                return;
            }

            //查询操作员表的所有记录
            string sqlStr = "select * from Table_Czy";

            SqlCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = sqlStr;

            SqlDataReader sdr = sqlCmd.ExecuteReader();//ExecuteReader()方法可返回单向的、只读的数据记录集

            //在一行中迭代输出操作员表的字段名信息
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write("{0,-10}\t", sdr.GetName(i).Trim());//输出字段名列表，{0,-10}表示输出内容时占用10字符位置，左对齐输出，以TAB字符分隔各字段
            }
 
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write("{0,-10}\t", sdr[i]);//输出字段内容
                    //Console.Write("{0}\t", sdr.GetValue(i));//与上一语句等价
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            sqlConn.Close();//后面的代码不再需要对数据库的操作了，直接断开与数据库的连接
            return;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("开始读取操作员表中的数据：");
            ReadCzyTableInfo();
            Console.WriteLine("数据读取完成！");
            Console.ReadKey();
        }
    }
}
