namespace MultiCurrencyTaxCalculation.DataLayer.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Allowance")]
    public partial class Allowance
    {
        public int AllowanceId { get; set; }

        public string AllowanceName { get; set; }

        public int? AllowanceRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceAmount { get; set; }

        public int TaxYearId { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual TaxYear TaxYear { get; set; }
    }
}
