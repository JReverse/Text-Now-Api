using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TextNow
{
    public static class Register
    {
        public static async Task RegisterAccount(this TextNowClient client, string username, string email, string password)
        {
            //TODO 
            // EXAMPLE
            Dictionary<string, object> step = new Dictionary<string, object>
            {
                                 { "bonus_info", new BonusInfo() },
                                 { "email", email },
                                 { "password", password },
                                 { "system_version", "12.4.8" },

            };
            await client.HttpClient.Send("users/" + username, "PUT", step);
        }
    }
}
