using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heemoney.Models.Query
{
    public class QueryResponse : Response
    {
        [JsonProperty("return_code")]
        public string Return_Code { get; set; }

        [JsonProperty("err_code")]
        public string Err_Code { get; set; }

        [JsonProperty("err_code_des")]
        public string Err_Code_Des { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("app_id")]
        public string App_ID { get; set; }

        [JsonProperty("mch_id")]
        public string Mch_ID { get; set; }

        [JsonProperty("charset")]
        public string Charset { get; set; }

        [JsonProperty("sign_type")]
        public string Sign_Type { get; set; }

        [JsonProperty("out_trade_no")]
        public string Out_Trade_No { get; set; }

        [JsonProperty("hy_bill_no")]
        public string Hy_Bill_No { get; set; }

        [JsonProperty("channel_provider")]
        public string Channel_Provider { get; set; }

        [JsonProperty("channel_code")]
        public string Channel_Code { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("total_amt_fen")]
        public string Total_Amt_Fen { get; set; }

        [JsonProperty("bill_timeout")]
        public string Bill_TimeOut { get; set; }

        [JsonProperty("trade_status")]
        public string Trade_Status { get; set; }

        [JsonProperty("hy_deal_time")]
        public string Hy_Deal_Time { get; set; }

        [JsonProperty("merch_extra")]
        public string Merch_Extra { get; set; }

        [JsonProperty("hy_pay_extra")]
        public string Hy_Pay_Extra { get; set; }
    }
}
