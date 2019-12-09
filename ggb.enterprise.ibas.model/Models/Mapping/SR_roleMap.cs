namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="SR_roleMap" />
    /// </summary>
    public class SR_roleMap : EntityTypeConfiguration<SR_role>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SR_roleMap"/> class.
        /// </summary>
        public SR_roleMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            // Table & Column Mappings
            this.ToTable("SR_role");
            this.Property(t => t.Identifier).HasColumnName("SR_role_SR_ID");
            this.Property(t => t.SR_role_pers_num).HasColumnName("SR_role_pers_num");
            this.Property(t => t.App_role).HasColumnName("App_role");
            this.Property(t => t.Role_start_date).HasColumnName("Role_start_date");
            this.Property(t => t.Role_end_date).HasColumnName("Role_end_date");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithMany(t => t.SR_role)
                .HasForeignKey(d => d.SR_role_pers_num);
            this.HasRequired(t => t.Service_request)
                .WithOptional(t => t.SR_role);
        }
    }
}
