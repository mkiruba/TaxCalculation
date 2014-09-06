using MultiCurrencyTaxCalculation.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCurrencyTaxCalculation.DataLayer.Repository
{
    public class DataRepository : IDataRepository
    {
        public IEnumerable<Currency> GetCurrencies()
        {
            using (var dbContext = new MoneyExchangeRateModel())
            {
                return dbContext.Currencies.ToList();
            }
        }

        public IEnumerable<Country> GetCountries()
        {
            using (var dbContext = new MoneyExchangeRateModel())
            {
                return dbContext.Countries.ToList();
            }
        }

        public IEnumerable<TaxCategory> GetTaxCategory(int countryId)
        {
            using (var dbContext = new MoneyExchangeRateModel())
            {
                return dbContext.TaxCategories.Where(x => x.CountryId == countryId).ToList();
            }
        }

        public IEnumerable<TaxYear> GetTaxYear(int countryId)
        {
            using (var dbContext = new MoneyExchangeRateModel())
            {
                return dbContext.TaxYears.Where(x => x.CountryId == countryId).ToList();
            }
        }

        public TaxSlab GetTaxRate(int countryId, int taxYearId, int taxCategoryId, decimal amount)
        {
            using (var dbContext = new MoneyExchangeRateModel())
            {
                return dbContext.TaxSlabs.Where(x => x.CountryId == countryId && x.TaxCategoryId == taxCategoryId &&
                    x.TaxYearId == taxYearId && amount >= x.SlabLowerLimit && amount <= x.SlabHigherLimit).Single();
            }
        }
    }
}
