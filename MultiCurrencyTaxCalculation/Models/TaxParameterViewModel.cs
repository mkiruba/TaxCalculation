using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiCurrencyTaxCalculation.Models
{
    public class TaxParameterViewModel
    {
        public CountryViewModel ExpatCountry { get; set; }
        public TaxYearViewModel TaxYear { get; set; }
        public TaxCategoryViewModel TaxCategory { get; set; }
        public decimal InputAmount { get; set; }
        public SalaryTerm SalaryTerm { get; set; }
        public CurrencyViewModel SourceCurrency { get; set; }
        public CurrencyViewModel TargetCurrency { get; set; }
    }

    public enum SalaryTerm
    {
        annually,
        monthly
    }
}