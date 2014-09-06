using MultiCurrencyTaxCalculation.BusinessLayer.Dao;
using MultiCurrencyTaxCalculation.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCurrencyTaxCalculation.BusinessLayer.Mapper
{
    public static class MapperDto
    {
        public static CurrencyDao ToDto(this Currency entity)
        {
            return AutoMapper.Mapper.Map<Currency, CurrencyDao>(entity);
        }

        public static Currency ToEntity(this CurrencyDao dto)
        {
            return AutoMapper.Mapper.Map<CurrencyDao, Currency>(dto);
        }

        public static CountryDao ToDto(this Country entity)
        {
            return AutoMapper.Mapper.Map<Country, CountryDao>(entity);
        }

        public static Country ToEntity(this CountryDao dto)
        {
            return AutoMapper.Mapper.Map<CountryDao, Country>(dto);
        }

        public static TaxCategoryDao ToDto(this TaxCategory entity)
        {
            return AutoMapper.Mapper.Map<TaxCategory, TaxCategoryDao>(entity);
        }

        public static TaxCategory ToEntity(this TaxCategoryDao dto)
        {
            return AutoMapper.Mapper.Map<TaxCategoryDao, TaxCategory>(dto);
        }

        public static TaxYearDao ToDto(this TaxYear entity)
        {
            return AutoMapper.Mapper.Map<TaxYear, TaxYearDao>(entity);
        }

        public static TaxYear ToEntity(this TaxYearDao dto)
        {
            return AutoMapper.Mapper.Map<TaxYearDao, TaxYear>(dto);
        }
    }
}
