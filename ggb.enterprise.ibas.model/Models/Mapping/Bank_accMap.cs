namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Bank_accMap" />
    /// </summary>
    public class Bank_accMap : EntityTypeConfiguration<Bank_acc>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank_accMap"/> class.
        /// </summary>
        public Bank_accMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Bank_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Branch_code)
                .IsRequired()
 .HasMaxLength(30);

            this.Property(t => t.Account_Type)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Bank_address)
                .IsRequired()
 .HasMaxLength(100);

            this.Property(t => t.Bank_cont_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Bank_cont_email)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Bank_cont_number)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Bank_acc");
            this.Property(t => t.Identifier).HasColumnName("Bank_record_num");
            this.Property(t => t.Bank_rel_for).HasColumnName("Bank_rel_for");
            this.Property(t => t.Bank_comp_num).HasColumnName("Bank_comp_num");
            this.Property(t => t.Bank_pers_num).HasColumnName("Bank_pers_num");
            this.Property(t => t.Bank_type).HasColumnName("Bank_type");
            this.Property(t => t.Bank_name).HasColumnName("Bank_name");
            this.Property(t => t.Branch_code).HasColumnName("Branch_code");
            this.Property(t => t.Account_Type).HasColumnName("Account_Type");
            this.Property(t => t.Account_No).HasColumnName("Account_No");
            this.Property(t => t.Bank_address).HasColumnName("Bank_address");
            this.Property(t => t.Bank_cont_name).HasColumnName("Bank_cont_name");
            this.Property(t => t.Bank_cont_email).HasColumnName("Bank_cont_email");
            this.Property(t => t.Bank_cont_number).HasColumnName("Bank_cont_number");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Bank_acc)
                .HasForeignKey(d => d.Bank_comp_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Bank_acc)
                .HasForeignKey(d => d.Bank_pers_num);
        }
    }
}
