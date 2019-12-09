namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="SoftwareMap" />
    /// </summary>
    public class SoftwareMap : EntityTypeConfiguration<Software>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareMap"/> class.
        /// </summary>
        public SoftwareMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Software_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Sof_nrcs_cert_number)
                .HasMaxLength(20);

            this.Property(t => t.Soft_nrcs_LOC_num)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Software");
            this.Property(t => t.Identifier).HasColumnName("Software_num");
            this.Property(t => t.Software_name).HasColumnName("Software_name");
            this.Property(t => t.Sof_nrcs_cert_number).HasColumnName("Sof_nrcs_cert_number");
            this.Property(t => t.Soft_nrcs_cert_issue_date).HasColumnName("Soft_nrcs_cert_issue_date");
            this.Property(t => t.Soft_nrcs_cert_re_issue_date).HasColumnName("Soft_nrcs_cert_re_issue_date");
            this.Property(t => t.Soft_nrcs_LOC_num).HasColumnName("Soft_nrcs_LOC_num");
            this.Property(t => t.Software_cat).HasColumnName("Software_cat");
            this.Property(t => t.Software_type).HasColumnName("Software_type");
            this.Property(t => t.Software_stat).HasColumnName("Software_stat");
            this.Property(t => t.Software_from_date).HasColumnName("Software_from_date");
            this.Property(t => t.Software_to_date).HasColumnName("Software_to_date");
        }
    }
}
