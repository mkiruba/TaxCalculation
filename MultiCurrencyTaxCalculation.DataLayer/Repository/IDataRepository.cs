using MultiCurrencyTaxCalculation.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCurrencyTaxCalculation.DataLayer.Repository
{
    public interface IDataRepository
    {
        IEnumerable<Currency> GetCurrencies();
        IEnumerable<Country> GetCountries();
        IEnumerable<TaxCategory> GetTaxCategory(int countryId);
        IEnumerable<TaxYear> GetTaxYear(int countryId);
        TaxSlab GetTaxRate(int countryId, int taxYearId, int taxCategoryId, decimal amount);
    }
}
