using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Heemoney.Models.Query;
using Heemoney;
using Newtonsoft.Json.Linq;
using Heemoney.Utils;

namespace HeemoneyTest
{
    [TestClass]
    public class QueryTest
    {
        [TestMethod]
        public void Query()
        {
            QueryRequest queryRequest = new QueryRequest();
            queryRequest.Version = "1";
            queryRequest.App_ID = HeemoneyConfig.APP_ID;
            queryRequest.Mch_Id = HeemoneyConfig.MCH_ID;
            queryRequest.Charset = "gb2312";
            queryRequest.OutTradeNo = "";
            queryRequest.TimeStamp = HeemoneyUtils.GetTimeStamp(DateTime.Now).ToString();
            queryRequest.Sign_Type = "MD5";

            var queryResponse = Heemoney.Heemoney.Query(queryRequest);
            bool result = false;

            if (queryResponse != null)
            {
                if (queryResponse.Return_Code.Equals("SUCCESS"))
                {
                    if (queryResponse.Err_Code.Equals("E0000"))
                    {
                        result = true;
                    }
                }
            }

            Assert.IsTrue(result);
        }
    }
}
