namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="CompanyMap" />
    /// </summary>
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyMap"/> class.
        /// </summary>
        public CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Company_reg_num)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Company_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Company_trade_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Place_of_incorporation)
                .HasMaxLength(20);

            this.Property(t => t.Nature_businness)
                .HasMaxLength(50);

            this.Property(t => t.Comp_work_num)
                .HasMaxLength(13);

            this.Property(t => t.Comp_alt_num)
                .HasMaxLength(13);

            this.Property(t => t.Comp_cell_num)
                .HasMaxLength(13);

            this.Property(t => t.Comp_fax_num)
                .HasMaxLength(13);

            this.Property(t => t.Comp_email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Company");
            this.Property(t => t.Identifier).HasColumnName("Company_num");
            this.Property(t => t.Company_reg_num).HasColumnName("Company_reg_num");
            this.Property(t => t.Company_name).HasColumnName("Company_name");
            this.Property(t => t.Company_trade_name).HasColumnName("Company_trade_name");
            this.Property(t => t.Comp_group).HasColumnName("Comp_group");
            this.Property(t => t.Comp_type).HasColumnName("Comp_type");
            this.Property(t => t.Comp_cat).HasColumnName("Comp_cat");
            this.Property(t => t.Comp_spec).HasColumnName("Comp_spec");
            this.Property(t => t.Comp_stat).HasColumnName("Comp_stat");
            this.Property(t => t.Comp_own).HasColumnName("Comp_own");
            this.Property(t => t.Incorporation_date).HasColumnName("Incorporation_date");
            this.Property(t => t.Place_of_incorporation).HasColumnName("Place_of_incorporation");
            this.Property(t => t.Comp_size).HasColumnName("Comp_size");
            this.Property(t => t.Comp_risk).HasColumnName("Comp_risk");
            this.Property(t => t.Nature_businness).HasColumnName("Nature_businness");
            this.Property(t => t.Comp_work_num).HasColumnName("Comp_work_num");
            this.Property(t => t.Comp_alt_num).HasColumnName("Comp_alt_num");
            this.Property(t => t.Comp_cell_num).HasColumnName("Comp_cell_num");
            this.Property(t => t.Comp_fax_num).HasColumnName("Comp_fax_num");
            this.Property(t => t.Comp_telefax_No).HasColumnName("Comp_telefax_No");
            this.Property(t => t.Comp_email).HasColumnName("Comp_email");
            this.Property(t => t.Num_share_less5_).HasColumnName("Num_share_less5%");
        }
    }
}
