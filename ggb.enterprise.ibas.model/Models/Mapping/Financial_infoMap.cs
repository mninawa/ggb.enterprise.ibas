namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Financial_infoMap" />
    /// </summary>
    public class Financial_infoMap : EntityTypeConfiguration<Financial_info>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Financial_infoMap"/> class.
        /// </summary>
        public Financial_infoMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.FIinfo_name)
                .HasMaxLength(50);

            this.Property(t => t.FIinfo_address)
                .HasMaxLength(100);

            this.Property(t => t.Fiinfo_acc_type)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.FIinfo_account_num)
                .HasMaxLength(20);

            this.Property(t => t.Fiinfo_pay_period)
                .HasMaxLength(1);

            this.Property(t => t.Fiinfo_purpose)
                .HasMaxLength(200);

            this.Property(t => t.Fiinfo_collat)
                .HasMaxLength(100);

            this.Property(t => t.Fiinfo_type_ent)
                .HasMaxLength(5);

            this.Property(t => t.Fiinfo_nature_acc)
                .HasMaxLength(100);

            this.Property(t => t.Fiinfo_name_held)
                .HasMaxLength(100);

            this.Property(t => t.Fiinfo_sec_desc)
                .HasMaxLength(2000);

            this.Property(t => t.Fiinfo_other)
                .HasMaxLength(200);

            this.Property(t => t.Fiinfo_tax_year)
                .HasMaxLength(4);

            this.Property(t => t.Fiinfo_tax_ref_num)
                .HasMaxLength(20);

            this.Property(t => t.Fiinfo_other_pers)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Financial_info");
            this.Property(t => t.Identifier).HasColumnName("FIinfo_num");
            this.Property(t => t.FIinfo_rel_for).HasColumnName("FIinfo_rel_for");
            this.Property(t => t.FIinfo_comp_num).HasColumnName("FIinfo_comp_num");
            this.Property(t => t.FIinfo_pers_num).HasColumnName("FIinfo_pers_num");
            this.Property(t => t.FI_cat).HasColumnName("FI_cat");
            this.Property(t => t.FI_type).HasColumnName("FI_type");
            this.Property(t => t.FI_stat).HasColumnName("FI_stat");
            this.Property(t => t.FIinfo_amount).HasColumnName("FIinfo_amount");
            this.Property(t => t.FIinfo_spouse_amount).HasColumnName("FIinfo_spouse_amount");
            this.Property(t => t.FIinfo_name).HasColumnName("FIinfo_name");
            this.Property(t => t.FIinfo_address).HasColumnName("FIinfo_address");
            this.Property(t => t.Fiinfo_acc_type).HasColumnName("Fiinfo_acc_type");
            this.Property(t => t.FIinfo_account_num).HasColumnName("FIinfo_account_num");
            this.Property(t => t.FIinfo_date_open).HasColumnName("FIinfo_date_open");
            this.Property(t => t.FIinfo_date_due).HasColumnName("FIinfo_date_due");
            this.Property(t => t.Fiinfo_org_amount).HasColumnName("Fiinfo_org_amount");
            this.Property(t => t.Fiinfo_unpaid_bal).HasColumnName("Fiinfo_unpaid_bal");
            this.Property(t => t.Fiinfo_pay_period).HasColumnName("Fiinfo_pay_period");
            this.Property(t => t.Fiinfo_int_rate).HasColumnName("Fiinfo_int_rate");
            this.Property(t => t.Fiinfo_matur_date).HasColumnName("Fiinfo_matur_date");
            this.Property(t => t.Fiinfo_purpose).HasColumnName("Fiinfo_purpose");
            this.Property(t => t.Fiinfo_collat).HasColumnName("Fiinfo_collat");
            this.Property(t => t.Fiinfo_type_ent).HasColumnName("Fiinfo_type_ent");
            this.Property(t => t.Fiinfo_nature_acc).HasColumnName("Fiinfo_nature_acc");
            this.Property(t => t.Fiinfo_num_shares).HasColumnName("Fiinfo_num_shares");
            this.Property(t => t.Fiinfo_perc_own).HasColumnName("Fiinfo_perc_own");
            this.Property(t => t.Fiinfo_purch_price).HasColumnName("Fiinfo_purch_price");
            this.Property(t => t.Fiinfo_purch_date).HasColumnName("Fiinfo_purch_date");
            this.Property(t => t.Fiinfo_name_held).HasColumnName("Fiinfo_name_held");
            this.Property(t => t.Fiinfo_market_val).HasColumnName("Fiinfo_market_val");
            this.Property(t => t.Fiinfo_ann_income).HasColumnName("Fiinfo_ann_income");
            this.Property(t => t.Fiinfo_sec_desc).HasColumnName("Fiinfo_sec_desc");
            this.Property(t => t.Fiinfo_other).HasColumnName("Fiinfo_other");
            this.Property(t => t.Fiinfo_tax_year).HasColumnName("Fiinfo_tax_year");
            this.Property(t => t.Fiinfo_return_date).HasColumnName("Fiinfo_return_date");
            this.Property(t => t.Fiinfo_tax_ref_num).HasColumnName("Fiinfo_tax_ref_num");
            this.Property(t => t.Fiinfo_other_pers).HasColumnName("Fiinfo_other_pers");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Financial_info)
                .HasForeignKey(d => d.FIinfo_comp_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Financial_info)
                .HasForeignKey(d => d.FIinfo_pers_num);
        }
    }
}
