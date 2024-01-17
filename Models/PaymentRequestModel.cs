using Newtonsoft.Json;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace MobileMoney.POS.Integration.Client.Models
{

    public class PaymentRequestModel
    {
        [JsonProperty(PropertyName = "BusinessShortCode")]
        public string BusinessShortCode { get; set; }
        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "Timestamp")]
        public string Timestamp { get; set; }
        [JsonProperty(PropertyName = "TransactionType")]
        public string TransactionType { get; set; }
        [JsonProperty(PropertyName = "Amount")]
        public string Amount { get; set; }
        [JsonProperty(PropertyName = "PartyA")]
        public string PartyA { get; set; }
        [JsonProperty(PropertyName = "PartyB")]
        public string PartyB { get; set; }
        [JsonProperty(PropertyName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty(PropertyName = "CallBackURL")]
        public string CallBackURL { get; set; }
        [JsonProperty(PropertyName = "AccountReference")]
        public string AccountReference { get; set; }
        [JsonProperty(PropertyName = "TransactionDesc")]
        public string TransactionDesc { get; set; }
        [JsonProperty(PropertyName = "OriginIPAddress")]
        public string OriginIPAddress { get { return GetLocalIpAddress(); } }

        private string GetLocalIpAddress()
        {
            UnicastIPAddressInformation mostSuitableIp = null;

            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var network in networkInterfaces)
            {
                if (network.OperationalStatus != OperationalStatus.Up)
                    continue;

                var properties = network.GetIPProperties();

                if (properties.GatewayAddresses.Count == 0)
                    continue;

                foreach (var address in properties.UnicastAddresses)
                {
                    if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    if (IPAddress.IsLoopback(address.Address))
                        continue;

                    if (!address.IsDnsEligible)
                    {
                        if (mostSuitableIp == null)
                            mostSuitableIp = address;
                        continue;
                    }

                    // The best IP is the IP got from DHCP server
                    if (address.PrefixOrigin != PrefixOrigin.Dhcp)
                    {
                        if (mostSuitableIp == null || !mostSuitableIp.IsDnsEligible)
                            mostSuitableIp = address;
                        continue;
                    }

                    return address.Address.ToString();
                }
            }

            return mostSuitableIp != null
                ? mostSuitableIp.Address.ToString()
                : "";
        }
    }

}
