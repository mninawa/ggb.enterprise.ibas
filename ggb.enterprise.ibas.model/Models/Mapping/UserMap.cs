namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="UserMap" />
    /// </summary>
    public class UserMap : EntityTypeConfiguration<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMap"/> class.
        /// </summary>
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.User_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.User_password)
                .IsRequired()
 .HasMaxLength(20);

            this.Property(t => t.Repeat_password)
                .IsRequired()
 .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.Identifier).HasColumnName("User_pers_num");
            this.Property(t => t.User_name).HasColumnName("User_name");
            this.Property(t => t.User_stat).HasColumnName("User_stat");
            this.Property(t => t.User_buss_role).HasColumnName("User_buss_role");
            this.Property(t => t.User_password).HasColumnName("User_password");
            this.Property(t => t.Repeat_password).HasColumnName("Repeat_password");
            this.Property(t => t.User_start).HasColumnName("User_start");
            this.Property(t => t.User_end).HasColumnName("User_end");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.User);
        }
    }
}
