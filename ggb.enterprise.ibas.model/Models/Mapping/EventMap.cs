namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="EventMap" />
    /// </summary>
    public class EventMap : EntityTypeConfiguration<Event>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventMap"/> class.
        /// </summary>
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Event_title)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Event_detail)
                .IsRequired()
 .HasMaxLength(200);

            this.Property(t => t.Hold_can_reason)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Event");
            this.Property(t => t.Identifier).HasColumnName("Event_num");
            this.Property(t => t.Event_title).HasColumnName("Event_title");
            this.Property(t => t.Event_detail).HasColumnName("Event_detail");
            this.Property(t => t.Event_cat).HasColumnName("Event_cat");
            this.Property(t => t.Event_type).HasColumnName("Event_type");
            this.Property(t => t.Event_stat).HasColumnName("Event_stat");
            this.Property(t => t.Event_prior).HasColumnName("Event_prior");
            this.Property(t => t.Criticality).HasColumnName("Criticality");
            this.Property(t => t.Ev_creator).HasColumnName("Ev_creator");
            this.Property(t => t.Event_approver).HasColumnName("Event_approver");
            this.Property(t => t.Ev_responsible).HasColumnName("Ev_responsible");
            this.Property(t => t.Ev_service).HasColumnName("Ev_service");
            this.Property(t => t.Ev_sched_start_date).HasColumnName("Ev_sched_start_date");
            this.Property(t => t.Ev_date_sched_end).HasColumnName("Ev_date_sched_end");
            this.Property(t => t.Ev_start_date).HasColumnName("Ev_start_date");
            this.Property(t => t.Ev_end_date).HasColumnName("Ev_end_date");
            this.Property(t => t.Ev_comp_req_date).HasColumnName("Ev_comp_req_date");
            this.Property(t => t.Hold_can_reason).HasColumnName("Hold_can_reason");
            this.Property(t => t.Ev_rel_for).HasColumnName("Ev_rel_for");
            this.Property(t => t.Ev_comp_num).HasColumnName("Ev_comp_num");
            this.Property(t => t.Ev_pers_num).HasColumnName("Ev_pers_num");
            this.Property(t => t.Ev_equip_num).HasColumnName("Ev_equip_num");
            this.Property(t => t.Ev_lic_num).HasColumnName("Ev_lic_num");
            this.Property(t => t.Ev_loc_num).HasColumnName("Ev_loc_num");
            this.Property(t => t.Ev_SR_ID).HasColumnName("Ev_SR_ID");
            this.Property(t => t.Ev_priv_ind).HasColumnName("Ev_priv_ind");
            this.Property(t => t.Ev_priv_ind_licensing).HasColumnName("Ev_priv_ind_licensing");
            this.Property(t => t.Ev_priv_ind_GC).HasColumnName("Ev_priv_ind_GC");
            this.Property(t => t.Ev_priv_ind_audit).HasColumnName("Ev_priv_ind_audit");
            this.Property(t => t.Ev_priv_ind_FI).HasColumnName("Ev_priv_ind_FI");
            this.Property(t => t.Ev_priv_ind_legal).HasColumnName("Ev_priv_ind_legal");
            this.Property(t => t.Ev_priv_ind_SED).HasColumnName("Ev_priv_ind_SED");
            this.Property(t => t.Ev_priv_ind_HR).HasColumnName("Ev_priv_ind_HR");
            this.Property(t => t.Ev_priv_ind_risk).HasColumnName("Ev_priv_ind_risk");
            this.Property(t => t.Ev_priv_ind_CS).HasColumnName("Ev_priv_ind_CS");
            this.Property(t => t.Ev_priv_ind_comms).HasColumnName("Ev_priv_ind_comms");
            this.Property(t => t.Ev_priv_ind_IT).HasColumnName("Ev_priv_ind_IT");
            this.Property(t => t.Ev_priv_ind_Board).HasColumnName("Ev_priv_ind_Board");
            this.Property(t => t.Ev_priv_role).HasColumnName("Ev_priv_role");
            this.Property(t => t.Ev_priv_group_1).HasColumnName("Ev_priv_group_1");
            this.Property(t => t.Ev_priv_group_2).HasColumnName("Ev_priv_group_2");
            this.Property(t => t.Ev_priv_group_3).HasColumnName("Ev_priv_group_3");
            this.Property(t => t.Ev_priv_group_4).HasColumnName("Ev_priv_group_4");
            this.Property(t => t.Ev_priv_group_5).HasColumnName("Ev_priv_group_5");
            this.Property(t => t.Ev_priv_group_6).HasColumnName("Ev_priv_group_6");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.Ev_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.Ev_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.Ev_lic_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.Ev_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.Ev_pers_num);
            this.HasOptional(t => t.Service_request)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.Ev_SR_ID);
        }
    }
}
