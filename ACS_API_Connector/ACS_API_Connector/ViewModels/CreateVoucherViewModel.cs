using ACS_API_Connector.Models;
using ACS_API_Connector.Services;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Diagnostics;
using ACS_API_Connector.Views;
using System.Collections.Generic;

namespace ACS_API_Connector.ViewModels
{
    public class CreateVoucherViewModel : BaseViewModel
    {
        private ACSInputParameters inputParam;
        
        private string errormessage;
        public CreateVoucherViewModel() {
            inputParam = new ACSInputParameters();

            Request = new Command(() => CreateVoucher());
            Title = "Create Voucher";
        }

        public string Sender { set; get; }

        public string Recipient_Name {
            set => inputParam.Recipient_Name = value;
            get => inputParam.Recipient_Name;
        }

        public string Recipient_Address {
            set => inputParam.Recipient_Address = value;
            get => inputParam.Recipient_Address;
        }

        public int? Recipient_Address_Number {
            set => inputParam.Recipient_Address_Number = value;
            get => inputParam.Recipient_Address_Number;
        }

        public int? Recipient_Zipcode {
            set => inputParam.Recipient_Zipcode = value;
            get => inputParam.Recipient_Zipcode;
        }

        public string Recipient_Region {
            set => inputParam.Recipient_Region = value;
            get => inputParam.Recipient_Region;
        }

        public int? Phone {
            set => inputParam.Recipient_Phone = value;
            get => inputParam.Recipient_Phone;
        }

        public string ErrorMessage {
            set { errormessage = value; }
            get { return errormessage; }
        }


        private async void CreateVoucher() {
            inputParam.Company_ID = "998099182";
            inputParam.Company_Password = "3408";
            inputParam.User_ID = "suser";
            inputParam.User_Password = "3408";
            inputParam.Pickup_Date = "2020-05-26";
            inputParam.Recipient_Name = "VP";
            inputParam.Recipient_Address = "afas";
            inputParam.Recipient_Zipcode = 56123;
            inputParam.Recipient_Country = "GR";
            inputParam.Billing_Code = "2ΘΩ343608";
            inputParam.Charge_Type = 2;
            inputParam.Main_Voucher_No = "7228174940";

            ACSRequestModel VoucherRequest = new ACSRequestModel(inputParam);
            List<VoucherModel> VoucherList = await ACSAlias.ACSCreateVoucher(VoucherRequest);
        }
        public ICommand Request { set; get;}
    }
}
