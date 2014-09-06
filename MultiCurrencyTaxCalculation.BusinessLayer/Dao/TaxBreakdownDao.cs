using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCurrencyTaxCalculation.BusinessLayer.Dao
{
    public class TaxBreakdownDao
    {
        public decimal GrossPay { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxedAmount { get; set; }
        public decimal NetPay { get; set; }
    }
}
