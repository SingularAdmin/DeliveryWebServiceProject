using ACS_API_Connector.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACS_API_Connector.Services
{
    public interface IACSAlias
    {
        Task<ACSResponceModel> ACSAutoRestHelp(ACSRequestModel request);
        Task<ACSResponceModel> ACSCreateVoucher(ACSRequestModel request);
        Task<ACSResponceModel> ACSGetMultipartVoucher(ACSRequestModel request);
    }
}
