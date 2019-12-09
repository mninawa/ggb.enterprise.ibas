namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="CommMap" />
    /// </summary>
    public class CommMap : EntityTypeConfiguration<Comm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommMap"/> class.
        /// </summary>
        public CommMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Comm_subject)
                .IsRequired()
 .HasMaxLength(200);

            this.Property(t => t.Comm_author)
                .IsRequired()
 .HasMaxLength(100);

            this.Property(t => t.Comm_to)
                .IsRequired()
 .HasMaxLength(100);

            this.Property(t => t.Comms_desc)
                .IsRequired()
 .HasMaxLength(2000);

            this.Property(t => t.Response)
                .IsRequired()
 .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Comms");
            this.Property(t => t.Identifier).HasColumnName("Comm_num");
            this.Property(t => t.Comm_subject).HasColumnName("Comm_subject");
            this.Property(t => t.Comm_cat).HasColumnName("Comm_cat");
            this.Property(t => t.Comm_type).HasColumnName("Comm_type");
            this.Property(t => t.Comm_stat).HasColumnName("Comm_stat");
            this.Property(t => t.Comm_author).HasColumnName("Comm_author");
            this.Property(t => t.Comm_to).HasColumnName("Comm_to");
            this.Property(t => t.Comm_priority).HasColumnName("Comm_priority");
            this.Property(t => t.Comms_desc).HasColumnName("Comms_desc");
            this.Property(t => t.Comm_date).HasColumnName("Comm_date");
            this.Property(t => t.Comm_time).HasColumnName("Comm_time");
            this.Property(t => t.Response).HasColumnName("Response");
            this.Property(t => t.Comm_rel_for).HasColumnName("Comm_rel_for");
            this.Property(t => t.Comm_comp_num).HasColumnName("Comm_comp_num");
            this.Property(t => t.Comm_pers_num).HasColumnName("Comm_pers_num");
            this.Property(t => t.Comm_equip_num).HasColumnName("Comm_equip_num");
            this.Property(t => t.Comm_lic_num).HasColumnName("Comm_lic_num");
            this.Property(t => t.Comm_loc_num).HasColumnName("Comm_loc_num");
            this.Property(t => t.Comm_SR_ID).HasColumnName("Comm_SR_ID");
            this.Property(t => t.Comm_priv_ind).HasColumnName("Comm_priv_ind");
            this.Property(t => t.Comm_priv_ind_licensing).HasColumnName("Comm_priv_ind_licensing");
            this.Property(t => t.Comm_priv_ind_GC).HasColumnName("Comm_priv_ind_GC");
            this.Property(t => t.Doc_priv_ind).HasColumnName("Doc_priv_ind");
            this.Property(t => t.Doc_priv_ind_licensing).HasColumnName("Doc_priv_ind_licensing");
            this.Property(t => t.Doc_priv_ind_GC).HasColumnName("Doc_priv_ind_GC");
            this.Property(t => t.Comm_priv_ind_audit).HasColumnName("Comm_priv_ind_audit");
            this.Property(t => t.Comm_priv_ind_FI).HasColumnName("Comm_priv_ind_FI");
            this.Property(t => t.Comm_priv_ind_legal).HasColumnName("Comm_priv_ind_legal");
            this.Property(t => t.Comm_priv_ind_SED).HasColumnName("Comm_priv_ind_SED");
            this.Property(t => t.Comm_priv_ind_HR).HasColumnName("Comm_priv_ind_HR");
            this.Property(t => t.Comm_priv_ind_risk).HasColumnName("Comm_priv_ind_risk");
            this.Property(t => t.Comm_priv_ind_CS).HasColumnName("Comm_priv_ind_CS");
            this.Property(t => t.Comm_priv_ind_comms).HasColumnName("Comm_priv_ind_comms");
            this.Property(t => t.Comm_priv_ind_IT).HasColumnName("Comm_priv_ind_IT");
            this.Property(t => t.Comm_priv_ind_Board).HasColumnName("Comm_priv_ind_Board");
            this.Property(t => t.Comm_priv_role).HasColumnName("Comm_priv_role");
            this.Property(t => t.Comm_priv_group_1).HasColumnName("Comm_priv_group_1");
            this.Property(t => t.Comm_priv_group_2).HasColumnName("Comm_priv_group_2");
            this.Property(t => t.Comm_priv_group_3).HasColumnName("Comm_priv_group_3");
            this.Property(t => t.Comm_priv_group_4).HasColumnName("Comm_priv_group_4");
            this.Property(t => t.Comm_priv_group_5).HasColumnName("Comm_priv_group_5");
            this.Property(t => t.Comm_priv_group_6).HasColumnName("Comm_priv_group_6");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Comms)
                .HasForeignKey(d => d.Comm_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Comms)
                .HasForeignKey(d => d.Comm_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Comms)
                .HasForeignKey(d => d.Comm_lic_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Comms)
                .HasForeignKey(d => d.Comm_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Comms)
                .HasForeignKey(d => d.Comm_pers_num);
            this.HasRequired(t => t.Service_request)
                .WithMany(t => t.Comms)
                .HasForeignKey(d => d.Comm_SR_ID);
        }
    }
}
