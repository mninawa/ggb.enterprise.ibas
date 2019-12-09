namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="App_feeMap" />
    /// </summary>
    public class App_feeMap : EntityTypeConfiguration<App_fee>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App_feeMap"/> class.
        /// </summary>
        public App_feeMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            // Table & Column Mappings
            this.ToTable("App_fee");
            this.Property(t => t.Identifier).HasColumnName("fee_num");
            this.Property(t => t.App_lic_type).HasColumnName("App_lic_type");
            this.Property(t => t.App_fee_type).HasColumnName("App_fee_type");
            this.Property(t => t.App_fee_type_cat).HasColumnName("App_fee_type_cat");
            this.Property(t => t.App_fee_type_subcat).HasColumnName("App_fee_type_subcat");
            this.Property(t => t.App_fee_amount).HasColumnName("App_fee_amount");
            this.Property(t => t.Fee_start_date).HasColumnName("Fee_start_date");
            this.Property(t => t.Fee_end_date).HasColumnName("Fee_end_date");
        }
    }
}
