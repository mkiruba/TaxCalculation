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
    public class TaxYearController : ApiController
    {
        private ICurrencyService _currencyService;
        public TaxYearController() : this(new CurrencyService())
        {
        }

        public TaxYearController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
            AutoMapper.Mapper.CreateMap<TaxYearDao, TaxYearViewModel>();
        }

        public IEnumerable<TaxYearViewModel> GetTaxYear(int id)
        {
            return _currencyService.GetTaxYear(id).Select(x => x.ToViewModel());
        }
    }
}
