namespace MultiCurrencyTaxCalculation.DataLayer.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Currency")]
    public partial class Currency
    {
        public int CurrencyId { get; set; }

        [StringLength(10)]
        public string CurrencySymbol { get; set; }

        public string CurrencyName { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
