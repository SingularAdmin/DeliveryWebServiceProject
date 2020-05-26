using ACS_API_Connector.Models;
using ACS_API_Connector.Views;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
     
        public Task<string> ACSAutoRestHelp(ACSRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<VoucherModel>> ACSCreateVoucher(ACSRequestModel request)
        {
            request.ACSAlias = "ACS_Create_Voucher";
            string response = await client.Request(JsonConvert.SerializeObject(request));
            JObject json = JObject.Parse(response);
            List<VoucherModel> VoucherList = JsonConvert.DeserializeObject<List<VoucherModel>>(json["ACSOutputResponce"]["ACSValueOutput"].ToString());
            return VoucherList;
        }

        public async Task<List<MultipartVouchersModel>> ACSGetMultipartVoucher(ACSRequestModel request)
        {
            request.ACSAlias = "ACS_Get_Multipart_Vouchers";
            string responce = await client.Request(JsonConvert.SerializeObject(request));
            JObject json = JObject.Parse(responce);
            string teststr = json["ACSOutputResponce"]["ACSTableOutput"]["Table_Data"].ToString();
            List<MultipartVouchersModel> multipartVouchers = JsonConvert.DeserializeObject<List<MultipartVouchersModel>>(json["ACSOutputResponce"]["ACSTableOutput"]["Table_Data"].ToString());
            return multipartVouchers;
        }
    }
}
