using MultiCurrencyTaxCalculation.BusinessLayer;
using MultiCurrencyTaxCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MultiCurrencyTaxCalculation.Mapper;
using MultiCurrencyTaxCalculation.BusinessLayer.Dao;

namespace MultiCurrencyTaxCalculation.Controllers
{
    public class TaxController : ApiController
    {
        private ICurrencyService _currencyService;
        public TaxController() : this(new CurrencyService())
        {
        }

        public TaxController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;            
            AutoMapper.Mapper.CreateMap<CountryViewModel, CountryDao>();
            AutoMapper.Mapper.CreateMap<TaxYearViewModel, TaxYearDao>();
            AutoMapper.Mapper.CreateMap<TaxCategoryViewModel, TaxCategoryDao>();
            AutoMapper.Mapper.CreateMap<CurrencyViewModel, CurrencyDao>();
            AutoMapper.Mapper.CreateMap<TaxParameterViewModel, TaxParameterDao>();
            AutoMapper.Mapper.CreateMap<TaxBreakdownDao, TaxBreakdownViewModel>();
        }

        public TaxBreakdownViewModel Post([FromBody]TaxParameterViewModel taxParameter)
        {
            if (taxParameter.SalaryTerm == SalaryTerm.monthly)
                taxParameter.InputAmount *= 12;
            
            return _currencyService.CalculateTax(taxParameter.ToDao()).ToViewModel();
        }
    }
}
