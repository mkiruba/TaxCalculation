namespace MultiCurrencyTaxCalculation.DataLayer.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxYear")]
    public partial class TaxYear
    {
        public TaxYear()
        {
            AdditionalTaxes = new HashSet<AdditionalTax>();
            Allowances = new HashSet<Allowance>();
            TaxCategories = new HashSet<TaxCategory>();
            TaxSlabs = new HashSet<TaxSlab>();
        }

        public int TaxYearId { get; set; }

        [Column("TaxYear")]
        public string TaxYear1 { get; set; }

        public int CountryId { get; set; }

        public virtual ICollection<AdditionalTax> AdditionalTaxes { get; set; }

        public virtual ICollection<Allowance> Allowances { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<TaxCategory> TaxCategories { get; set; }

        public virtual ICollection<TaxSlab> TaxSlabs { get; set; }
    }
}
