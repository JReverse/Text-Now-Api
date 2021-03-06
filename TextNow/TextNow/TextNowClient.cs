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
        public string app_version { get; set; } = "21.8.0";
        public string device_id { get; set; } = Guid.NewGuid().ToString();
        public string os_version { get; set; } = "12.4.8";
        public string IntegritySession { get; set; }
        public Sign Signer { get; private set; }
        public TextNowHttpClient HttpClient { get; private set; }
        public TextNowClient()
        {
            HttpClient = new TextNowHttpClient(this);
            Signer = new Sign(this);
            IntegritySession = Signer.GetIntegritySession();
        }


        public TextNowClient(string proxy)
        {
            HttpClient = new TextNowHttpClient(this);
            Signer = new Sign(this);
            Proxy = proxy;
            IntegritySession = Signer.GetIntegritySession();
        }

        public TextNowClient(bool userpassproxy, string proxy, string proxyuser, string proxypass)
        {
            HttpClient = new TextNowHttpClient(this);
            Signer = new Sign(this);
            IntegritySession = Signer.GetIntegritySession();
            Proxy = proxy;
            if (userpassproxy)
            {
                ProxyUser = proxyuser;
                ProxyPass = proxypass;
            }
        }
    }
}
