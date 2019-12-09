namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="License_feeMap" />
    /// </summary>
    public class License_feeMap : EntityTypeConfiguration<License_fee>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="License_feeMap"/> class.
        /// </summary>
        public License_feeMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Fee_audit_note)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("License_fee");
            this.Property(t => t.Identifier).HasColumnName("Lic_fee_num");
            this.Property(t => t.Fee_rel_for).HasColumnName("Fee_rel_for");
            this.Property(t => t.Licfee_comp_num).HasColumnName("Licfee_comp_num");
            this.Property(t => t.Fee_pers_num).HasColumnName("Fee_pers_num");
            this.Property(t => t.Fee_equip_num).HasColumnName("Fee_equip_num");
            this.Property(t => t.Fee_lic_num).HasColumnName("Fee_lic_num");
            this.Property(t => t.Fee_loc_num).HasColumnName("Fee_loc_num");
            this.Property(t => t.Fee_SR_ID).HasColumnName("Fee_SR_ID");
            this.Property(t => t.Fee_pay_type).HasColumnName("Fee_pay_type");
            this.Property(t => t.Fee_type).HasColumnName("Fee_type");
            this.Property(t => t.Fee_type_cat).HasColumnName("Fee_type_cat");
            this.Property(t => t.Fee_type_subcat).HasColumnName("Fee_type_subcat");
            this.Property(t => t.Fee_amount).HasColumnName("Fee_amount");
            this.Property(t => t.Fee_pay_stat).HasColumnName("Fee_pay_stat");
            this.Property(t => t.Fee_pay_confirm_by).HasColumnName("Fee_pay_confirm_by");
            this.Property(t => t.Fee_pay_date).HasColumnName("Fee_pay_date");
            this.Property(t => t.Fee_lic_type).HasColumnName("Fee_lic_type");
            this.Property(t => t.Fee_audit_Ind).HasColumnName("Fee_audit_Ind");
            this.Property(t => t.Fee_audit_note).HasColumnName("Fee_audit_note");
            this.Property(t => t.Fee_audit_date).HasColumnName("Fee_audit_date");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.License_fee)
                .HasForeignKey(d => d.Licfee_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.License_fee)
                .HasForeignKey(d => d.Fee_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.License_fee)
                .HasForeignKey(d => d.Fee_lic_num);
            this.HasRequired(t => t.Location)
                .WithMany(t => t.License_fee)
                .HasForeignKey(d => d.Fee_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.License_fee)
                .HasForeignKey(d => d.Fee_pers_num);
            this.HasRequired(t => t.Service_request)
                .WithMany(t => t.License_fee)
                .HasForeignKey(d => d.Fee_SR_ID);
        }
    }
}
