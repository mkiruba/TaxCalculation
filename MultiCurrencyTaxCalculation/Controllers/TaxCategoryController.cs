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
    public class TaxCategoryController : ApiController
    {
        private ICurrencyService _currencyService;
        public TaxCategoryController() : this(new CurrencyService())
        {
        }

        public TaxCategoryController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
            AutoMapper.Mapper.CreateMap<TaxCategoryDao, TaxCategoryViewModel>();
        }

        public IEnumerable<TaxCategoryViewModel> Get(int id)
        {
            return _currencyService.GetTaxCategory(id).Select(x => x.ToViewModel());
        }

    }
}
