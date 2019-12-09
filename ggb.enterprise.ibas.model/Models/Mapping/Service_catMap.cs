namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Service_catMap" />
    /// </summary>
    public class Service_catMap : EntityTypeConfiguration<Service_cat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service_catMap"/> class.
        /// </summary>
        public Service_catMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Sub_cap)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Service_type)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Service)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Service_cat");
            this.Property(t => t.Identifier).HasColumnName("Service_cat_num");
            this.Property(t => t.Serv_depart).HasColumnName("Serv_depart");
            this.Property(t => t.Sub_cap).HasColumnName("Sub_cap");
            this.Property(t => t.Service_type).HasColumnName("Service_type");
            this.Property(t => t.Service).HasColumnName("Service");
            this.Property(t => t.Service_cat1).HasColumnName("Service_cat");
        }
    }
}
