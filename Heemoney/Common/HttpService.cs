using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Heemoney.Common
{
    public class HttpService
    {
        /// <summary>
        /// 查询请求 
        /// </summary>
        public static HttpWebResponse Get(string url, int timeout)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.Timeout = timeout;

            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary>
        /// 增加请求
        /// </summary>
        public static HttpWebResponse Post(string url, string payInfo, int timeout)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.Timeout = timeout;

            byte[] encodedBytes = Encoding.UTF8.GetBytes(payInfo);
            request.ContentLength = encodedBytes.Length;
            request.ContentType = "application/json";

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(encodedBytes, 0, encodedBytes.Length);
            requestStream.Close();

            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary>
        /// 获取请求的数据
        /// </summary>
        public static string GetResponseString(HttpWebResponse webresponse)
        {
            using (Stream s = webresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);

                return reader.ReadToEnd();
            }
        }
    }
}
