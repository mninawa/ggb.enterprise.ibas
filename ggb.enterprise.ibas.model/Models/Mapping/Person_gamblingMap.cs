namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Person_gamblingMap" />
    /// </summary>
    public class Person_gamblingMap : EntityTypeConfiguration<Person_gambling>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_gamblingMap"/> class.
        /// </summary>
        public Person_gamblingMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            // Table & Column Mappings
            this.ToTable("Person_gambling");
            this.Property(t => t.Identifier).HasColumnName("Gamb_pers_num");
            this.Property(t => t.Gamb_rel_for).HasColumnName("Gamb_rel_for");
            this.Property(t => t.Gambling_company_num).HasColumnName("Gambling_company_num");
            this.Property(t => t.Gamb_ent_number).HasColumnName("Gamb_ent_number");
            this.Property(t => t.Gamb_lic_type).HasColumnName("Gamb_lic_type");
            this.Property(t => t.Jurisdiction).HasColumnName("Jurisdiction");
            this.Property(t => t.Gam_start_date).HasColumnName("Gam_start_date");
            this.Property(t => t.Gam_end_Date).HasColumnName("Gam_end_Date");

            // Relationships
            this.HasOptional(t => t.Country)
                .WithMany(t => t.Person_gambling)
                .HasForeignKey(d => d.Gambling_company_num);
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.Person_gambling)
                .HasForeignKey(d => d.Gamb_ent_number);
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Person_gambling);
        }
    }
}
