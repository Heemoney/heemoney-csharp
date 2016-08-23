using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heemoney.Models.Pay
{
    public class PayResponse : Response
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

        [JsonProperty("trade_status")]
        public string Trade_Status { get; set; }

        [JsonProperty("merch_extra")]
        public string Merch_Extra { get; set; }

        [JsonProperty("hy_pay_extra")]
        public string Hy_Pay_Extra { get; set; }
    }
}
