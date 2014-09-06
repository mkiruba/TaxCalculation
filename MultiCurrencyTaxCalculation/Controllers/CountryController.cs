using MultiCurrencyTaxCalculation.BusinessLayer;
using MultiCurrencyTaxCalculation.BusinessLayer.Dao;
using MultiCurrencyTaxCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MultiCurrencyTaxCalculation.Mapper;

namespace MultiCurrencyTaxCalculation.Controllers
{
    public class CountryController : ApiController
    {
         private ICurrencyService _currencyService;
        public CountryController():this(new CurrencyService())
        {

        }
        public CountryController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
            AutoMapper.Mapper.CreateMap<CountryDao, CountryViewModel>();
        }

        public IEnumerable<CountryViewModel> Get()
        {
            return _currencyService.GetCountries().Select(x => x.ToViewModel());
        }
    }
}
