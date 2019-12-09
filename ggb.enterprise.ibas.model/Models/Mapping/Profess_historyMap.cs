namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Profess_historyMap" />
    /// </summary>
    public class Profess_historyMap : EntityTypeConfiguration<Profess_history>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Profess_historyMap"/> class.
        /// </summary>
        public Profess_historyMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Institution)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Prof_year_comp)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("Profess_history");
            this.Property(t => t.Identifier).HasColumnName("Prof_pers_num");
            this.Property(t => t.Professional_num).HasColumnName("Professional_num");
            this.Property(t => t.Institution).HasColumnName("Institution");
            this.Property(t => t.Prof_type).HasColumnName("Prof_type");
            this.Property(t => t.Prof_start_date).HasColumnName("Prof_start_date");
            this.Property(t => t.Prof_end_date).HasColumnName("Prof_end_date");
            this.Property(t => t.Prof_year_comp).HasColumnName("Prof_year_comp");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Profess_history);
        }
    }
}
