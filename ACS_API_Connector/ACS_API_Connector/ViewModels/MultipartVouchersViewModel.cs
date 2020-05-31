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
using System.Collections.ObjectModel;

namespace ACS_API_Connector.ViewModels
{
    public class MultipartVouchersViewModel : BaseViewModel
    {
        public ObservableCollection<MultipartVouchersModel> multipartVouchers { get; set; }
        private readonly ACSInputParameters inputParam;
        public ICommand Request { set; get; }
        public ICommand SubmitMainVoucher { get; set; }
        public MultipartVouchersViewModel()
        {
            inputParam = new ACSInputParameters();
            multipartVouchers = new ObservableCollection<MultipartVouchersModel>();
            Request = new Command(async () => await getMultiparts());
            Title = "Multipart Vouchers";
        }

        public string MainVoucherNo {
            get => inputParam.Main_Voucher_No;
            set => inputParam.Main_Voucher_No = value;
        }

        private async Task getMultiparts()
        {
            IsBusy = true;
            
            try
            {
                multipartVouchers.Clear();
                inputParam.Company_ID = "";
                inputParam.Company_Password = "";
                inputParam.User_ID = "";
                inputParam.User_Password = "";
                inputParam.Pickup_Date = "2020-05-26";
                inputParam.Recipient_Name = "VP";
                inputParam.Recipient_Address = "afas";
                inputParam.Recipient_Zipcode = 56123;
                inputParam.Recipient_Country = "GR";
                inputParam.Billing_Code = "";
                inputParam.Charge_Type = 2;
                inputParam.Main_Voucher_No = "7228174940";

                ACSRequestModel VoucherRequest = new ACSRequestModel(inputParam);
                List<MultipartVouchersModel> multipartVouchersList = await ACSAlias.ACSGetMultipartVoucher(VoucherRequest);

                foreach (var multipart in multipartVouchersList)
                {
                    multipartVouchers.Add(multipart);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally {
                IsBusy = false;
            }
            
        }
    }
}
