using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.Security;
using Newtonsoft.Json.Linq;

namespace Heemoney
{
    public class HeemoneyUtils
    {
        /// <summary>
        /// DateTime转换TimeStamp
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static long GetTimeStamp(DateTime date)
        {
            long unixTimestamp = date.ToUniversalTime().Ticks - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
            unixTimestamp /= TimeSpan.TicksPerMillisecond;
            return unixTimestamp;
        }

        /// <summary>
        /// 组织请求数据
        /// </summary>
        /// <param name="jsonData"></param>
        /// <returns></returns>
        public static string GetRequestData(string jsonData)
        {
            JObject jobject = JObject.Parse(jsonData);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, object> dic = (Dictionary<string, object>)serializer.DeserializeObject(jsonData);

            string sign = HeemoneyUtils.GetSign(dic, HeemoneyConfig.KEY);
            jobject["sign"] = sign;

            return jobject.ToString();
        }

        public static string GetSign(Dictionary<string, object> map, string key)
        {
            if (map == null || key == null)
            {
                throw new HeemoneyException("map或key不可为空");
            }

            StringBuilder sb = new StringBuilder();
            ArrayList aLKeys = new ArrayList(map.Keys);
            aLKeys.Sort();

            foreach (string theKey in aLKeys)
            {
                object theValue = map[theKey];
  
                if (!string.IsNullOrEmpty(theValue.ToString()) && theKey != "sign")
                {
                    sb.Append(theKey + "=" + theValue + "&");
                }
            }
            sb.Append("key=" + key);

            string sign = FormsAuthentication.HashPasswordForStoringInConfigFile(sb.ToString(), "MD5").ToUpper();
            return sign;
        }
    }
}
