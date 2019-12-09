namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="MunicipalityMap" />
    /// </summary>
    public class MunicipalityMap : EntityTypeConfiguration<Municipality>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MunicipalityMap"/> class.
        /// </summary>
        public MunicipalityMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Municipality_desc)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Municipality");
            this.Property(t => t.Identifier).HasColumnName("Municipality_num");
            this.Property(t => t.Municipality_desc).HasColumnName("Municipality_desc");
            this.Property(t => t.Mun_prov_num).HasColumnName("Mun_prov_num");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.Municipalities)
                .HasForeignKey(d => d.Mun_prov_num);
        }
    }
}
