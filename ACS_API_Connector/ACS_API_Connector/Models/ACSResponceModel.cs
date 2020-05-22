using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ACS_API_Connector.Models
{
    public class ACSResponceModel
    {
        [JsonProperty("ACSExcecution_HasError")]
        public bool ACSExcecution_HasError { get; set; }
        [JsonProperty("ACSExcecutionErrorMessage")]
        public string ACSExcecutionErrorMessage { get; set; }
        [JsonProperty("ACSOutputResponce")]
        public ACSOutputResponce ACSOutputResponce { get; set; }
    }
}
