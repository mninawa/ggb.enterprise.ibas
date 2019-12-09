namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Base_OSMap" />
    /// </summary>
    public class Base_OSMap : EntityTypeConfiguration<Base_OS>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Base_OSMap"/> class.
        /// </summary>
        public Base_OSMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Base_OS_operating_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Base_OS_value)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Base_OS");
            this.Property(t => t.Identifier).HasColumnName("Base_OS_operating_number");
            this.Property(t => t.Base_OS_operating_name).HasColumnName("Base_OS_operating_name");
            this.Property(t => t.Base_OS_cat).HasColumnName("Base_OS_cat");
            this.Property(t => t.Base_OS_type).HasColumnName("Base_OS_type");
            this.Property(t => t.Base_OS_stat).HasColumnName("Base_OS_stat");
            this.Property(t => t.Base_OS_from_date).HasColumnName("Base_OS_from_date");
            this.Property(t => t.Base_OS_to_date).HasColumnName("Base_OS_to_date");
            this.Property(t => t.Base_OS_value).HasColumnName("Base_OS_value");
        }
    }
}
