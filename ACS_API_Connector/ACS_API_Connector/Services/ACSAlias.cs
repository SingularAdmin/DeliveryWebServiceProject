using ACS_API_Connector.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ACS_API_Connector.Services
{
    public class ACSAlias : IACSAlias
    {
        private ACSRestAPIClient client;

        public ACSAlias() {
            client = new ACSRestAPIClient();
        }
        public ACSAlias(string Key) {
            client = new ACSRestAPIClient(Key);
        }
     
        public Task<ACSResponceModel> ACSAutoRestHelp(ACSRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task<ACSResponceModel> ACSCreateVoucher(ACSRequestModel ValidatedRequest)
        {
            ValidatedRequest.ACSAlias = "ACS_Create_Voucher";
            string response = await client.Request(JsonConvert.SerializeObject(ValidatedRequest));
            return JsonConvert.DeserializeObject<ACSResponceModel>(response);
        }

        public Task<ACSResponceModel> ACSGetMultipartVoucher(ACSRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
