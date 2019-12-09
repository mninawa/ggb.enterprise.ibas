namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Person_credit_histMap" />
    /// </summary>
    public class Person_credit_histMap : EntityTypeConfiguration<Person_credit_hist>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_credit_histMap"/> class.
        /// </summary>
        public Person_credit_histMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Creditor_Name)
                .IsRequired()
 .HasMaxLength(20);

            this.Property(t => t.Amount_owing)
                .IsRequired()
 .HasMaxLength(20);

            this.Property(t => t.Amount_default)
                .IsRequired()
 .HasMaxLength(20);

            this.Property(t => t.Reason_dafault_other)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Person_credit_hist");
            this.Property(t => t.Identifier).HasColumnName("Cred_pers_num");
            this.Property(t => t.Creditor_Name).HasColumnName("Creditor_Name");
            this.Property(t => t.Credit_history_Type).HasColumnName("Credit_history_Type");
            this.Property(t => t.Amount_owing).HasColumnName("Amount_owing");
            this.Property(t => t.Amount_default).HasColumnName("Amount_default");
            this.Property(t => t.Days_default).HasColumnName("Days_default");
            this.Property(t => t.Reason_dafault).HasColumnName("Reason_dafault");
            this.Property(t => t.Reason_dafault_other).HasColumnName("Reason_dafault_other");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Person_credit_hist);
        }
    }
}
