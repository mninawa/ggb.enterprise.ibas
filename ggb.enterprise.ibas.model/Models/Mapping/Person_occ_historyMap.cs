namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Person_occ_historyMap" />
    /// </summary>
    public class Person_occ_historyMap : EntityTypeConfiguration<Person_occ_history>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_occ_historyMap"/> class.
        /// </summary>
        public Person_occ_historyMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Occ_emp_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Duties)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Person_occ_history");
            this.Property(t => t.Identifier).HasColumnName("Job_pers_num");
            this.Property(t => t.Occ_emp_name).HasColumnName("Occ_emp_name");
            this.Property(t => t.Job_title).HasColumnName("Job_title");
            this.Property(t => t.Job_start_date).HasColumnName("Job_start_date");
            this.Property(t => t.Job_end_date).HasColumnName("Job_end_date");
            this.Property(t => t.Duties).HasColumnName("Duties");

            // Relationships
            this.HasRequired(t => t.Person_employ)
                .WithOptional(t => t.Person_occ_history);
        }
    }
}
