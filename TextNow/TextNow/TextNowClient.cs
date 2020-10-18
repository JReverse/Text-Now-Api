using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNow
{
    public class TextNowClient
    {
        public string Proxy { get; set; }
        public string ProxyUser { get; set; }
        public string ProxyPass { get; set; }
        public string app_version { get; set; } = "20.10.0";
        public string device_id { get; set; } = Guid.NewGuid().ToString();
        public string os_version { get; set; } = "12.4.8";

        public TextNowHttpClient HttpClient { get; private set; }
        public TextNowClient()
        {
            HttpClient = new TextNowHttpClient(this);
        }


        public TextNowClient(string proxy)
        {
            HttpClient = new TextNowHttpClient(this);
            Proxy = proxy;
        }

        public TextNowClient(bool userpassproxy, string proxy, string proxyuser, string proxypass)
        {
            HttpClient = new TextNowHttpClient(this);
            Proxy = proxy;
            if (userpassproxy)
            {
                ProxyUser = proxyuser;
                ProxyPass = proxypass;
            }
        }
    }
}
