namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Event" />
    /// </summary>
    public partial class Event : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        public Event()
        {
            this.Comp_rel = new List<Comp_rel>();
        }

        /// <summary>
        /// Gets or sets the Event_title
        /// </summary>
        public string Event_title { get; set; }

        /// <summary>
        /// Gets or sets the Event_detail
        /// </summary>
        public string Event_detail { get; set; }

        /// <summary>
        /// Gets or sets the Event_cat
        /// </summary>
        public int Event_cat { get; set; }

        /// <summary>
        /// Gets or sets the Event_type
        /// </summary>
        public int Event_type { get; set; }

        /// <summary>
        /// Gets or sets the Event_stat
        /// </summary>
        public int Event_stat { get; set; }

        /// <summary>
        /// Gets or sets the Event_prior
        /// </summary>
        public int Event_prior { get; set; }

        /// <summary>
        /// Gets or sets the Criticality
        /// </summary>
        public int Criticality { get; set; }

        /// <summary>
        /// Gets or sets the Ev_creator
        /// </summary>
        public int Ev_creator { get; set; }

        /// <summary>
        /// Gets or sets the Event_approver
        /// </summary>
        public Nullable<int> Event_approver { get; set; }

        /// <summary>
        /// Gets or sets the Ev_responsible
        /// </summary>
        public int Ev_responsible { get; set; }

        /// <summary>
        /// Gets or sets the Ev_service
        /// </summary>
        public int Ev_service { get; set; }

        /// <summary>
        /// Gets or sets the Ev_sched_start_date
        /// </summary>
        public System.DateTime Ev_sched_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Ev_date_sched_end
        /// </summary>
        public Nullable<System.DateTime> Ev_date_sched_end { get; set; }

        /// <summary>
        /// Gets or sets the Ev_start_date
        /// </summary>
        public Nullable<System.DateTime> Ev_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Ev_end_date
        /// </summary>
        public Nullable<System.DateTime> Ev_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Ev_comp_req_date
        /// </summary>
        public Nullable<System.DateTime> Ev_comp_req_date { get; set; }

        /// <summary>
        /// Gets or sets the Hold_can_reason
        /// </summary>
        public string Hold_can_reason { get; set; }

        /// <summary>
        /// Gets or sets the Ev_rel_for
        /// </summary>
        public int Ev_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Ev_comp_num
        /// </summary>
        public Nullable<int> Ev_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Ev_pers_num
        /// </summary>
        public Nullable<int> Ev_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Ev_equip_num
        /// </summary>
        public Nullable<int> Ev_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Ev_lic_num
        /// </summary>
        public Nullable<int> Ev_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the Ev_loc_num
        /// </summary>
        public Nullable<int> Ev_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Ev_SR_ID
        /// </summary>
        public Nullable<int> Ev_SR_ID { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind
        /// </summary>
        public int Ev_priv_ind { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_licensing
        /// </summary>
        public Nullable<bool> Ev_priv_ind_licensing { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_GC
        /// </summary>
        public Nullable<bool> Ev_priv_ind_GC { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_audit
        /// </summary>
        public Nullable<bool> Ev_priv_ind_audit { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_FI
        /// </summary>
        public Nullable<bool> Ev_priv_ind_FI { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_legal
        /// </summary>
        public Nullable<bool> Ev_priv_ind_legal { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_SED
        /// </summary>
        public Nullable<bool> Ev_priv_ind_SED { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_HR
        /// </summary>
        public Nullable<bool> Ev_priv_ind_HR { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_risk
        /// </summary>
        public Nullable<bool> Ev_priv_ind_risk { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_CS
        /// </summary>
        public Nullable<bool> Ev_priv_ind_CS { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_comms
        /// </summary>
        public Nullable<bool> Ev_priv_ind_comms { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_IT
        /// </summary>
        public Nullable<bool> Ev_priv_ind_IT { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_ind_Board
        /// </summary>
        public Nullable<bool> Ev_priv_ind_Board { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_role
        /// </summary>
        public int Ev_priv_role { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_group_1
        /// </summary>
        public Nullable<bool> Ev_priv_group_1 { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_group_2
        /// </summary>
        public Nullable<bool> Ev_priv_group_2 { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_group_3
        /// </summary>
        public Nullable<bool> Ev_priv_group_3 { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_group_4
        /// </summary>
        public Nullable<bool> Ev_priv_group_4 { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_group_5
        /// </summary>
        public Nullable<bool> Ev_priv_group_5 { get; set; }

        /// <summary>
        /// Gets or sets the Ev_priv_group_6
        /// </summary>
        public Nullable<bool> Ev_priv_group_6 { get; set; }

        /// <summary>
        /// Gets or sets the Comp_rel
        /// </summary>
        public virtual ICollection<Comp_rel> Comp_rel { get; set; }

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
