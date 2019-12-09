namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="CityMap" />
    /// </summary>
    public class CityMap : EntityTypeConfiguration<City>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CityMap"/> class.
        /// </summary>
        public CityMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.City_desc)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("City");
            this.Property(t => t.Identifier).HasColumnName("City_num");
            this.Property(t => t.City_desc).HasColumnName("City_desc");
            this.Property(t => t.City_mun_num).HasColumnName("City_mun_num");
            this.Property(t => t.City_state_num).HasColumnName("City_state_num");

            // Relationships
            this.HasOptional(t => t.Municipality)
                .WithMany(t => t.Cities)
                .HasForeignKey(d => d.City_mun_num);
            this.HasOptional(t => t.State)
                .WithMany(t => t.Cities)
                .HasForeignKey(d => d.City_state_num);
        }
    }
}
