using Newtonsoft.Json;

namespace MobileMoney.POS.Integration.Client.Models
{
    public class TransactionDetailsModel
    {
        public TransactionDetailsModel() { }

        [JsonProperty(PropertyName = "TransactionDescription")]
        public string TransactionDescription { get; set; }

        [JsonProperty(PropertyName = "AmountReceived")]
        public string AmountReceived { get; set; }
        [JsonProperty(PropertyName = "MobileNo")]
        public string MobileNo { get; set; }
        [JsonProperty(PropertyName = "TransactionStatus")]
        public string TransactionStatus { get; set; }
        [JsonProperty(PropertyName = "TransactionRef")]
        public string TransactionRef { get; set; }
        [JsonProperty(PropertyName = "RecieptNo")]
        public string RecieptNo { get; set; }
        [JsonProperty(PropertyName = "OriginIPAddress")]
        public string OriginIPAddress { get; set; }

        public override string ToString()
        {
            return string.Format("TransactionRef: {0}, MobileNo: {1}, Transaction Status: {2}, Origin IP: {3}",
                TransactionRef, MobileNo, TransactionStatus, OriginIPAddress);
        }
    }
}
