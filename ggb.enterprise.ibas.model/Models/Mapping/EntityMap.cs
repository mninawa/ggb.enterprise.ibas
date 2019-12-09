namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="EntityMap" />
    /// </summary>
    public class EntityMap : EntityTypeConfiguration<Entity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityMap"/> class.
        /// </summary>
        public EntityMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Entity_Name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Entity_first_names)
                .HasMaxLength(50);

            this.Property(t => t.Entity_alias)
                .HasMaxLength(50);

            this.Property(t => t.Entity_maiden)
                .HasMaxLength(50);

            this.Property(t => t.Ent_place_birth)
                .HasMaxLength(50);

            this.Property(t => t.Ent_address)
                .HasMaxLength(100);

            this.Property(t => t.Occupation)
                .HasMaxLength(50);

            this.Property(t => t.Ent_home_num)
                .HasMaxLength(13);

            this.Property(t => t.Ent_work_num)
                .HasMaxLength(13);

            this.Property(t => t.Ent_cell_num)
                .HasMaxLength(13);

            this.Property(t => t.Ent_email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Entity");
            this.Property(t => t.Identifier).HasColumnName("Entity_number");
            this.Property(t => t.Entity_Name).HasColumnName("Entity_Name");
            this.Property(t => t.Entity_first_names).HasColumnName("Entity_first_names");
            this.Property(t => t.Entity_alias).HasColumnName("Entity_alias");
            this.Property(t => t.Entity_maiden).HasColumnName("Entity_maiden");
            this.Property(t => t.Ent_ID_type).HasColumnName("Ent_ID_type");
            this.Property(t => t.Ent_ID_num).HasColumnName("Ent_ID_num");
            this.Property(t => t.Ent_date_birth).HasColumnName("Ent_date_birth");
            this.Property(t => t.Ent_place_brith_ind).HasColumnName("Ent_place_brith_ind");
            this.Property(t => t.Ent_place_birth).HasColumnName("Ent_place_birth");
            this.Property(t => t.Ent_date_decease).HasColumnName("Ent_date_decease");
            this.Property(t => t.Ent_address).HasColumnName("Ent_address");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.Ent_home_num).HasColumnName("Ent_home_num");
            this.Property(t => t.Ent_work_num).HasColumnName("Ent_work_num");
            this.Property(t => t.Ent_cell_num).HasColumnName("Ent_cell_num");
            this.Property(t => t.Ent_email).HasColumnName("Ent_email");
        }
    }
}
