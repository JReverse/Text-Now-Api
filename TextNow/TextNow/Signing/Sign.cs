using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TextNow
{
    public class Sign
    {
        private Random rnd = new Random();
        private Random random = new Random();

        private readonly TextNowClient _textnowClient;

        public Sign(TextNowClient textnowClient)
        {
            _textnowClient = textnowClient;
        }

        public string GetEmbyST()
        {
            return rnd.Next(1000000000, 1999999999).ToString();
        }

        public string GetEmbyID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GetIntegritySession()
        {
            return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkZXZpY2VfYXR0ZXN0ZWQiOnRydWUsImRldmljZV9pZCI6IjAwRDEyNjU5LUYxMkUtNEM3Qy1BRkYxLUI5MjRDMzM3MkJBRSIsImVsaWdpYmxlX2Zvcl9hZHMiOnRydWUsImV4cCI6MTYxNTE2MzcwMCwiaWF0IjoxNjE0OTkwOTAwLCJpc3MiOiJ0bi1pbnRlZ3JpdHktc2VydmljZSIsInN1YiI6InRuLWludGVncml0eS1zZXNzaW9uIn0.oOIIFKY-_DUGOlNjJow3vwqy81fSmk5M1ivJNspyBGU";
        }
    }
}
