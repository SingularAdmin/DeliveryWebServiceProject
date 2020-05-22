using System;
using System.Collections.Generic;
using System.Text;

namespace ACS_API_Connector.Models
{
    public class ACSValueOutput
    {
        public ACSValueOutput() { }
        public ACSValueOutput(string Voucher_No,int? Voucher_No_Return, string Error_Message) {
            this.Voucher_No = Voucher_No;
            this.Voucher_No_Return = Voucher_No_Return;
            this.Error_Message = Error_Message;
        }
        public string Voucher_No { get; set; }
        public int? Voucher_No_Return { get; set; }
        public string Error_Message { get; set; }
    }
}
