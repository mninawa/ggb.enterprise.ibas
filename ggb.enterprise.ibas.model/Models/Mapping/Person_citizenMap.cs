namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Person_citizenMap" />
    /// </summary>
    public class Person_citizenMap : EntityTypeConfiguration<Person_citizen>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_citizenMap"/> class.
        /// </summary>
        public Person_citizenMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Place_issue)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Person_citizen");
            this.Property(t => t.Identifier).HasColumnName("Citiz_pers_num");
            this.Property(t => t.Passport_num).HasColumnName("Passport_num");
            this.Property(t => t.ID_pass_type).HasColumnName("ID_pass_type");
            this.Property(t => t.Country_id).HasColumnName("Country_id");
            this.Property(t => t.Date_issue).HasColumnName("Date_issue");
            this.Property(t => t.Date_expire).HasColumnName("Date_expire");
            this.Property(t => t.Place_issue).HasColumnName("Place_issue");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Person_citizen)
                .HasForeignKey(d => d.Country_id);
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Person_citizen);
        }
    }
}
