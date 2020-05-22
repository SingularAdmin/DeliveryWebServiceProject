using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACS_API_Connector.Models
{
    public class ACSOutputResponce
    {
        public ACSOutputResponce() { }
        public ACSOutputResponce(List<ACSValueOutput> list, string table) {
            ACSValueOutput = list;
            ACSTableOutput = table;
        }
        [JsonProperty("ACSValueOutput")]
        public List<ACSValueOutput> ACSValueOutput { get; set; }
        [JsonProperty("ACSTableOutput")]
        public object ACSTableOutput { get; set; }
    }
}
