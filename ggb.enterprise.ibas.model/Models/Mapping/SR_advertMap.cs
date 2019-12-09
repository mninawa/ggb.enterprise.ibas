namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="SR_advertMap" />
    /// </summary>
    public class SR_advertMap : EntityTypeConfiguration<SR_advert>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SR_advertMap"/> class.
        /// </summary>
        public SR_advertMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Adv_desc)
                .IsRequired()
 .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SR_advert");
            this.Property(t => t.Identifier).HasColumnName("Adv_SR_ID");
            this.Property(t => t.Adv_desc).HasColumnName("Adv_desc");
            this.Property(t => t.Adv_start_date).HasColumnName("Adv_start_date");
            this.Property(t => t.Adv_end_date).HasColumnName("Adv_end_date");

            // Relationships
            this.HasRequired(t => t.Service_request)
                .WithOptional(t => t.SR_advert);
        }
    }
}
