namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Licence_taxMap" />
    /// </summary>
    public class Licence_taxMap : EntityTypeConfiguration<Licence_tax>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence_taxMap"/> class.
        /// </summary>
        public Licence_taxMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Tax_audit_note)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Licence_tax");
            this.Property(t => t.Identifier).HasColumnName("Lic_tax_num");
            this.Property(t => t.Tax_rel_for).HasColumnName("Tax_rel_for");
            this.Property(t => t.Lictax_comp_num).HasColumnName("Lictax_comp_num");
            this.Property(t => t.Tax_pers_num).HasColumnName("Tax_pers_num");
            this.Property(t => t.Tax_equip_num).HasColumnName("Tax_equip_num");
            this.Property(t => t.Tax_lic_num).HasColumnName("Tax_lic_num");
            this.Property(t => t.Tac_loc_num).HasColumnName("Tac_loc_num");
            this.Property(t => t.Tax_SR_ID).HasColumnName("Tax_SR_ID");
            this.Property(t => t.Tax_period).HasColumnName("Tax_period");
            this.Property(t => t.Tax_payt_type).HasColumnName("Tax_payt_type");
            this.Property(t => t.Tax_pay_stat).HasColumnName("Tax_pay_stat");
            this.Property(t => t.Payment_confirm_by).HasColumnName("Payment_confirm_by");
            this.Property(t => t.Payment_date).HasColumnName("Payment_date");
            this.Property(t => t.Tax_lic_type).HasColumnName("Tax_lic_type");
            this.Property(t => t.Tax_amount).HasColumnName("Tax_amount");
            this.Property(t => t.Tax_audit_Ind).HasColumnName("Tax_audit_Ind");
            this.Property(t => t.Tax_audit_date).HasColumnName("Tax_audit_date");
            this.Property(t => t.Tax_audit_note).HasColumnName("Tax_audit_note");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Licence_tax)
                .HasForeignKey(d => d.Lictax_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Licence_tax)
                .HasForeignKey(d => d.Tax_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Licence_tax)
                .HasForeignKey(d => d.Tax_lic_num);
            this.HasRequired(t => t.Location)
                .WithMany(t => t.Licence_tax)
                .HasForeignKey(d => d.Tac_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Licence_tax)
                .HasForeignKey(d => d.Tax_pers_num);
            this.HasRequired(t => t.Service_request)
                .WithMany(t => t.Licence_tax)
                .HasForeignKey(d => d.Tax_SR_ID);
        }
    }
}
