namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="DocumentMap" />
    /// </summary>
    public class DocumentMap : EntityTypeConfiguration<Document>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentMap"/> class.
        /// </summary>
        public DocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Doc_name)
                .IsRequired()
 .HasMaxLength(200);

            this.Property(t => t.Doc_folder)
                .IsRequired()
 .IsFixedLength()
 .HasMaxLength(32);

            this.Property(t => t.URL)
                .IsRequired()
 .HasMaxLength(256);

            this.Property(t => t.Doc_desc)
                .IsRequired()
 .HasMaxLength(200);

            this.Property(t => t.Doc_author)
                .IsRequired()
 .HasMaxLength(100);

            this.Property(t => t.Doc_approver)
                .IsRequired()
 .HasMaxLength(100);

            this.Property(t => t.Doc_note)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Document");
            this.Property(t => t.Identifier).HasColumnName("Doc_num");
            this.Property(t => t.Doc_name).HasColumnName("Doc_name");
            this.Property(t => t.Doc_cat).HasColumnName("Doc_cat");
            this.Property(t => t.Doc_type).HasColumnName("Doc_type");
            this.Property(t => t.Doc_stat).HasColumnName("Doc_stat");
            this.Property(t => t.Doc_folder).HasColumnName("Doc_folder");
            this.Property(t => t.URL).HasColumnName("URL");
            this.Property(t => t.Doc_desc).HasColumnName("Doc_desc");
            this.Property(t => t.Doc_author).HasColumnName("Doc_author");
            this.Property(t => t.Doc_approver).HasColumnName("Doc_approver");
            this.Property(t => t.Doc_date).HasColumnName("Doc_date");
            this.Property(t => t.Date_load).HasColumnName("Date_load");
            this.Property(t => t.Date_delete).HasColumnName("Date_delete");
            this.Property(t => t.Doc_review).HasColumnName("Doc_review");
            this.Property(t => t.Doc_note).HasColumnName("Doc_note");
            this.Property(t => t.Doc_rel_for).HasColumnName("Doc_rel_for");
            this.Property(t => t.Doc_comp_num).HasColumnName("Doc_comp_num");
            this.Property(t => t.Doc_pers_num).HasColumnName("Doc_pers_num");
            this.Property(t => t.Doc_equip_num).HasColumnName("Doc_equip_num");
            this.Property(t => t.Doc_lic_num).HasColumnName("Doc_lic_num");
            this.Property(t => t.Doc_loc_num).HasColumnName("Doc_loc_num");
            this.Property(t => t.Doc_SR_ID).HasColumnName("Doc_SR_ID");
            this.Property(t => t.Doc_priv_ind).HasColumnName("Doc_priv_ind");
            this.Property(t => t.Doc_priv_ind_licensing).HasColumnName("Doc_priv_ind_licensing");
            this.Property(t => t.Doc_priv_ind_GC).HasColumnName("Doc_priv_ind_GC");
            this.Property(t => t.Doc_priv_ind_audit).HasColumnName("Doc_priv_ind_audit");
            this.Property(t => t.Doc_priv_ind_FI).HasColumnName("Doc_priv_ind_FI");
            this.Property(t => t.Doc_priv_ind_legal).HasColumnName("Doc_priv_ind_legal");
            this.Property(t => t.Doc_priv_ind_SED).HasColumnName("Doc_priv_ind_SED");
            this.Property(t => t.Doc_priv_ind_HR).HasColumnName("Doc_priv_ind_HR");
            this.Property(t => t.Doc_priv_ind_risk).HasColumnName("Doc_priv_ind_risk");
            this.Property(t => t.Doc_priv_ind_CS).HasColumnName("Doc_priv_ind_CS");
            this.Property(t => t.Doc_priv_ind_comms).HasColumnName("Doc_priv_ind_comms");
            this.Property(t => t.Doc_priv_ind_IT).HasColumnName("Doc_priv_ind_IT");
            this.Property(t => t.Doc_priv_ind_Board).HasColumnName("Doc_priv_ind_Board");
            this.Property(t => t.Doc_priv_role).HasColumnName("Doc_priv_role");
            this.Property(t => t.Doc_priv_group_1).HasColumnName("Doc_priv_group_1");
            this.Property(t => t.Doc_priv_group_2).HasColumnName("Doc_priv_group_2");
            this.Property(t => t.Doc_priv_group_3).HasColumnName("Doc_priv_group_3");
            this.Property(t => t.Doc_priv_group_4).HasColumnName("Doc_priv_group_4");
            this.Property(t => t.Doc_priv_group_5).HasColumnName("Doc_priv_group_5");
            this.Property(t => t.Doc_priv_group_6).HasColumnName("Doc_priv_group_6");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.Doc_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.Doc_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.Doc_lic_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.Doc_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.Doc_pers_num);
            this.HasRequired(t => t.Service_request)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.Doc_SR_ID);
        }
    }
}
