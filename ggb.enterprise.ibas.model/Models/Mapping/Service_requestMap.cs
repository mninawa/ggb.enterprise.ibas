namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Service_requestMap" />
    /// </summary>
    public class Service_requestMap : EntityTypeConfiguration<Service_request>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service_requestMap"/> class.
        /// </summary>
        public Service_requestMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.SR_desc)
                .IsRequired()
 .HasMaxLength(250);

            this.Property(t => t.SR_priority_motivate)
                .IsRequired()
 .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Service_request");
            this.Property(t => t.Identifier).HasColumnName("SR_ID");
            this.Property(t => t.SR_rel_for).HasColumnName("SR_rel_for");
            this.Property(t => t.SR_comp_num).HasColumnName("SR_comp_num");
            this.Property(t => t.SR_pers_num).HasColumnName("SR_pers_num");
            this.Property(t => t.SR_equip_num).HasColumnName("SR_equip_num");
            this.Property(t => t.SR_lic_num).HasColumnName("SR_lic_num");
            this.Property(t => t.SR_loc_num).HasColumnName("SR_loc_num");
            this.Property(t => t.Entity_num).HasColumnName("Entity_num");
            this.Property(t => t.SR_Stat).HasColumnName("SR_Stat");
            this.Property(t => t.SLA_Stat).HasColumnName("SLA_Stat");
            this.Property(t => t.SR_desc).HasColumnName("SR_desc");
            this.Property(t => t.SR_service_cat).HasColumnName("SR_service_cat");
            this.Property(t => t.SR_dept).HasColumnName("SR_dept");
            this.Property(t => t.SR_sub_cap).HasColumnName("SR_sub_cap");
            this.Property(t => t.SR_service_type).HasColumnName("SR_service_type");
            this.Property(t => t.SR_service).HasColumnName("SR_service");
            this.Property(t => t.SR_CC_code).HasColumnName("SR_CC_code");
            this.Property(t => t.Create_by).HasColumnName("Create_by");
            this.Property(t => t.Request_by).HasColumnName("Request_by");
            this.Property(t => t.Close_by).HasColumnName("Close_by");
            this.Property(t => t.Create_date).HasColumnName("Create_date");
            this.Property(t => t.Request_date).HasColumnName("Request_date");
            this.Property(t => t.SLA_start_date).HasColumnName("SLA_start_date");
            this.Property(t => t.SLA_end).HasColumnName("SLA_end");
            this.Property(t => t.MAD_date).HasColumnName("MAD_date");
            this.Property(t => t.Close_date).HasColumnName("Close_date");
            this.Property(t => t.Escalate_ind).HasColumnName("Escalate_ind");
            this.Property(t => t.Escalate_date).HasColumnName("Escalate_date");
            this.Property(t => t.SR_priority).HasColumnName("SR_priority");
            this.Property(t => t.SR_priority_motivate).HasColumnName("SR_priority_motivate");
            this.Property(t => t.Priv_ind).HasColumnName("Priv_ind");
            this.Property(t => t.Priv_ind_licensing).HasColumnName("Priv_ind_licensing");
            this.Property(t => t.Priv_ind_GC).HasColumnName("Priv_ind_GC");
            this.Property(t => t.Priv_ind_audit).HasColumnName("Priv_ind_audit");
            this.Property(t => t.Priv_ind_FI).HasColumnName("Priv_ind_FI");
            this.Property(t => t.Priv_ind_legal).HasColumnName("Priv_ind_legal");
            this.Property(t => t.SR_Priv_ind_SED).HasColumnName("SR_Priv_ind_SED");
            this.Property(t => t.Priv_ind_HR).HasColumnName("Priv_ind_HR");
            this.Property(t => t.Priv_ind_risk).HasColumnName("Priv_ind_risk");
            this.Property(t => t.Priv_ind_CS).HasColumnName("Priv_ind_CS");
            this.Property(t => t.Priv_ind_comms).HasColumnName("Priv_ind_comms");
            this.Property(t => t.Priv_ind_IT).HasColumnName("Priv_ind_IT");
            this.Property(t => t.Priv_ind_Board).HasColumnName("Priv_ind_Board");
            this.Property(t => t.Priv_role).HasColumnName("Priv_role");
            this.Property(t => t.Priv_group_1).HasColumnName("Priv_group_1");
            this.Property(t => t.Priv_group_2).HasColumnName("Priv_group_2");
            this.Property(t => t.Priv_group_3).HasColumnName("Priv_group_3");
            this.Property(t => t.Priv_group_4).HasColumnName("Priv_group_4");
            this.Property(t => t.Priv_group_5).HasColumnName("Priv_group_5");
            this.Property(t => t.Priv_group_6).HasColumnName("Priv_group_6");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Service_request)
                .HasForeignKey(d => d.SR_comp_num);
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.Service_request)
                .HasForeignKey(d => d.Entity_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Service_request)
                .HasForeignKey(d => d.SR_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Service_request)
                .HasForeignKey(d => d.SR_lic_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Service_request)
                .HasForeignKey(d => d.SR_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Service_request)
                .HasForeignKey(d => d.SR_pers_num);
            this.HasRequired(t => t.Service_cat)
                .WithMany(t => t.Service_request)
                .HasForeignKey(d => d.SR_dept);
            this.HasRequired(t => t.Service_cat1)
                .WithMany(t => t.Service_request1)
                .HasForeignKey(d => d.SR_service_type);
            this.HasRequired(t => t.Service_cat2)
                .WithMany(t => t.Service_request2)
                .HasForeignKey(d => d.SR_service);
            this.HasRequired(t => t.Service_cat3)
                .WithMany(t => t.Service_request3)
                .HasForeignKey(d => d.SR_sub_cap);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Service_request)
                .HasForeignKey(d => d.Close_by);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.Service_request1)
                .HasForeignKey(d => d.Create_by);
            this.HasOptional(t => t.User2)
                .WithMany(t => t.Service_request2)
                .HasForeignKey(d => d.Request_by);
        }
    }
}
