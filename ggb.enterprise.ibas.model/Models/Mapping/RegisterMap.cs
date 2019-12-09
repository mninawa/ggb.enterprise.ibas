namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="RegisterMap" />
    /// </summary>
    public class RegisterMap : EntityTypeConfiguration<Register>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterMap"/> class.
        /// </summary>
        public RegisterMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
 //           this.Property(t => t.Register_num)
 //               .IsRequired()
 //.HasMaxLength(10);

            this.Property(t => t.Register_title)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Register_detail)
                .IsRequired()
 .HasMaxLength(200);

            this.Property(t => t.Reg_creator)
                .IsRequired()
 .HasMaxLength(10);

            this.Property(t => t.Approver)
                .HasMaxLength(10);

            this.Property(t => t.Owner)
                .IsRequired()
 .HasMaxLength(10);

            this.Property(t => t.Reg_responsible)
                .HasMaxLength(10);

            this.Property(t => t.Root_cause)
                .HasMaxLength(200);

            this.Property(t => t.Exist_control)
                .HasMaxLength(200);

            this.Property(t => t.Further_action)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Register");
            this.Property(t => t.Identifier).HasColumnName("Register_num");
            this.Property(t => t.Register_title).HasColumnName("Register_title");
            this.Property(t => t.Register_detail).HasColumnName("Register_detail");
            this.Property(t => t.Register_cat).HasColumnName("Register_cat");
            this.Property(t => t.Register_type).HasColumnName("Register_type");
            this.Property(t => t.Register_stat).HasColumnName("Register_stat");
            this.Property(t => t.Condition).HasColumnName("Condition");
            this.Property(t => t.Criteria).HasColumnName("Criteria");
            this.Property(t => t.Cause).HasColumnName("Cause");
            this.Property(t => t.Effect).HasColumnName("Effect");
            this.Property(t => t.Register_prog).HasColumnName("Register_prog");
            this.Property(t => t.Strat_object).HasColumnName("Strat_object");
            this.Property(t => t.Inherent_rate).HasColumnName("Inherent_rate");
            this.Property(t => t.Reg_creator).HasColumnName("Reg_creator");
            this.Property(t => t.Approver).HasColumnName("Approver");
            this.Property(t => t.Owner).HasColumnName("Owner");
            this.Property(t => t.Reg_responsible).HasColumnName("Reg_responsible");
            this.Property(t => t.Reg_sched_start_date).HasColumnName("Reg_sched_start_date");
            this.Property(t => t.Reg_date_sched_end).HasColumnName("Reg_date_sched_end");
            this.Property(t => t.Date_comp_required).HasColumnName("Date_comp_required");
            this.Property(t => t.Reg_start_date).HasColumnName("Reg_start_date");
            this.Property(t => t.Reg_end_date).HasColumnName("Reg_end_date");
            this.Property(t => t.Root_cause).HasColumnName("Root_cause");
            this.Property(t => t.Exist_control).HasColumnName("Exist_control");
            this.Property(t => t.Current_res_rate).HasColumnName("Current_res_rate");
            this.Property(t => t.Further_action).HasColumnName("Further_action");
            this.Property(t => t.Reg_rel_for).HasColumnName("Reg_rel_for");
            this.Property(t => t.Reg_comp_num).HasColumnName("Reg_comp_num");
            this.Property(t => t.Reg_pers_num).HasColumnName("Reg_pers_num");
            this.Property(t => t.Reg_equip_num).HasColumnName("Reg_equip_num");
            this.Property(t => t.Reg_lic_num).HasColumnName("Reg_lic_num");
            this.Property(t => t.Reg_loc_num).HasColumnName("Reg_loc_num");
            this.Property(t => t.Reg_SR_ID).HasColumnName("Reg_SR_ID");
            this.Property(t => t.Reg_priv_ind).HasColumnName("Reg_priv_ind");
            this.Property(t => t.Reg_priv_ind_licensing).HasColumnName("Reg_priv_ind_licensing");
            this.Property(t => t.Reg_priv_ind_GC).HasColumnName("Reg_priv_ind_GC");
            this.Property(t => t.Reg_priv_ind_audit).HasColumnName("Reg_priv_ind_audit");
            this.Property(t => t.Reg_priv_ind_FI).HasColumnName("Reg_priv_ind_FI");
            this.Property(t => t.Reg_priv_ind_legal).HasColumnName("Reg_priv_ind_legal");
            this.Property(t => t.Reg_priv_ind_SED).HasColumnName("Reg_priv_ind_SED");
            this.Property(t => t.Reg_priv_ind_HR).HasColumnName("Reg_priv_ind_HR");
            this.Property(t => t.Reg_priv_ind_risk).HasColumnName("Reg_priv_ind_risk");
            this.Property(t => t.Reg_priv_ind_CS).HasColumnName("Reg_priv_ind_CS");
            this.Property(t => t.Reg_priv_ind_comms).HasColumnName("Reg_priv_ind_comms");
            this.Property(t => t.Reg_priv_ind_IT).HasColumnName("Reg_priv_ind_IT");
            this.Property(t => t.Reg_priv_ind_Board).HasColumnName("Reg_priv_ind_Board");
            this.Property(t => t.Reg_priv_role).HasColumnName("Reg_priv_role");
            this.Property(t => t.Reg_priv_group_1).HasColumnName("Reg_priv_group_1");
            this.Property(t => t.Reg_priv_group_2).HasColumnName("Reg_priv_group_2");
            this.Property(t => t.Reg_priv_group_3).HasColumnName("Reg_priv_group_3");
            this.Property(t => t.Reg_priv_group_4).HasColumnName("Reg_priv_group_4");
            this.Property(t => t.Reg_priv_group_5).HasColumnName("Reg_priv_group_5");
            this.Property(t => t.Reg_priv_group_6).HasColumnName("Reg_priv_group_6");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Registers)
                .HasForeignKey(d => d.Reg_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Registers)
                .HasForeignKey(d => d.Reg_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Registers)
                .HasForeignKey(d => d.Reg_lic_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Registers)
                .HasForeignKey(d => d.Reg_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Registers)
                .HasForeignKey(d => d.Reg_pers_num);
            this.HasRequired(t => t.Service_request)
                .WithMany(t => t.Registers)
                .HasForeignKey(d => d.Reg_SR_ID);
        }
    }
}
