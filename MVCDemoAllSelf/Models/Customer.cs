using System;
using System.ComponentModel.DataAnnotations;

namespace MVCDemoAllSelf.Models
{
    public class Customer
    {
        [Required]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerDisplayName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerWebsite { get; set; }
        public string CusotmerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CusotmerPostalCode { get; set; }
        public string CustomerState { get; set; }
        public string CusotmerCountry { get; set; }
        public string CustomerTaxRegNo { get; set; }
        public string CustomerCstNo { get; set; }
        public string CustomerPanNo { get; set; }
        public double? CustomerOpeningBalance { get; set; }
        public DateTime CustomerOpeningBalanceDate { get; set; }
        public bool CustomerIsActive { get; set; }

    }
}