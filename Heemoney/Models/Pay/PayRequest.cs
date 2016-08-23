using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heemoney.Models.Pay
{
    public class PayRequest
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

        [JsonProperty("channel_provider")]
        public string Channel_Provider { get; set; }

        [JsonProperty("channel_code")]
        public string Channel_Code { get; set; }

        [JsonProperty("out_trade_no")]
        public string Out_Trade_No { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("total_amt_fen")]
        public string Total_Amt_Fen { get; set; }

        [JsonProperty("bill_timeout")]
        public string Bill_TimeOut { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("subject_detail")]
        public string Subject_Detail { get; set; }

        [JsonProperty("user_identity")]
        public string User_Identity { get; set; }

        [JsonProperty("user_ip")]
        public string User_Ip { get; set; }

        [JsonProperty("merch_extra")]
        public string Merch_Extra { get; set; }

        [JsonProperty("meta_option")]
        public string Meta_Option { get; set; }

        [JsonProperty("pay_option")]
        public string Pay_Option { get; set; }

        [JsonProperty("notify_url")]
        public string Notify_Url { get; set; }

        [JsonProperty("return_url")]
        public string Return_Url { get; set; }
    }
}
