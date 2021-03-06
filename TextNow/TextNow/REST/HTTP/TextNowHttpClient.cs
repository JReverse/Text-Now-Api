using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextNow
{
    public class TextNowHttpClient
    {
        private readonly TextNowClient _textnowClient;

        public string ApiBaseEndpoint { get; set; } = "https://api.textnow.me/api2.0/";

        public string Proxy
        {
            get { return _textnowClient.Proxy; }
        }

        public string ProxyUser
        {
            get { return _textnowClient.ProxyUser; }
        }

        public string ProxyPass
        {
            get { return _textnowClient.ProxyPass; }
        }

        public Dictionary<string, string> Param { get; set; } = new Dictionary<string, string>();
        public MultipartFormDataContent MultiParam { get; set; } = new MultipartFormDataContent();
        public void addParam(string key, string value)
        {
            Param.Add(key, value);
        }
        public void addMultiParam(StringContent stream, string name)
        {
            MultiParam.Add(stream, name);
        }
        public void addFileMultiParam(StreamContent stream, string name, string filename)
        {
            MultiParam.Add(stream, name, filename);
        }

        public void ClearParams()
        {
            Param.Clear();
        }

        public Dictionary<string, string> getParams()
        {
            return Param;
        }

        public TextNowHttpClient(TextNowClient textnowClient)
        {
            _textnowClient = textnowClient;
        }

        public async Task<HttpResponseMessage> Send(string endpoint, string method, Dictionary<string, object> serialz)
        {
            string posturl = ApiBaseEndpoint + endpoint + "?client_type=TN_IOS_FREE&idfa=" + Guid.NewGuid().ToString() + "&idfv=" + Guid.NewGuid.ToString();
            HttpClient webClient;
            if (Proxy != null)
            {
                webClient = new HttpClient(new HttpClientHandler
                {
                    Proxy = new WebProxy(Proxy, true, null, new NetworkCredential(ProxyUser, ProxyPass)),
                    UseProxy = true
                });
            }
            else
            {
                webClient = new HttpClient(new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                });
            }
            while (true)
            {
                HttpResponseMessage response = null;
                try
                {
                    webClient.DefaultRequestHeaders.TryAddWithoutValidation("x-emb-st", _textnowClient.Signer.GetEmbyST());
                    webClient.DefaultRequestHeaders.TryAddWithoutValidation("X-TN-Integrity-Session", _textnowClient.IntegritySession);
                    webClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "TextNow/21.8.0 (iPhone7,2; iOS 12.4.8; Scale/2.00)");
                    webClient.DefaultRequestHeaders.TryAddWithoutValidation("x-emb-id", _textnowClient.Signer.GetEmbyID(32));
                    if (method == "PUT")
                    {
                        response = await webClient.PutAsync(posturl, new StringContent(JsonConvert.SerializeObject(serialz), UTF8Encoding.UTF8, "application/json"));
                    }
                    else if (method == "POST")
                    {
                        response = await webClient.PostAsync(posturl, new StringContent(JsonConvert.SerializeObject(serialz), UTF8Encoding.UTF8, "application/json"));
                    }
                    else if (method == "GET")
                    {
                        response = await webClient.GetAsync(posturl);
                    }
                    ClearParams();
                    return response;
                }
                catch (Exception)
                {
                    return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Failed", Encoding.UTF8, "text/plain") };
                }
            }
        }
    }
}
