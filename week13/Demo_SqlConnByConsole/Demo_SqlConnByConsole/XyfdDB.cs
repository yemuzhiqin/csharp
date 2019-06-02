using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Demo_SqlConnByConsole
{
    class XyfdDB
    {
        private string _datasource = "";
        private string _database = "";
        private string _loginUser = "";
        private string _loginPwd = "";

        private SqlConnection _sqlConn;

        private string GetConnStr(string datasource,string database,string loginUser,string loginPwd)
        {
            _datasource = datasource;
            _database = database;
            _loginUser = loginUser;
            _loginPwd = loginPwd;

            return "Data Source=" + _datasource + ";Initial Catalog=" + _database + ";Persist Security Info=True;User ID=" + _loginUser + ";Password=" + _loginPwd;
        }

        public XyfdDB(string datasource, string database, string loginUser, string loginPwd)
        {
            string connStr = GetConnStr(datasource, database, loginUser, loginPwd);
            _sqlConn = new SqlConnection();
            _sqlConn.ConnectionString = connStr;
        }

        public void Close()
        {
            _sqlConn.Close();//后面的代码不再需要对数据库的操作了，直接断开与数据库的连接
        }

        public bool LinkDbSrv()
        {
            try
            {
                _sqlConn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("数据库连接失败！请检查配置文件信息！" + e.Message);
                Console.WriteLine(_sqlConn.ConnectionString);
            }

            if (_sqlConn.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("数据库连接成功！当前连接信息为：");
            }
            else
            {
                Console.WriteLine("数据库连接失败！当前连接信息为：");
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("数据库服务器：{0}", _sqlConn.DataSource);
            Console.WriteLine("登录数据库名：{0}", _sqlConn.Database);
            Console.WriteLine("登录用户名为：{0}", _loginUser);
            Console.WriteLine("登录用户密码：{0}", _loginPwd);
            Console.WriteLine("-------------------------------------------");

            return _sqlConn.State == System.Data.ConnectionState.Open;
        }
    }
}
