namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="sysdiagramMap" />
    /// </summary>
    public class sysdiagramMap : EntityTypeConfiguration<sysdiagram>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="sysdiagramMap"/> class.
        /// </summary>
        public sysdiagramMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
 .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("sysdiagrams");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.principal_id).HasColumnName("principal_id");
            this.Property(t => t.Identifier).HasColumnName("diagram_id");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.definition).HasColumnName("definition");
        }
    }
}
