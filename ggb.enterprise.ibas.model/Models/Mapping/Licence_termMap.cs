namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Licence_termMap" />
    /// </summary>
    public class Licence_termMap : EntityTypeConfiguration<Licence_term>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence_termMap"/> class.
        /// </summary>
        public Licence_termMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Term_dict_num)
                .IsRequired()
 .HasMaxLength(10);

            this.Property(t => t.Term_desc)
                .IsRequired()
 .HasMaxLength(2500);

            this.Property(t => t.Term_reason)
                .IsRequired()
 .HasMaxLength(2500);

            // Table & Column Mappings
            this.ToTable("Licence_term");
            this.Property(t => t.Identifier).HasColumnName("Term_lic_num");
            this.Property(t => t.Term_num).HasColumnName("Term_num");
            this.Property(t => t.Term_type).HasColumnName("Term_type");
            this.Property(t => t.Term_dict_num).HasColumnName("Term_dict_num");
            this.Property(t => t.Term_desc).HasColumnName("Term_desc");
            this.Property(t => t.Term_reason).HasColumnName("Term_reason");
            this.Property(t => t.Term_stat).HasColumnName("Term_stat");
            this.Property(t => t.Term_start_date).HasColumnName("Term_start_date");
            this.Property(t => t.Term_end_date).HasColumnName("Term_end_date");

            // Relationships
            this.HasRequired(t => t.Licence)
                .WithOptional(t => t.Licence_term);
        }
    }
}
