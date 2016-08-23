using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using Heemoney.Models.Pay;
using Heemoney;
using Heemoney.Utils;

namespace Demo
{
    public partial class Pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.RequestType.ToUpper().Equals("POST"))
            {
                var jObject = JObject.Parse(ReadStream(Request.InputStream));

                PayRequest payRequest = new PayRequest();
                payRequest.App_ID = jObject.SelectToken("app_id").ToString();
                payRequest.Mch_Id = jObject.SelectToken("mch_id").ToString();
                payRequest.Bill_TimeOut = jObject.SelectToken("bill_timeout").ToString();
                payRequest.Channel_Provider = jObject.SelectToken("channel_provider").ToString();
                payRequest.Channel_Code = jObject.SelectToken("channel_code").ToString();
                payRequest.Charset = jObject.SelectToken("charset").ToString();
                payRequest.Currency = jObject.SelectToken("currency").ToString();
                payRequest.Out_Trade_No = jObject.SelectToken("out_trade_no").ToString();
                payRequest.Sign_Type = jObject.SelectToken("sign_type").ToString();
                payRequest.Subject = jObject.SelectToken("subject").ToString();
                payRequest.TimeStamp = jObject.SelectToken("timestamp").ToString();
                payRequest.Total_Amt_Fen = jObject.SelectToken("total_amt_fen").ToString();
                payRequest.User_Ip = jObject.SelectToken("user_ip").ToString();
                payRequest.Version = jObject.SelectToken("version").ToString();
                payRequest.Notify_Url = jObject.SelectToken("notify_url").ToString();
                payRequest.Return_Url = jObject.SelectToken("return_url").ToString();

                if (jObject.SelectToken("merch_extra") != null)
                {
                    payRequest.Merch_Extra = jObject.SelectToken("merch_extra").ToString();
                }

                if (jObject.SelectToken("meta_option") != null)
                {
                    payRequest.Meta_Option = jObject.SelectToken("meta_option").ToString();
                }

                if (jObject.SelectToken("pay_option") != null)
                {
                    payRequest.Pay_Option = jObject.SelectToken("pay_option").ToString();
                }

                if (jObject.SelectToken("subject_detail") != null)
                {
                    payRequest.Subject_Detail = jObject.SelectToken("subject_detail").ToString();
                }

                if (jObject.SelectToken("user_identity") != null)
                {
                    payRequest.User_Identity = jObject.SelectToken("user_identity").ToString();
                }

                var payResponse = Heemoney.Heemoney.Pay(payRequest);

                string jsonData = MapperUtils.MapToJson<PayRequest>(payRequest);
                Response.Write(jsonData);
            }
        }

        private static string ReadStream(Stream stream)
        {
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}