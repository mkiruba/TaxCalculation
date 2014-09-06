namespace MultiCurrencyTaxCalculation.DataLayer.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        public Country()
        {
            AdditionalTaxes = new HashSet<AdditionalTax>();
            Allowances = new HashSet<Allowance>();
            Currencies = new HashSet<Currency>();
            TaxCategories = new HashSet<TaxCategory>();
            TaxSlabs = new HashSet<TaxSlab>();
            TaxYears = new HashSet<TaxYear>();
        }

        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public virtual ICollection<AdditionalTax> AdditionalTaxes { get; set; }

        public virtual ICollection<Allowance> Allowances { get; set; }

        public virtual ICollection<Currency> Currencies { get; set; }

        public virtual ICollection<TaxCategory> TaxCategories { get; set; }

        public virtual ICollection<TaxSlab> TaxSlabs { get; set; }

        public virtual ICollection<TaxYear> TaxYears { get; set; }
    }
}
