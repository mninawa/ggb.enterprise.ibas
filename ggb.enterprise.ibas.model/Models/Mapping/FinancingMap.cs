namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="FinancingMap" />
    /// </summary>
    public class FinancingMap : EntityTypeConfiguration<Financing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancingMap"/> class.
        /// </summary>
        public FinancingMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Finance_note)
                .HasMaxLength(2000);

            this.Property(t => t.Types_FI_facility)
                .IsRequired()
 .HasMaxLength(10);

            this.Property(t => t.Repayment_Period)
                .HasMaxLength(20);

            this.Property(t => t.Repayment_Terms)
                .HasMaxLength(200);

            this.Property(t => t.FI_ent_number)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Financing");
            this.Property(t => t.Identifier).HasColumnName("FI_SR_ID");
            this.Property(t => t.Payment_type).HasColumnName("Payment_type");
            this.Property(t => t.FI_rel_for).HasColumnName("FI_rel_for");
            this.Property(t => t.FI_comp_num).HasColumnName("FI_comp_num");
            this.Property(t => t.FI_pers_num).HasColumnName("FI_pers_num");
            this.Property(t => t.Equip_num).HasColumnName("Equip_num");
            this.Property(t => t.FI_lic_num).HasColumnName("FI_lic_num");
            this.Property(t => t.FI_loc_num).HasColumnName("FI_loc_num");
            this.Property(t => t.Payment_Status).HasColumnName("Payment_Status");
            this.Property(t => t.FI_ref_num).HasColumnName("FI_ref_num");
            this.Property(t => t.Finance_note).HasColumnName("Finance_note");
            this.Property(t => t.FI_acc_num).HasColumnName("FI_acc_num");
            this.Property(t => t.Types_FI_facility).HasColumnName("Types_FI_facility");
            this.Property(t => t.Amount_facility).HasColumnName("Amount_facility");
            this.Property(t => t.Repayment_Period).HasColumnName("Repayment_Period");
            this.Property(t => t.Repayment_Terms).HasColumnName("Repayment_Terms");
            this.Property(t => t.FI_ent_number).HasColumnName("FI_ent_number");
            this.Property(t => t.Finance_num).HasColumnName("Finance_num");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Financings)
                .HasForeignKey(d => d.FI_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Financings)
                .HasForeignKey(d => d.Equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Financings)
                .HasForeignKey(d => d.FI_lic_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Financings)
                .HasForeignKey(d => d.FI_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Financings)
                .HasForeignKey(d => d.FI_pers_num);
            this.HasRequired(t => t.Service_request)
                .WithOptional(t => t.Financing);
        }
    }
}
