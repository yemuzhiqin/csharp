using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable srvInfo = new Hashtable(); //哈希表经常用于保存或读取软件的配置信息，比如要存储数据库的连接信息等

            srvInfo.Add("SrvIp", "172.18.4.100");
            srvInfo.Add("DbName", "jfglxt");
            srvInfo.Add("UserName", "sa"); 
            srvInfo.Add("UserPwd", "1234@abcd");

            foreach (DictionaryEntry dicEntry in srvInfo)
               Console.WriteLine(dicEntry.Key + "\t " + dicEntry.Value);

            Console.WriteLine();//输出一个换行

            Console.WriteLine("SrvIp={0}",srvInfo["SrvIp"]);
            Console.WriteLine("DbName={0}",srvInfo["DbName"]);
            Console.WriteLine("UserName={0}", srvInfo["UserName"]);
            Console.WriteLine("UserPwd={0}", srvInfo["UserPwd"]);

            Console.WriteLine();//输出一个换行
            if (srvInfo.Contains("DbName")) //等价于srvInfo.ContainsKey("DbName")
            {
                Console.WriteLine("Key为DbName的键值已找到！");
            }
            if (srvInfo.ContainsValue("jfglxt"))
            {
                Console.WriteLine("Vlaue为jfglxt的内容已找到！");
            }
            System.Console.ReadKey();
        }
        
    }
}
