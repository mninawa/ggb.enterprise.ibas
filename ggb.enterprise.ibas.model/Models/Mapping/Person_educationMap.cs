namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Person_educationMap" />
    /// </summary>
    public class Person_educationMap : EntityTypeConfiguration<Person_education>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_educationMap"/> class.
        /// </summary>
        public Person_educationMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Ed_institution)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Qual_desc)
                .HasMaxLength(50);

            this.Property(t => t.Educ_year_comp)
                .IsRequired()
 .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("Person_education");
            this.Property(t => t.Identifier).HasColumnName("Educ_pers_num");
            this.Property(t => t.Ed_institution).HasColumnName("Ed_institution");
            this.Property(t => t.Qual_type).HasColumnName("Qual_type");
            this.Property(t => t.Qual_desc).HasColumnName("Qual_desc");
            this.Property(t => t.Educ_start_date).HasColumnName("Educ_start_date");
            this.Property(t => t.Educ_end_date).HasColumnName("Educ_end_date");
            this.Property(t => t.Educ_year_comp).HasColumnName("Educ_year_comp");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Person_education);
        }
    }
}
