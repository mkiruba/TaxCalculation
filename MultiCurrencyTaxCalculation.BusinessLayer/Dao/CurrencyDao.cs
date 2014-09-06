using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiCurrencyTaxCalculation.BusinessLayer.Dao
{
    public class CurrencyDao
    {
        public int CurrencyId { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyName { get; set; }
        public int CountryId { get; set; }
    }
}
