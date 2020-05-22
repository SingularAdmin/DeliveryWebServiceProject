using System;
using System.Collections.Generic;
using System.Text;

namespace ACS_API_Connector.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Voucher
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
