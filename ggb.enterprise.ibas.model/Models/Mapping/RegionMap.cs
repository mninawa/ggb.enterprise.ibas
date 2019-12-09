namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="RegionMap" />
    /// </summary>
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionMap"/> class.
        /// </summary>
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Reg_desc)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Region");
            this.Property(t => t.Identifier).HasColumnName("Reg_num");
            this.Property(t => t.Reg_desc).HasColumnName("Reg_desc");
            this.Property(t => t.Reg_prov_num).HasColumnName("Reg_prov_num");
            this.Property(t => t.Reg_mun_num).HasColumnName("Reg_mun_num");

            // Relationships
            this.HasRequired(t => t.Municipality)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.Reg_mun_num);
            this.HasRequired(t => t.Province)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.Reg_prov_num);
        }
    }
}
