namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Bank_tranMap" />
    /// </summary>
    public class Bank_tranMap : EntityTypeConfiguration<Bank_tran>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank_tranMap"/> class.
        /// </summary>
        public Bank_tranMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Tran_ref)
                .IsRequired()
 .HasMaxLength(20);

            this.Property(t => t.Tran_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Tran_desc)
                .IsRequired()
 .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Bank_tran");
            this.Property(t => t.Identifier).HasColumnName("Tran_number");
            this.Property(t => t.Tran_type).HasColumnName("Tran_type");
            this.Property(t => t.Tran_ref).HasColumnName("Tran_ref");
            this.Property(t => t.Tran_name).HasColumnName("Tran_name");
            this.Property(t => t.Tran_desc).HasColumnName("Tran_desc");
            this.Property(t => t.Tran_amount).HasColumnName("Tran_amount");
            this.Property(t => t.Transaction_date).HasColumnName("Transaction_date");
            this.Property(t => t.Tran_time).HasColumnName("Tran_time");
        }
    }
}
