namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="StandardMap" />
    /// </summary>
    public class StandardMap : EntityTypeConfiguration<Standard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardMap"/> class.
        /// </summary>
        public StandardMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Standard_desc)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Standards");
            this.Property(t => t.Identifier).HasColumnName("Standard_num");
            this.Property(t => t.Standard_desc).HasColumnName("Standard_desc");
            this.Property(t => t.Standard_cat).HasColumnName("Standard_cat");
            this.Property(t => t.Standard_type).HasColumnName("Standard_type");
            this.Property(t => t.Standard_stat).HasColumnName("Standard_stat");
            this.Property(t => t.Standard_from_date).HasColumnName("Standard_from_date");
            this.Property(t => t.Standard_to_date).HasColumnName("Standard_to_date");
        }
    }
}
