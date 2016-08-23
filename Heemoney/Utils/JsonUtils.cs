using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heemoney.Utils
{
    public class JsonUtils
    {
        public static string GetJsonStringValue(JObject jobject, string token)
        {
            JToken jToken = jobject.SelectToken(token);

            if (jToken == null)
            {
                return "";
            }
            return jToken.ToString();
        }
    }
}
