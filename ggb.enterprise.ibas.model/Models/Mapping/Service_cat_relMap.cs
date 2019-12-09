namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Service_cat_relMap" />
    /// </summary>
    public class Service_cat_relMap : EntityTypeConfiguration<Service_cat_rel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service_cat_relMap"/> class.
        /// </summary>
        public Service_cat_relMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            // Table & Column Mappings
            this.ToTable("Service_cat_rel");
            this.Property(t => t.Identifier).HasColumnName("Rel_serv_cat_num");
            this.Property(t => t.Serv_comp_cat).HasColumnName("Serv_comp_cat");
            this.Property(t => t.Relevance_ind).HasColumnName("Relevance_ind");
        }
    }
}
