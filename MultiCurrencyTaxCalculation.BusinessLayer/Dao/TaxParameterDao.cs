using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCurrencyTaxCalculation.BusinessLayer.Dao
{
    public class TaxParameterDao
    {
        public CountryDao ExpatCountry { get; set; }
        public TaxYearDao TaxYear { get; set; }
        public TaxCategoryDao TaxCategory { get; set; }
        public decimal InputAmount { get; set; }
        public CurrencyDao SourceCurrency { get; set; }
        public CurrencyDao TargetCurrency { get; set; }
    }
}
