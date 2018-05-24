using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Postman.src.model
{
    class NetResourceGetter
    {
        /// <summary>
        /// 获取网络资源
        /// </summary>
        /// <param name="url"></param>
        /// <param name="para"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public static string getResource(string url, string para, string method)
        {
            string ret=string.Empty;
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byteArray = encoding.GetBytes(para); //转化
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(url));
            webReq.Method = method;
            webReq.ContentType = "application/x-www-form-urlencoded;charset=utf8";
            if (method == "POST")
            {
                webReq.ContentLength = byteArray.Length;
                Stream newStream = webReq.GetRequestStream();
                newStream.Write(byteArray, 0, byteArray.Length);//写入参数
                newStream.Close();
            }
            HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), encoding);
            ret = sr.ReadToEnd();
            sr.Close();
            response.Close();
            return ret;
        }
    }
}
