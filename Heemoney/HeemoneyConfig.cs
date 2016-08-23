using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Heemoney
{
    public class HeemoneyConfig
    {
        //=======【基本信息设置】=====================================
        /* 汇收银商户信息配置
         * APP_ID：汇收银应用ID
         * MCH_ID：汇收银商户号
         * KEY：汇收银支付密钥
        */
        public const string APP_ID = "";
        public const string MCH_ID = "";
        public const string KEY = "";

        //=======【Host设置】===================================== 
        public const string Host = "";
        public const string Version = "/api/v1";

        //=======【支付请求url】===================================== 
        public const string PAY_URL = "/pay";
        public const string PAY_Test_URL = "/test";
        public const string Query_URL = "/query";
        public const string Refund_URL = "/refund";

        //=======【超时时间设置】===================================== 
        public const int TIME_OUT = 60000;
    }
}
