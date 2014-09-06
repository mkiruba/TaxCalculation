namespace MultiCurrencyTaxCalculation.DataLayer.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxCategory")]
    public partial class TaxCategory
    {
        public TaxCategory()
        {
            TaxSlabs = new HashSet<TaxSlab>();
        }

        public int TaxCategoryId { get; set; }

        public string TaxCategoryName { get; set; }

        public int TaxYearId { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual TaxYear TaxYear { get; set; }

        public virtual ICollection<TaxSlab> TaxSlabs { get; set; }
    }
}
