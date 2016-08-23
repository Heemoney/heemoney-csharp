using System;
using Newtonsoft.Json.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Heemoney;
using Heemoney.Utils;
using Heemoney.Models.Pay;
using System.Collections.Generic;

namespace HeemoneyTest
{
    [TestClass]
    public class PayTest
    {
        [TestMethod]
        public void Pay()
        {
            PayRequest payRequest = new PayRequest();
            payRequest.App_ID = HeemoneyConfig.APP_ID;
            payRequest.Mch_Id = HeemoneyConfig.MCH_ID;
            payRequest.Bill_TimeOut = "6";
            payRequest.Channel_Provider = "WeiXin";
            payRequest.Channel_Code = "WX_NATIVE";
            payRequest.Charset = "gb2312";
            payRequest.Currency = "CNY";
            payRequest.Out_Trade_No = DateTime.Now.ToString("yyyyMMddHHmmss"); ;
            payRequest.Sign_Type = "MD5";
            payRequest.Subject = "测试";
            payRequest.TimeStamp = HeemoneyUtils.GetTimeStamp(DateTime.Now).ToString();
            payRequest.Total_Amt_Fen = "1";
            payRequest.User_Ip = "127.0.0.1";
            payRequest.Version = "1";
            payRequest.Merch_Extra = "";
            payRequest.Meta_Option = "";
            payRequest.Pay_Option = "";
            payRequest.Subject_Detail = "";
            payRequest.User_Identity = "";
            payRequest.Notify_Url = "https://www.heemoney.com";
            payRequest.Return_Url = "https://www.heemoney.com";

            var payResponse = Heemoney.Heemoney.Pay(payRequest, true);
            string page_url = null;

            if (payResponse != null)
            {
                if (payResponse.Return_Code.Equals("SUCCESS"))
                {
                    if (payResponse.Err_Code.Equals("E0000"))
                    {
                        var jObject = JObject.Parse(payResponse.Hy_Pay_Extra);
                        page_url = JsonUtils.GetJsonStringValue(jObject, "page_url");
                    }
                }
            }

            Assert.IsNotNull(page_url);
        }
    }
}
