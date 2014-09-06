using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiCurrencyTaxCalculation.Models
{
    public class TaxBreakdownViewModel
    {        
        public decimal GrossPay { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxedAmount { get; set; }
        public decimal NetPay { get; set; }
    }
}