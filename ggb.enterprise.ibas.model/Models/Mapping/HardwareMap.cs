namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="HardwareMap" />
    /// </summary>
    public class HardwareMap : EntityTypeConfiguration<Hardware>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareMap"/> class.
        /// </summary>
        public HardwareMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Hardware_name)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hardware");
            this.Property(t => t.Identifier).HasColumnName("Hardware_num");
            this.Property(t => t.Hardware_name).HasColumnName("Hardware_name");
            this.Property(t => t.Cab_manufact_date).HasColumnName("Cab_manufact_date");
            this.Property(t => t.Hardware_cat).HasColumnName("Hardware_cat");
            this.Property(t => t.Hardware_type).HasColumnName("Hardware_type");
            this.Property(t => t.Hardware_stat).HasColumnName("Hardware_stat");
            this.Property(t => t.Hardware_from_date).HasColumnName("Hardware_from_date");
            this.Property(t => t.Hardware_to_date).HasColumnName("Hardware_to_date");
        }
    }
}
