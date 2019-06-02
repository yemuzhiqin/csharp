using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Demo_SqlConnByConsole
{
    class Program
    {

        private static string GetConnStr(string datasource, string database, string loginUser, string loginPwd)
        {
            //真实的项目开发时，应该从配置文件中获取数据库连接信息
            return "Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + loginUser + ";Password=" + loginPwd;


        }

        private static void LinkDbSrv(string dbSrv, string dbName, string loginUser, string loginPwd)
        {
            //string connStr = "Data Source=(local)\SQLEXPRESS;Initial Catalog=myDB;Persist Security Info=True;User ID=myDB_sa;Password=sbq123456;";
            string connStr = GetConnStr(dbSrv, dbName, loginUser, loginPwd);
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = connStr;

            try
            {
                sqlConn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("数据库连接失败！请检查配置文件信息！" + e.Message);
                Console.WriteLine(connStr);
                return;
            }

            if (sqlConn.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("数据库连接成功！当前连接信息为：");
            }
            else
            {
                Console.WriteLine("数据库连接失败！当前连接信息为：");
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("数据库服务器：{0}", sqlConn.DataSource);
            Console.WriteLine("登录数据库名：{0}", sqlConn.Database);
            Console.WriteLine("登录用户名为：{0}", loginUser);
            Console.WriteLine("登录用户密码：{0}", loginPwd);
            Console.WriteLine("-------------------------------------------");
            sqlConn.Close();//后面的代码不再需要对数据库的操作了，直接断开与数据库的连接
            return;

        }

        static void Main(string[] args)
        {
            //真实的项目开发时，应该从配置文件中获取数据库连接信息
            string dbSrv = "(local)\\SQLEXPRESS";//数据库服务器IP
            string dbName = "myDB";//数据库名称
            string loginUser = "myDB_sa";//登录名
            string loginPwd = "sbq123456";//登录密码

            LinkDbSrv(dbSrv, dbName, loginUser, loginPwd);

            Console.WriteLine("\r\n\r\n=========下面使用外部自定义数据库操作类的方式连接数据库=========\r\n\r\n");
            XyfdDB myDb = new XyfdDB(dbSrv, dbName, loginUser, loginPwd);
            myDb.LinkDbSrv();
            myDb.Close();

            Console.ReadKey();
            


        }
    }
}
