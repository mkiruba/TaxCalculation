namespace MultiCurrencyTaxCalculation.DataLayer.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MoneyExchangeRateModel : DbContext
    {
        public MoneyExchangeRateModel()
            : base("name=MoneyExchangeRateModel")
        {
        }

        public virtual DbSet<AdditionalTax> AdditionalTaxes { get; set; }
        public virtual DbSet<Allowance> Allowances { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaxCategory> TaxCategories { get; set; }
        public virtual DbSet<TaxSlab> TaxSlabs { get; set; }
        public virtual DbSet<TaxYear> TaxYears { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allowance>()
                .Property(e => e.AllowanceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.AdditionalTaxes)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Allowances)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Currencies)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.TaxCategories)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.TaxSlabs)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.TaxYears)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.CurrencySymbol)
                .IsFixedLength();

            modelBuilder.Entity<TaxCategory>()
                .HasMany(e => e.TaxSlabs)
                .WithRequired(e => e.TaxCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaxSlab>()
                .Property(e => e.SlabLowerLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TaxSlab>()
                .Property(e => e.SlabHigherLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TaxYear>()
                .HasMany(e => e.AdditionalTaxes)
                .WithRequired(e => e.TaxYear)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaxYear>()
                .HasMany(e => e.Allowances)
                .WithRequired(e => e.TaxYear)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaxYear>()
                .HasMany(e => e.TaxCategories)
                .WithRequired(e => e.TaxYear)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaxYear>()
                .HasMany(e => e.TaxSlabs)
                .WithRequired(e => e.TaxYear)
                .WillCascadeOnDelete(false);
        }
    }
}
