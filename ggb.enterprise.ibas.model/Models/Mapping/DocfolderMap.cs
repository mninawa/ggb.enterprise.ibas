namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="DocfolderMap" />
    /// </summary>
    public class DocfolderMap : EntityTypeConfiguration<Docfolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocfolderMap"/> class.
        /// </summary>
        public DocfolderMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
 //           this.Property(t => t.Folder)
 //               .IsRequired()
 //.IsFixedLength()
 //.HasMaxLength(32);

            this.Property(t => t.Docfold_desc)
                .IsRequired()
 .HasMaxLength(2000);

            this.Property(t => t.Hierarchy_ids)
                .IsRequired()
 .HasMaxLength(500);

            this.Property(t => t.Summary)
                .IsRequired()
 .IsFixedLength()
 .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Docfolder");
            this.Property(t => t.Identifier).HasColumnName("Folder");
            this.Property(t => t.Docfold_desc).HasColumnName("Docfold_desc");
            this.Property(t => t.Hierarchy_ids).HasColumnName("Hierarchy_ids");
            this.Property(t => t.Summary).HasColumnName("Summary");
        }
    }
}
