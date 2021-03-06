using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNow
{
    class TNTOKEN
    {
        [JsonProperty("integrity_session_token")]
        public string IST { get; set; }
    }
}
