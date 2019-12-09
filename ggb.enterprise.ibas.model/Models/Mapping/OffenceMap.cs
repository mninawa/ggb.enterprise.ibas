namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="OffenceMap" />
    /// </summary>
    public class OffenceMap : EntityTypeConfiguration<Offence>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OffenceMap"/> class.
        /// </summary>
        public OffenceMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
 //           this.Property(t => t.Offence_num)
 //               .IsRequired()
 //.HasMaxLength(20);

            this.Property(t => t.Nature_offence)
                .IsRequired()
 .HasMaxLength(30);

            this.Property(t => t.Off_details)
                .IsRequired()
 .HasMaxLength(2000);

            this.Property(t => t.Court_Name)
                .HasMaxLength(50);

            this.Property(t => t.Courtcase_num)
                .HasMaxLength(20);

            this.Property(t => t.Penalty_other)
                .HasMaxLength(50);

            this.Property(t => t.Charge)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Offence");
            this.Property(t => t.Identifier).HasColumnName("Offence_num");
            this.Property(t => t.Offence_type).HasColumnName("Offence_type");
            this.Property(t => t.Off_rel_for).HasColumnName("Off_rel_for");
            this.Property(t => t.Off_comp_num).HasColumnName("Off_comp_num");
            this.Property(t => t.Off_pers_num).HasColumnName("Off_pers_num");
            this.Property(t => t.Nature_offence).HasColumnName("Nature_offence");
            this.Property(t => t.Off_details).HasColumnName("Off_details");
            this.Property(t => t.Off_country_num).HasColumnName("Off_country_num");
            this.Property(t => t.Off_province_num).HasColumnName("Off_province_num");
            this.Property(t => t.Off_state_num).HasColumnName("Off_state_num");
            this.Property(t => t.Off_municipality).HasColumnName("Off_municipality");
            this.Property(t => t.Off_city_num).HasColumnName("Off_city_num");
            this.Property(t => t.Offence_date).HasColumnName("Offence_date");
            this.Property(t => t.Offence_stat).HasColumnName("Offence_stat");
            this.Property(t => t.Court_Name).HasColumnName("Court_Name");
            this.Property(t => t.Court_Date).HasColumnName("Court_Date");
            this.Property(t => t.Courtcase_num).HasColumnName("Courtcase_num");
            this.Property(t => t.Outcome).HasColumnName("Outcome");
            this.Property(t => t.Civil_amount).HasColumnName("Civil_amount");
            this.Property(t => t.Date_of_conviction).HasColumnName("Date_of_conviction");
            this.Property(t => t.Penalty).HasColumnName("Penalty");
            this.Property(t => t.Penalty_other).HasColumnName("Penalty_other");
            this.Property(t => t.Charge).HasColumnName("Charge");

            // Relationships
            this.HasRequired(t => t.City)
                .WithMany(t => t.Offences)
                .HasForeignKey(d => d.Off_city_num);
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Offences)
                .HasForeignKey(d => d.Off_comp_num);
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Offences)
                .HasForeignKey(d => d.Off_country_num);
            this.HasOptional(t => t.Municipality)
                .WithMany(t => t.Offences)
                .HasForeignKey(d => d.Off_municipality);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Offences)
                .HasForeignKey(d => d.Off_pers_num);
            this.HasOptional(t => t.Province)
                .WithMany(t => t.Offences)
                .HasForeignKey(d => d.Off_province_num);
            this.HasOptional(t => t.State)
                .WithMany(t => t.Offences)
                .HasForeignKey(d => d.Off_state_num);
        }
    }
}
