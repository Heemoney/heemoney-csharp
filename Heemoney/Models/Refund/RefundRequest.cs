using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heemoney.Models.Refund
{
    public class RefundRequest
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("app_id")]
        public string App_ID { get; set; }

        [JsonProperty("mch_id")]
        public string Mch_Id { get; set; }

        [JsonProperty("charset")]
        public string Charset { get; set; }

        [JsonProperty("timestamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("sign_type")]
        public string Sign_Type { get; set; }

        [JsonProperty("out_trade_no")]
        public string Out_Trade_No { get; set; }

        [JsonProperty("out_refund_no")]
        public string Out_Refund_No { get; set; }

        [JsonProperty("channel_provider")]
        public string Channel_Provider { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("total_amt_fen")]
        public string Total_Amt_Fen { get; set; }

        [JsonProperty("refund_fen_amt")]
        public string Bill_TimeOut { get; set; }

        [JsonProperty("notify_url")]
        public string Subject { get; set; }

        [JsonProperty("merch_extra")]
        public string Merch_Extra { get; set; }
    }
}
