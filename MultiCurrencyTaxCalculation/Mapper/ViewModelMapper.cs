using MultiCurrencyTaxCalculation.BusinessLayer.Dao;
using MultiCurrencyTaxCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiCurrencyTaxCalculation.Mapper
{
    public static class ViewModelMapper
    {
        public static CurrencyDao ToDao(this CurrencyViewModel vm)
        {
            return AutoMapper.Mapper.Map<CurrencyViewModel, CurrencyDao>(vm);
        }

        public static CurrencyViewModel ToViewModel(this CurrencyDao dao)
        {
            return AutoMapper.Mapper.Map<CurrencyDao, CurrencyViewModel>(dao);
        }

        public static CountryDao ToDao(this CountryViewModel vm)
        {
            return AutoMapper.Mapper.Map<CountryViewModel, CountryDao>(vm);
        }

        public static CountryViewModel ToViewModel(this CountryDao dao)
        {
            return AutoMapper.Mapper.Map<CountryDao, CountryViewModel>(dao);
        }

        public static TaxCategoryDao ToDao(this TaxCategoryViewModel vm)
        {
            return AutoMapper.Mapper.Map<TaxCategoryViewModel, TaxCategoryDao>(vm);
        }

        public static TaxCategoryViewModel ToViewModel(this TaxCategoryDao dao)
        {
            return AutoMapper.Mapper.Map<TaxCategoryDao, TaxCategoryViewModel>(dao);
        }

        public static TaxYearDao ToDao(this TaxYearViewModel vm)
        {
            return AutoMapper.Mapper.Map<TaxYearViewModel, TaxYearDao>(vm);
        }

        public static TaxYearViewModel ToViewModel(this TaxYearDao dao)
        {
            return AutoMapper.Mapper.Map<TaxYearDao, TaxYearViewModel>(dao);
        }

        public static TaxParameterDao ToDao(this TaxParameterViewModel dao)
        {
            return AutoMapper.Mapper.Map<TaxParameterViewModel, TaxParameterDao>(dao);
        }

        public static TaxBreakdownViewModel ToViewModel(this TaxBreakdownDao dao)
        {
            return AutoMapper.Mapper.Map<TaxBreakdownDao, TaxBreakdownViewModel>(dao);
        }
    }
}