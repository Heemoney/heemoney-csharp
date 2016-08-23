#Heemoney CSharp SDK
### 版本要求 ###
.net framework最低3.5以上
### 接入方法 ###
#### 支付 ####
    PayResponse payResponse=Heemoney.Pay(PayRequest payRequest);
#### 查询 ####
    QueryResponse queryResponse=Heemoney.Query(QueryRequest queryRequest);
#### 退款 ####
    RefundResponse refundResponse=Heemoney.Refund(RefundRequest refundRequest);
