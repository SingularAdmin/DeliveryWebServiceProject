using ACS_API_Connector.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACS_API_Connector.Services
{
    class MockACSApi : IACSAlias
    {
        public Task<ACSResponceModel> ACSAutoRestHelp(ACSRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task<ACSResponceModel> ACSCreateVoucher(ACSRequestModel request)
        {
            await Task.Delay(1000);

            ACSResponceModel response = new ACSResponceModel();
            response.ACSExcecutionErrorMessage = "";
            response.ACSExcecution_HasError = false;
            List<ACSValueOutput> list = new List<ACSValueOutput> { new ACSValueOutput("7227889174", null, "") };
            response.ACSOutputResponce = new ACSOutputResponce(list, "");

            return response;
        }

        public Task<ACSResponceModel> ACSGetMultipartVoucher(ACSRequestModel request)
        {
            throw new NotImplementedException();
        }

        public void setAPIKey(string Key)
        {
            throw new NotImplementedException();
        }
    }
}
