namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="CountryMap" />
    /// </summary>
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryMap"/> class.
        /// </summary>
        public CountryMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Country_desc)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Country");
            this.Property(t => t.Identifier).HasColumnName("Country_num");
            this.Property(t => t.Country_desc).HasColumnName("Country_desc");
        }
    }
}
