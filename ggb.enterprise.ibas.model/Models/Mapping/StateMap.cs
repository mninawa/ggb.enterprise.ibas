namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="StateMap" />
    /// </summary>
    public class StateMap : EntityTypeConfiguration<State>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateMap"/> class.
        /// </summary>
        public StateMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.State_desc)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("State");
            this.Property(t => t.Identifier).HasColumnName("State_num");
            this.Property(t => t.State_desc).HasColumnName("State_desc");
            this.Property(t => t.State_country_num).HasColumnName("State_country_num");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.States)
                .HasForeignKey(d => d.State_country_num);
        }
    }
}
