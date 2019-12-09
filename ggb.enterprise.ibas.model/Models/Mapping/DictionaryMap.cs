namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="DictionaryMap" />
    /// </summary>
    public class DictionaryMap : EntityTypeConfiguration<Dictionary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryMap"/> class.
        /// </summary>
        public DictionaryMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Dictionary_desc)
                .IsRequired()
 .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Dictionary");
            this.Property(t => t.Identifier).HasColumnName("Dictionary_id");
            this.Property(t => t.Dictionary_cat).HasColumnName("Dictionary_cat");
            this.Property(t => t.Dictionary_type).HasColumnName("Dictionary_type");
            this.Property(t => t.Dictionary_desc).HasColumnName("Dictionary_desc");
            this.Property(t => t.Dictionary_stat).HasColumnName("Dictionary_stat");
        }
    }
}
