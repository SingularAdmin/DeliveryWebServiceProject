using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ACS_API_Connector.Services;
using ACS_API_Connector.Views;
using ACS_API_Connector.Models;
using ACS_API_Connector.ViewModels;

namespace ACS_API_Connector
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<ACSAlias>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
