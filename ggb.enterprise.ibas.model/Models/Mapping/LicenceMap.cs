namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="LicenceMap" />
    /// </summary>
    public class LicenceMap : EntityTypeConfiguration<Licence>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenceMap"/> class.
        /// </summary>
        public LicenceMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Licence_code)
                .IsRequired()
 .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Licence");
            this.Property(t => t.Identifier).HasColumnName("Licence_num");
            this.Property(t => t.Lic_rel_for).HasColumnName("Lic_rel_for");
            this.Property(t => t.Lic_comp_num).HasColumnName("Lic_comp_num");
            this.Property(t => t.Lic_pers_num).HasColumnName("Lic_pers_num");
            this.Property(t => t.Lic_equip_num).HasColumnName("Lic_equip_num");
            this.Property(t => t.Lic_loc_num).HasColumnName("Lic_loc_num");
            this.Property(t => t.Licence_type).HasColumnName("Licence_type");
            this.Property(t => t.Licence_code).HasColumnName("Licence_code");
            this.Property(t => t.Licence_stat).HasColumnName("Licence_stat");
            this.Property(t => t.Lic_start_date).HasColumnName("Lic_start_date");
            this.Property(t => t.Licence_end_date).HasColumnName("Licence_end_date");
            this.Property(t => t.Number_Renewable).HasColumnName("Number_Renewable");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Licences)
                .HasForeignKey(d => d.Lic_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Licences)
                .HasForeignKey(d => d.Lic_equip_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Licences)
                .HasForeignKey(d => d.Lic_pers_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Licences)
                .HasForeignKey(d => d.Lic_loc_num);
        }
    }
}
