using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heemoney.Utils
{
    public class MapperUtils
    {
        public static string MapToJson<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }

        public static T JsonToMap<T>(string json)
        {
            return JsonToMap<T>(json, null);
        }

        public static T JsonToMap<T>(string json, string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                json = JObject.Parse(json).SelectToken(token).ToString();
            }
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
