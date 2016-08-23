using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Heemoney.Common;
using Heemoney.Models;
using Heemoney.Utils;
using Heemoney.Models.Pay;
using Heemoney.Models.Refund;
using Heemoney.Models.Query;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace Heemoney
{
    public class Heemoney
    {
        public static PayResponse Pay(PayRequest payRequest)
        {
            return Pay(payRequest, false);
        }

        public static PayResponse Pay(PayRequest payRequest, bool isTest)
        {
            PayResponse payResponse;
            try
            {
                string jsonData = MapperUtils.MapToJson<PayRequest>(payRequest);
                string requestData = HeemoneyUtils.GetRequestData(jsonData);
                string payUrl = isTest ? HeemoneyConfig.PAY_Test_URL : HeemoneyConfig.PAY_URL;

                payUrl = HeemoneyConfig.Host + HeemoneyConfig.Version + payUrl;

                var response = HttpService.Post(payUrl, requestData, HeemoneyConfig.TIME_OUT);
                var responseData = HttpService.GetResponseString(response);
                payResponse = MapperUtils.JsonToMap<PayResponse>(responseData);

                payResponse.RequestUrl = payUrl;
                payResponse.RequestData = requestData;
                payResponse.ResponseData = responseData;
            }
            catch (Exception ex)
            {
                throw new HeemoneyException(ex.Message);
            }
            return payResponse;
        }

        public static QueryResponse Query(QueryRequest queryRequest)
        {
            QueryResponse queryResponse;
            try
            {
                string jsonData = MapperUtils.MapToJson<QueryRequest>(queryRequest);
                string requestData = HeemoneyUtils.GetRequestData(jsonData);

                string queryUrl = HeemoneyConfig.Host + HeemoneyConfig.Version + HeemoneyConfig.Query_URL;

                var response = HttpService.Post(queryUrl, requestData, HeemoneyConfig.TIME_OUT);
                var responseData = HttpService.GetResponseString(response);
                queryResponse = MapperUtils.JsonToMap<QueryResponse>(responseData);

                queryResponse.RequestUrl = queryUrl;
                queryResponse.RequestData = requestData;
                queryResponse.ResponseData = responseData;
            }
            catch (Exception ex)
            {
                throw new HeemoneyException(ex.Message);
            }
            return queryResponse;
        }

        public static RefundResponse Refund(RefundRequest payRequest)
        {
            RefundResponse refundResponse;
            try
            {
                string jsonData = MapperUtils.MapToJson<RefundRequest>(payRequest);
                string requestData = HeemoneyUtils.GetRequestData(jsonData);

                string refundUrl = HeemoneyConfig.Host + HeemoneyConfig.Version + HeemoneyConfig.Refund_URL;

                var response = HttpService.Post(refundUrl, requestData, HeemoneyConfig.TIME_OUT);
                var responseData = HttpService.GetResponseString(response);
                refundResponse = MapperUtils.JsonToMap<RefundResponse>(responseData);

                refundResponse.RequestUrl = refundUrl;
                refundResponse.RequestData = requestData;
                refundResponse.ResponseData = responseData;
            }
            catch (Exception ex)
            {
                throw new HeemoneyException(ex.Message);
            }
            return refundResponse;
        }
    }
}
