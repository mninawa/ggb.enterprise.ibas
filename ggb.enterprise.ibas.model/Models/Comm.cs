namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Comm" />
    /// </summary>
    public partial class Comm : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Comm_subject
        /// </summary>
        public string Comm_subject { get; set; }

        /// <summary>
        /// Gets or sets the Comm_cat
        /// </summary>
        public int Comm_cat { get; set; }

        /// <summary>
        /// Gets or sets the Comm_type
        /// </summary>
        public int Comm_type { get; set; }

        /// <summary>
        /// Gets or sets the Comm_stat
        /// </summary>
        public int Comm_stat { get; set; }

        /// <summary>
        /// Gets or sets the Comm_author
        /// </summary>
        public string Comm_author { get; set; }

        /// <summary>
        /// Gets or sets the Comm_to
        /// </summary>
        public string Comm_to { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priority
        /// </summary>
        public int Comm_priority { get; set; }

        /// <summary>
        /// Gets or sets the Comms_desc
        /// </summary>
        public string Comms_desc { get; set; }

        /// <summary>
        /// Gets or sets the Comm_date
        /// </summary>
        public System.DateTime Comm_date { get; set; }

        /// <summary>
        /// Gets or sets the Comm_time
        /// </summary>
        public System.TimeSpan Comm_time { get; set; }

        /// <summary>
        /// Gets or sets the Response
        /// </summary>
        public string Response { get; set; }

        /// <summary>
        /// Gets or sets the Comm_rel_for
        /// </summary>
        public int Comm_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Comm_comp_num
        /// </summary>
        public Nullable<int> Comm_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Comm_pers_num
        /// </summary>
        public Nullable<int> Comm_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Comm_equip_num
        /// </summary>
        public Nullable<int> Comm_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Comm_lic_num
        /// </summary>
        public Nullable<int> Comm_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the Comm_loc_num
        /// </summary>
        public Nullable<int> Comm_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Comm_SR_ID
        /// </summary>
        public int Comm_SR_ID { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind
        /// </summary>
        public int Comm_priv_ind { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_licensing
        /// </summary>
        public Nullable<bool> Comm_priv_ind_licensing { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_GC
        /// </summary>
        public Nullable<bool> Comm_priv_ind_GC { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind
        /// </summary>
        public Nullable<bool> Doc_priv_ind { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_licensing
        /// </summary>
        public Nullable<bool> Doc_priv_ind_licensing { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_GC
        /// </summary>
        public Nullable<bool> Doc_priv_ind_GC { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_audit
        /// </summary>
        public Nullable<bool> Comm_priv_ind_audit { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_FI
        /// </summary>
        public Nullable<bool> Comm_priv_ind_FI { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_legal
        /// </summary>
        public Nullable<bool> Comm_priv_ind_legal { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_SED
        /// </summary>
        public Nullable<bool> Comm_priv_ind_SED { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_HR
        /// </summary>
        public Nullable<bool> Comm_priv_ind_HR { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_risk
        /// </summary>
        public Nullable<bool> Comm_priv_ind_risk { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_CS
        /// </summary>
        public Nullable<bool> Comm_priv_ind_CS { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_comms
        /// </summary>
        public Nullable<bool> Comm_priv_ind_comms { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_IT
        /// </summary>
        public Nullable<bool> Comm_priv_ind_IT { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_ind_Board
        /// </summary>
        public Nullable<bool> Comm_priv_ind_Board { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_role
        /// </summary>
        public int Comm_priv_role { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_group_1
        /// </summary>
        public Nullable<bool> Comm_priv_group_1 { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_group_2
        /// </summary>
        public Nullable<bool> Comm_priv_group_2 { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_group_3
        /// </summary>
        public Nullable<bool> Comm_priv_group_3 { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_group_4
        /// </summary>
        public Nullable<bool> Comm_priv_group_4 { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_group_5
        /// </summary>
        public Nullable<bool> Comm_priv_group_5 { get; set; }

        /// <summary>
        /// Gets or sets the Comm_priv_group_6
        /// </summary>
        public Nullable<bool> Comm_priv_group_6 { get; set; }

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
