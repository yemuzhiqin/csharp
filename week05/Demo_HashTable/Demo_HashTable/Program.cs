using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Demo_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //哈希表（HashTable 类为：Collections）

            Hashtable hashtable = new Hashtable();//哈希表经常用于保存或读取软件的配置信息，比如要存储数据库的连接信息等
            hashtable.Add("email", "yemuzhiqin@abc");
            hashtable.Add("id","201001");
            hashtable.Add("name","yemuzhiqin");
            hashtable.Add("sex", "female");
            


            foreach (DictionaryEntry dicEntry in hashtable)//DictionaryEntry用来定义可设置或检索的字典键/值对
            {
                Console.WriteLine("\t"+dicEntry.Key+"\t"+dicEntry.Value);
            }
            Console.WriteLine();//输出一个换行

            //输出所添加进哈希表中的所有信息
            Console.WriteLine("id={0}",hashtable["id"]);
            Console.WriteLine("name={0}", hashtable["name"]);
            Console.WriteLine("sex={0}", hashtable["sex"]);
            Console.WriteLine("email={0}", hashtable["email"]);
            Console.WriteLine();//输出一个换行


            ///Hashtable元素的查找
            
            //(1)Contains、ContainsKey方法——按键查找
            if (hashtable.ContainsKey("name"))//等价于hashtable.Contains("name")
            {
                Console.WriteLine("Key为name的键值已找到！");
            }
            
            //(2)ContainsValue方法——按值查找
            if (hashtable.ContainsValue("yemuzhiqin@abc"))
            {
                Console.WriteLine("Value为yemuzhiqin@abc的键值内容已找到！");
            }

            Console.ReadKey();

        }
    }
}
