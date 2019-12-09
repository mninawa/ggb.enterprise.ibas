namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="SR_recommendMap" />
    /// </summary>
    public class SR_recommendMap : EntityTypeConfiguration<SR_recommend>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SR_recommendMap"/> class.
        /// </summary>
        public SR_recommendMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Recom_desc)
                .IsRequired()
 .HasMaxLength(2500);

            // Table & Column Mappings
            this.ToTable("SR_recommend");
            this.Property(t => t.Identifier).HasColumnName("Recom_SR_ID");
            this.Property(t => t.Recom_num).HasColumnName("Recom_num");
            this.Property(t => t.Recom_date).HasColumnName("Recom_date");
            this.Property(t => t.Recom_stat).HasColumnName("Recom_stat");
            this.Property(t => t.Recom_dict_num).HasColumnName("Recom_dict_num");
            this.Property(t => t.Recom_desc).HasColumnName("Recom_desc");

            // Relationships
            this.HasRequired(t => t.Dictionary)
                .WithMany(t => t.SR_recommend)
                .HasForeignKey(d => d.Recom_dict_num);
            this.HasRequired(t => t.Service_request)
                .WithOptional(t => t.SR_recommend);
        }
    }
}
