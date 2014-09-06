namespace MultiCurrencyTaxCalculation.DataLayer.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdditionalTax")]
    public partial class AdditionalTax
    {
        public int AdditionalTaxId { get; set; }

        public string AdditionalTaxName { get; set; }

        public int? TaxRate { get; set; }

        public int CountryId { get; set; }

        public int TaxYearId { get; set; }

        public virtual Country Country { get; set; }

        public virtual TaxYear TaxYear { get; set; }
    }
}
