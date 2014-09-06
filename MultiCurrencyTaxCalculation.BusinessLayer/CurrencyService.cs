using MultiCurrencyTaxCalculation.BusinessLayer.Dao;
using MultiCurrencyTaxCalculation.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiCurrencyTaxCalculation.BusinessLayer.Mapper;
using MultiCurrencyTaxCalculation.DataLayer.EntityFramework;

namespace MultiCurrencyTaxCalculation.BusinessLayer
{
    public class CurrencyService : ICurrencyService
    {
        private IDataRepository _dataRepository;
        public CurrencyService():this(new DataRepository())
        {

        }
        public CurrencyService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
            AutoMapper.Mapper.CreateMap<Currency, CurrencyDao>();
            AutoMapper.Mapper.CreateMap<Country, CountryDao>();
        }

        public IEnumerable<CurrencyDao> GetCurrencies()
        {
            return _dataRepository.GetCurrencies().Select(x => x.ToDto());
        }

        public IEnumerable<CountryDao> GetCountries()
        {
            return _dataRepository.GetCountries().Select(x => x.ToDto());
        }

        public IEnumerable<TaxCategoryDao> GetTaxCategory(int countryId)
        {
            return _dataRepository.GetTaxCategory(countryId).Select(x => new TaxCategoryDao() { TaxCategoryId = x.TaxCategoryId, TaxCategoryName = x.TaxCategoryName });
        }

        public IEnumerable<TaxYearDao> GetTaxYear(int countryId)
        {
            return _dataRepository.GetTaxYear(countryId).Select(x => new TaxYearDao() { TaxYearId = x.TaxYearId, TaxYear= x.TaxYear1 });
        }

        public TaxBreakdownDao CalculateTax(TaxParameterDao taxParameter)
        {
            decimal calculatedTax = 0.00M;
            var taxRate = _dataRepository.GetTaxRate(taxParameter.ExpatCountry.CountryId, taxParameter.TaxYear.TaxYearId,
                taxParameter.TaxCategory.TaxCategoryId, taxParameter.InputAmount);

            calculatedTax = taxParameter.InputAmount * (taxRate.TaxRate.Value / 100M);
            return new TaxBreakdownDao() { GrossPay = taxParameter.InputAmount, TaxRate = taxRate.TaxRate.Value, TaxedAmount = calculatedTax, NetPay = taxParameter.InputAmount - calculatedTax };
        }


    }
}

