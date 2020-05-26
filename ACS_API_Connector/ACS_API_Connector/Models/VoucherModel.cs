using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACS_API_Connector.Models
{
    public class VoucherModel
    {
        public string Voucher_No { get; set; }
        public int? Voucher_No_Return { get; set; }
        public string Error_Message { get; set; }
    }
}
