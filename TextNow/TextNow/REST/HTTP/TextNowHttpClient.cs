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

        public string ApiBaseEndpoint { get; set; } = "https://api.textnow.me/";

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
        public bool RetryOnRatelimit { get; private set; } = true;

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

        public TextNowHttpClient(TextNowClient snapchatClient)
        {
            _textnowClient = snapchatClient;
        }

        public async Task<HttpResponseMessage> Send(string endpoint, string method)
        {
            string posturl = null;
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
                    var content = new FormUrlEncodedContent(getParams());
                    if (method == "PUT")
                    {
                        response = await webClient.PutAsync(posturl, content);
                    }
                    else if (method == "POST")
                    {
                        response = await webClient.PostAsync(posturl, content);
                    }
                    else if (method == "GET")
                    {
                        response = await webClient.GetAsync(posturl);
                    }
                    ClearParams();
                    return response;
                }
                catch (Exception ex)
                {
                    if (RetryOnRatelimit)
                        Thread.Sleep(10000);
                    else
                        return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Failed", Encoding.UTF8, "text/plain") };
                }
            }
        }
    }
}
