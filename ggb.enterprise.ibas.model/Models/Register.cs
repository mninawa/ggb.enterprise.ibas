namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Register" />
    /// </summary>
    public partial class Register : EntityBase<string>
    {
        /// <summary>
        /// Gets or sets the Register_title
        /// </summary>
        public string Register_title { get; set; }

        /// <summary>
        /// Gets or sets the Register_detail
        /// </summary>
        public string Register_detail { get; set; }

        /// <summary>
        /// Gets or sets the Register_cat
        /// </summary>
        public int Register_cat { get; set; }

        /// <summary>
        /// Gets or sets the Register_type
        /// </summary>
        public int Register_type { get; set; }

        /// <summary>
        /// Gets or sets the Register_stat
        /// </summary>
        public int Register_stat { get; set; }

        /// <summary>
        /// Gets or sets the Condition
        /// </summary>
        public Nullable<int> Condition { get; set; }

        /// <summary>
        /// Gets or sets the Criteria
        /// </summary>
        public Nullable<int> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the Cause
        /// </summary>
        public Nullable<int> Cause { get; set; }

        /// <summary>
        /// Gets or sets the Effect
        /// </summary>
        public Nullable<int> Effect { get; set; }

        /// <summary>
        /// Gets or sets the Register_prog
        /// </summary>
        public Nullable<int> Register_prog { get; set; }

        /// <summary>
        /// Gets or sets the Strat_object
        /// </summary>
        public Nullable<int> Strat_object { get; set; }

        /// <summary>
        /// Gets or sets the Inherent_rate
        /// </summary>
        public Nullable<int> Inherent_rate { get; set; }

        /// <summary>
        /// Gets or sets the Reg_creator
        /// </summary>
        public string Reg_creator { get; set; }

        /// <summary>
        /// Gets or sets the Approver
        /// </summary>
        public string Approver { get; set; }

        /// <summary>
        /// Gets or sets the Owner
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the Reg_responsible
        /// </summary>
        public string Reg_responsible { get; set; }

        /// <summary>
        /// Gets or sets the Reg_sched_start_date
        /// </summary>
        public System.DateTime Reg_sched_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Reg_date_sched_end
        /// </summary>
        public System.DateTime Reg_date_sched_end { get; set; }

        /// <summary>
        /// Gets or sets the Date_comp_required
        /// </summary>
        public System.DateTime Date_comp_required { get; set; }

        /// <summary>
        /// Gets or sets the Reg_start_date
        /// </summary>
        public Nullable<System.DateTime> Reg_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Reg_end_date
        /// </summary>
        public Nullable<System.DateTime> Reg_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Root_cause
        /// </summary>
        public string Root_cause { get; set; }

        /// <summary>
        /// Gets or sets the Exist_control
        /// </summary>
        public string Exist_control { get; set; }

        /// <summary>
        /// Gets or sets the Current_res_rate
        /// </summary>
        public Nullable<int> Current_res_rate { get; set; }

        /// <summary>
        /// Gets or sets the Further_action
        /// </summary>
        public string Further_action { get; set; }

        /// <summary>
        /// Gets or sets the Reg_rel_for
        /// </summary>
        public int Reg_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Reg_comp_num
        /// </summary>
        public Nullable<int> Reg_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Reg_pers_num
        /// </summary>
        public Nullable<int> Reg_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Reg_equip_num
        /// </summary>
        public Nullable<int> Reg_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Reg_lic_num
        /// </summary>
        public Nullable<int> Reg_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the Reg_loc_num
        /// </summary>
        public Nullable<int> Reg_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Reg_SR_ID
        /// </summary>
        public int Reg_SR_ID { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind
        /// </summary>
        public int Reg_priv_ind { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_licensing
        /// </summary>
        public Nullable<bool> Reg_priv_ind_licensing { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_GC
        /// </summary>
        public Nullable<bool> Reg_priv_ind_GC { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_audit
        /// </summary>
        public Nullable<bool> Reg_priv_ind_audit { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_FI
        /// </summary>
        public Nullable<bool> Reg_priv_ind_FI { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_legal
        /// </summary>
        public Nullable<bool> Reg_priv_ind_legal { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_SED
        /// </summary>
        public Nullable<bool> Reg_priv_ind_SED { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_HR
        /// </summary>
        public Nullable<bool> Reg_priv_ind_HR { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_risk
        /// </summary>
        public Nullable<bool> Reg_priv_ind_risk { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_CS
        /// </summary>
        public Nullable<bool> Reg_priv_ind_CS { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_comms
        /// </summary>
        public Nullable<bool> Reg_priv_ind_comms { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_IT
        /// </summary>
        public Nullable<bool> Reg_priv_ind_IT { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_ind_Board
        /// </summary>
        public Nullable<bool> Reg_priv_ind_Board { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_role
        /// </summary>
        public int Reg_priv_role { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_group_1
        /// </summary>
        public Nullable<bool> Reg_priv_group_1 { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_group_2
        /// </summary>
        public Nullable<bool> Reg_priv_group_2 { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_group_3
        /// </summary>
        public Nullable<bool> Reg_priv_group_3 { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_group_4
        /// </summary>
        public Nullable<bool> Reg_priv_group_4 { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_group_5
        /// </summary>
        public Nullable<bool> Reg_priv_group_5 { get; set; }

        /// <summary>
        /// Gets or sets the Reg_priv_group_6
        /// </summary>
        public Nullable<bool> Reg_priv_group_6 { get; set; }

        /// <summary>
        /// Gets or sets the Company
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the Equipment
        /// </summary>
        public virtual Equipment Equipment { get; set; }

        /// <summary>
        /// Gets or sets the Licence
        /// </summary>
        public virtual Licence Licence { get; set; }

        /// <summary>
        /// Gets or sets the Location
        /// </summary>
        public virtual Location Location { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual Service_request Service_request { get; set; }
    }
}
