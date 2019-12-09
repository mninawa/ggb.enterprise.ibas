namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="ProvinceMap" />
    /// </summary>
    public class ProvinceMap : EntityTypeConfiguration<Province>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvinceMap"/> class.
        /// </summary>
        public ProvinceMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Province_desc)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Province");
            this.Property(t => t.Identifier).HasColumnName("Province_num");
            this.Property(t => t.Province_desc).HasColumnName("Province_desc");
            this.Property(t => t.Prov_country_num).HasColumnName("Prov_country_num");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Provinces)
                .HasForeignKey(d => d.Prov_country_num);
        }
    }
}
