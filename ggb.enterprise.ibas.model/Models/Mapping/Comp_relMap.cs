namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Comp_relMap" />
    /// </summary>
    public class Comp_relMap : EntityTypeConfiguration<Comp_rel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comp_relMap"/> class.
        /// </summary>
        public Comp_relMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            // Table & Column Mappings
            this.ToTable("Comp_rel");
            this.Property(t => t.Identifier).HasColumnName("Comprel_comp_num");
            this.Property(t => t.Comp_rel_for).HasColumnName("Comp_rel_for");
            this.Property(t => t.Rel_comp_num).HasColumnName("Rel_comp_num");
            this.Property(t => t.Rel_pers_num).HasColumnName("Rel_pers_num");
            this.Property(t => t.Rel_ent_number).HasColumnName("Rel_ent_number");
            this.Property(t => t.Role_type).HasColumnName("Role_type");
            this.Property(t => t.Sharehold_stat).HasColumnName("Sharehold_stat");
            this.Property(t => t.Shold_start_date).HasColumnName("Shold_start_date");
            this.Property(t => t.Sharehold_end).HasColumnName("Sharehold_end");
            this.Property(t => t.Shareholding).HasColumnName("Shareholding");
            this.Property(t => t.Sharehold_percent).HasColumnName("Sharehold_percent");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithOptional(t => t.Comp_rel);
            this.HasOptional(t => t.Company1)
                .WithMany(t => t.Comp_rel1)
                .HasForeignKey(d => d.Rel_comp_num);
            this.HasOptional(t => t.Event)
                .WithMany(t => t.Comp_rel)
                .HasForeignKey(d => d.Rel_ent_number);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Comp_rel)
                .HasForeignKey(d => d.Rel_pers_num);
        }
    }
}
