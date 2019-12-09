namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Comp_allocMap" />
    /// </summary>
    public class Comp_allocMap : EntityTypeConfiguration<Comp_alloc>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comp_allocMap"/> class.
        /// </summary>
        public Comp_allocMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Perform_Year)
                .IsRequired()
 .HasMaxLength(6);

            this.Property(t => t.Perform_quarter)
                .IsRequired()
 .HasMaxLength(6);

            this.Property(t => t.From_yearmonth)
                .IsRequired()
 .HasMaxLength(6);

            this.Property(t => t.To_yearmonth)
                .IsRequired()
 .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("Comp_alloc");
            this.Property(t => t.Identifier).HasColumnName("Alloc_comp_num");
            this.Property(t => t.Alloc_depart).HasColumnName("Alloc_depart");
            this.Property(t => t.Aloc_bus_role).HasColumnName("Aloc_bus_role");
            this.Property(t => t.Perform_Year).HasColumnName("Perform_Year");
            this.Property(t => t.Perform_quarter).HasColumnName("Perform_quarter");
            this.Property(t => t.Alloc_pers_num).HasColumnName("Alloc_pers_num");
            this.Property(t => t.From_yearmonth).HasColumnName("From_yearmonth");
            this.Property(t => t.To_yearmonth).HasColumnName("To_yearmonth");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithOptional(t => t.Comp_alloc);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Comp_alloc)
                .HasForeignKey(d => d.Alloc_pers_num);
        }
    }
}
