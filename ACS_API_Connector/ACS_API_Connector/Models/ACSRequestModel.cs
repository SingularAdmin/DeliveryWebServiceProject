using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACS_API_Connector.Models
{
    public class ACSRequestModel
    {
        public ACSRequestModel() {
            ACSInputParameters = new ACSInputParameters();
        }
        public ACSRequestModel(ACSInputParameters ACSInputParameters) {
            this.ACSInputParameters = ACSInputParameters;
        }

        [JsonProperty("ACSAlias")]
        public string ACSAlias { get; set; }
        [JsonProperty("ACSInputParameters")]
        public ACSInputParameters ACSInputParameters { get; set; }
    }
}
