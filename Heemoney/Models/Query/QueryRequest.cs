using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heemoney.Models.Query
{
    public class QueryRequest
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("app_id")]
        public string App_ID { get; set; }

        [JsonProperty("mch_id")]
        public string Mch_Id { get; set; }

        [JsonProperty("charset")]
        public string Charset { get; set; }

        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        [JsonProperty("timestamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("sign_type")]
        public string Sign_Type { get; set; }
    }
}
