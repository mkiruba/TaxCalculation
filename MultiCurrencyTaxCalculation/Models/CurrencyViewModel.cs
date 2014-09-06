using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiCurrencyTaxCalculation.Models
{
    public class CurrencyViewModel
    {
        public int CurrencyId { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyName { get; set; }
        public int CountryId { get; set; }
    }
}