namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="SR_status_histMap" />
    /// </summary>
    public class SR_status_histMap : EntityTypeConfiguration<SR_status_hist>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SR_status_histMap"/> class.
        /// </summary>
        public SR_status_histMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Comments)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SR_status_hist");
            this.Property(t => t.Identifier).HasColumnName("Hist_SR_ID");
            this.Property(t => t.Stat_change_date).HasColumnName("Stat_change_date");
            this.Property(t => t.Stat_change_time).HasColumnName("Stat_change_time");
            this.Property(t => t.SR_stat_before).HasColumnName("SR_stat_before");
            this.Property(t => t.SR_stat_after).HasColumnName("SR_stat_after");
            this.Property(t => t.SR_Business_role).HasColumnName("SR_Business_role");
            this.Property(t => t.Assigned_to).HasColumnName("Assigned_to");
            this.Property(t => t.Response_by).HasColumnName("Response_by");
            this.Property(t => t.Date_responded).HasColumnName("Date_responded");
            this.Property(t => t.Comments).HasColumnName("Comments");

            // Relationships
            this.HasRequired(t => t.Service_request)
                .WithOptional(t => t.SR_status_hist);
            this.HasRequired(t => t.User)
                .WithMany(t => t.SR_status_hist)
                .HasForeignKey(d => d.Assigned_to);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.SR_status_hist1)
                .HasForeignKey(d => d.Response_by);
        }
    }
}
