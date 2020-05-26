using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace ACS_API_Connector.Models
{
#nullable enable
    public class ACSInputParameters
    {
        [Required]
        public string? Company_ID { get; set; }


        [Required]
        public string? Company_Password { get; set; }


        [Required]
        public string? User_ID { get; set; }


        [Required]
        public string? User_Password { get; set; }

        [Timestamp]
        public string? Pickup_Date { get; set; }


        public string? Sender { get; set; }

        public string? Recipient_Name { get; set; }
        public string? Recipient_Address { get; set; }
        public int? Recipient_Address_Number { get; set; }
        public int? Recipient_Zipcode { get; set; }
        public string? Recipient_Region { get; set; }

        [Phone]
        public int? Recipient_Phone { get; set; }
        public int? Recipient_Cell_Phone { get; set; }
        public int? Recipient_Floor { get; set; }
        public string? Recipient_Company_Name { get; set; }

        [EnumDataType(typeof(Country))]
        public string? Recipient_Country { get; set; }

        public double? Weight { get; set; }
        public double? Dimension_X_In_Cm { get; set; }
        public double? Dimension_Y_In_Cm { get; set; }
        public double? Dimension_Z_In_Cm { get; set; }

        public string Main_Voucher_No { get; set; }

        public int? Item_Quantity { get; set; }

        [EnumDataType(typeof(DeliveryProducts))]
        public string? Acs_Delivery_Products { get; set; }
        public string? Delivery_Notes { get; set; }
        public TimeSpan? Appointment_Until_Time { get; set; }
        public string? Reference_Key1 { get; set; }
        public string? Reference_Key2 { get; set; }
        public int? With_Return_Voucher { get; set; }
        public string? Billing_Code { get; set; }
        public int? Charge_Type { get; set; }
        public string? Cost_Center_Code { get; set; }
        public MailAddress? Recipient_Email { get; set; }
        public double? Cod_Ammount { get; set; }
        public int? Cod_Payment_Way { get; set; }
        public double? Insurance_Ammount { get; set; }

        public string? Language { get; set; }


    }
    public enum Country
    {
        GR, CY
    }

    public enum DeliveryProducts
    {
        MDV, INS, TDD, SAT, COD, RDO, REM, PRO, REC, CEC, P2P, D2P, P2D
    }
}
