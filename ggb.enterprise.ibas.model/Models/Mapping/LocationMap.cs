namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="LocationMap" />
    /// </summary>
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationMap"/> class.
        /// </summary>
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Loc_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Loc_desc)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Location");
            this.Property(t => t.Identifier).HasColumnName("Loc_num");
            this.Property(t => t.Loc_name).HasColumnName("Loc_name");
            this.Property(t => t.Loc_desc).HasColumnName("Loc_desc");
            this.Property(t => t.Loc_rel_for).HasColumnName("Loc_rel_for");
            this.Property(t => t.Loc_comp_num).HasColumnName("Loc_comp_num");
            this.Property(t => t.Loc_pers_num).HasColumnName("Loc_pers_num");
            this.Property(t => t.Loc_equip_num).HasColumnName("Loc_equip_num");
            this.Property(t => t.Loc_lic_num).HasColumnName("Loc_lic_num");
            this.Property(t => t.Loc_SR_ID).HasColumnName("Loc_SR_ID");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.Loc_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.Loc_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.Loc_lic_num);
            this.HasOptional(t => t.Licence1)
                .WithMany(t => t.Locations1)
                .HasForeignKey(d => d.Loc_lic_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.Loc_pers_num);
        }
    }
}
