namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Person_employMap" />
    /// </summary>
    public class Person_employMap : EntityTypeConfiguration<Person_employ>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_employMap"/> class.
        /// </summary>
        public Person_employMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Employer_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Employer_address)
                .IsRequired()
 .HasMaxLength(100);

            this.Property(t => t.Reason_other)
                .IsRequired()
 .HasMaxLength(100);

            this.Property(t => t.Contact_person)
                .HasMaxLength(50);

            this.Property(t => t.Contact_email)
                .HasMaxLength(50);

            this.Property(t => t.Contact_num)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Person_employ");
            this.Property(t => t.Identifier).HasColumnName("Emp_pers_num");
            this.Property(t => t.Employer_name).HasColumnName("Employer_name");
            this.Property(t => t.Employer_address).HasColumnName("Employer_address");
            this.Property(t => t.Emp_start_date).HasColumnName("Emp_start_date");
            this.Property(t => t.Emp_end_date).HasColumnName("Emp_end_date");
            this.Property(t => t.Reason_leaving).HasColumnName("Reason_leaving");
            this.Property(t => t.Reason_other).HasColumnName("Reason_other");
            this.Property(t => t.Contact_person).HasColumnName("Contact_person");
            this.Property(t => t.Contact_email).HasColumnName("Contact_email");
            this.Property(t => t.Contact_num).HasColumnName("Contact_num");
            this.Property(t => t.Discharge_ind).HasColumnName("Discharge_ind");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Person_employ);
        }
    }
}
