using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace XjHealth.lib
{
   public class JsonHelper
    {
        /// <summary>
        /// 将对象序列化JSON格式
        /// </summary>
        /// <param name="o">对象</param>
        /// <returns>json字符串</returns>
        public static string SerializeObject(object o)
        {
            string json= JsonConvert.SerializeObject(o);
            return json;
        }

        /// <summary>
        ///解析json字符串为对象实体 
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <returns></returns>
       public static T DeserializeJsonToObject<T>(string json) where T: class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json); 
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
            T t = o as T;
            return t;
        }

        /// <summary>
        /// 解析json数组生成对象实体集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <typeparam name="json">json数组字符串</typeparam>
        /// <returns>对象实体集合</returns>
        public static List<T> DeserializeJsonToList<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StreamReader sr = new StreamReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr),typeof(List<T>));
            List<T> list = o as List<T>;
            return list;
        }

        /// <summary>
        /// 反序列化json到给定的匿名对象
        /// </summary>
        /// <typeparam name="T">匿名对象类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <param name="anonymousTypeObject">匿名对象</param>
        /// <returns>匿名对象</returns>
        public static T DeserializeAnoymousType<T>(string json, T anonymousTypeObject)
        {
            T t = JsonConvert.DeserializeAnonymousType(json,anonymousTypeObject);
            return t;
        }
    }
}
