namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Loc_UnitMap" />
    /// </summary>
    public class Loc_UnitMap : EntityTypeConfiguration<Loc_Unit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loc_UnitMap"/> class.
        /// </summary>
        public Loc_UnitMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.IP_add)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Position)
                .HasMaxLength(50);

            this.Property(t => t.Area_name)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Loc_Unit");
            this.Property(t => t.Identifier).HasColumnName("Unit_loc_num");
            this.Property(t => t.Unit_num).HasColumnName("Unit_num");
            this.Property(t => t.Floor).HasColumnName("Floor");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.IP_add).HasColumnName("IP_add");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.Area_name).HasColumnName("Area_name");

            // Relationships
            this.HasRequired(t => t.Location)
                .WithOptional(t => t.Loc_Unit);
        }
    }
}
