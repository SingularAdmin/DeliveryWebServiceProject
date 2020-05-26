using ACS_API_Connector.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACS_API_Connector.Services
{
    public interface IACSAlias
    {
        Task<string> ACSAutoRestHelp(ACSRequestModel request);
        Task<List<VoucherModel>> ACSCreateVoucher(ACSRequestModel request);
        Task<List<MultipartVouchersModel>> ACSGetMultipartVoucher(ACSRequestModel request);
    }
}
