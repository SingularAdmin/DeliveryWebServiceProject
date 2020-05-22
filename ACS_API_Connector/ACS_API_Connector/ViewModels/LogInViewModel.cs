using ACS_API_Connector.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ACS_API_Connector.ViewModels
{
    public class LogInViewModel : BaseViewModel
    {
        private string companyID;
        private string companyPasswd;
        private string userID;
        private string userPasswd;

        public LogInViewModel() {
            companyID = "";
            companyPasswd = "";
            userID = "";
            userPasswd = "";

            LogIn = new Command(() => {
            });
        }

        public ICommand LogIn { get; set; }

        public string CompanyID
        {
            set { companyID = value; }
        }

        [PasswordPropertyText(true)]
        public string CompanyPassword
        {
            set { companyPasswd = value; }
        }

        public string UserID
        {
            set { userID = value; }
            get { return userID; }
        }

        [PasswordPropertyText(true)]
        public string UserPassword
        {
            set { userPasswd = value; }
            get { return userPasswd; }
        }

    }
}
