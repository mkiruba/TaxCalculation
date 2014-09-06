using MultiCurrencyTaxCalculation.BusinessLayer.Dao;
using MultiCurrencyTaxCalculation.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCurrencyTaxCalculation.BusinessLayer
{
    public interface ICurrencyService
    {
        IEnumerable<CurrencyDao> GetCurrencies();
        IEnumerable<CountryDao> GetCountries();
        IEnumerable<TaxCategoryDao> GetTaxCategory(int countryId);
        IEnumerable<TaxYearDao> GetTaxYear(int countryId);
        TaxBreakdownDao CalculateTax(TaxParameterDao taxParameter);
    }
}
