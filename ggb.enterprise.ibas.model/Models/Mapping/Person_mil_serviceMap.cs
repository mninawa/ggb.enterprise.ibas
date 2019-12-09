namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Person_mil_serviceMap" />
    /// </summary>
    public class Person_mil_serviceMap : EntityTypeConfiguration<Person_mil_service>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_mil_serviceMap"/> class.
        /// </summary>
        public Person_mil_serviceMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Arm_service)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Mill_branch)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Serial_num)
                .IsRequired()
 .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Person_mil_service");
            this.Property(t => t.Identifier).HasColumnName("Mill_pers_num");
            this.Property(t => t.Military_num).HasColumnName("Military_num");
            this.Property(t => t.Mill_country_id).HasColumnName("Mill_country_id");
            this.Property(t => t.Arm_service).HasColumnName("Arm_service");
            this.Property(t => t.Mill_branch).HasColumnName("Mill_branch");
            this.Property(t => t.Mil_start_date).HasColumnName("Mil_start_date");
            this.Property(t => t.Type_discharge).HasColumnName("Type_discharge");
            this.Property(t => t.Date_discharge).HasColumnName("Date_discharge");
            this.Property(t => t.Rank_discharge).HasColumnName("Rank_discharge");
            this.Property(t => t.Serial_num).HasColumnName("Serial_num");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Person_mil_service)
                .HasForeignKey(d => d.Mill_country_id);
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Person_mil_service);
        }
    }
}
