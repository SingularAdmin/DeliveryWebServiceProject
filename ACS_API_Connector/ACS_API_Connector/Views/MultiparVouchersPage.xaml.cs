using ACS_API_Connector.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACS_API_Connector.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiparVouchersPage : ContentPage
    {
        public MultipartVouchersViewModel multipartViewModel;
        public MultiparVouchersPage()
        {
            InitializeComponent();
            BindingContext = multipartViewModel = new MultipartVouchersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (multipartViewModel.multipartVouchers.Count == 0)
                multipartViewModel.IsBusy = true;
        }

    }
}