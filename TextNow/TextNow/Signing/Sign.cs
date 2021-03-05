using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
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
            Dictionary<string, string> Algro = new Dictionary<string, string>
            {
                                 { "alg", "HS256" },
                                 { "typ", "JWT" },
            };
            Dictionary<string, object> DeviceParams = new Dictionary<string, object>
            {
                                 { "device_attested", true },
                                 { "device_id", Guid.NewGuid().ToString().ToUpper()},
                                 { "eligible_for_ads", true },
                                 { "exp",  rnd.Next(1000000000, 1999999999) },
                                 { "iat", rnd.Next(1000000000, 1999999999) },
                                 { "iss", "tn-integrity-service" },
                                 { "sub", "tn-integrity-service"},
            };

            return Base64Encode(JsonConvert.SerializeObject(Algro) + JsonConvert.SerializeObject(DeviceParams) + "3R3yMtpa~ie˟(6#");
        }

    }
}
