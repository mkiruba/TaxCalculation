using MultiCurrencyTaxCalculation.BusinessLayer;
using MultiCurrencyTaxCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using MultiCurrencyTaxCalculation.Mapper;
using System.Web.Http;
using MultiCurrencyTaxCalculation.BusinessLayer.Dao;

namespace MultiCurrencyTaxCalculation.Controllers
{
    public class CurrencyController : ApiController
    {
        private ICurrencyService _currencyService;
        public CurrencyController():this(new CurrencyService())
        {

        }
        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
            AutoMapper.Mapper.CreateMap<CurrencyDao, CurrencyViewModel>();
        }

        public IEnumerable<CurrencyViewModel> Get()
        {
            return _currencyService.GetCurrencies().Select(x => x.ToViewModel());
        }
        
    }
}
