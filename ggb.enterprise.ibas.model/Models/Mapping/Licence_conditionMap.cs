namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Licence_conditionMap" />
    /// </summary>
    public class Licence_conditionMap : EntityTypeConfiguration<Licence_condition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence_conditionMap"/> class.
        /// </summary>
        public Licence_conditionMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Cond_dict_num)
                .IsRequired()
 .HasMaxLength(10);

            this.Property(t => t.Cond_desc)
                .IsRequired()
 .HasMaxLength(2500);

            this.Property(t => t.Cond_reason)
                .IsRequired()
 .HasMaxLength(2500);

            // Table & Column Mappings
            this.ToTable("Licence_condition");
            this.Property(t => t.Identifier).HasColumnName("Cond_lic_num");
            this.Property(t => t.Cond_num).HasColumnName("Cond_num");
            this.Property(t => t.Cond_type).HasColumnName("Cond_type");
            this.Property(t => t.Cond_dict_num).HasColumnName("Cond_dict_num");
            this.Property(t => t.Cond_desc).HasColumnName("Cond_desc");
            this.Property(t => t.Cond_reason).HasColumnName("Cond_reason");
            this.Property(t => t.Cond_stat).HasColumnName("Cond_stat");
            this.Property(t => t.Cond_start_date).HasColumnName("Cond_start_date");
            this.Property(t => t.Cond_end_date).HasColumnName("Cond_end_date");

            // Relationships
            this.HasRequired(t => t.Licence)
                .WithOptional(t => t.Licence_condition);
        }
    }
}
