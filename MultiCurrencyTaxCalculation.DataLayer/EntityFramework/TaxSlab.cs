namespace MultiCurrencyTaxCalculation.DataLayer.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxSlab")]
    public partial class TaxSlab
    {
        public int TaxSlabId { get; set; }

        [Column(TypeName = "money")]
        public decimal? SlabLowerLimit { get; set; }

        [Column(TypeName = "money")]
        public decimal? SlabHigherLimit { get; set; }

        public int? TaxRate { get; set; }

        public int TaxCategoryId { get; set; }

        public int TaxYearId { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual TaxCategory TaxCategory { get; set; }

        public virtual TaxYear TaxYear { get; set; }
    }
}
