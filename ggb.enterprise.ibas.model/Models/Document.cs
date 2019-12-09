namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Document" />
    /// </summary>
    public partial class Document : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Doc_name
        /// </summary>
        public string Doc_name { get; set; }

        /// <summary>
        /// Gets or sets the Doc_cat
        /// </summary>
        public int Doc_cat { get; set; }

        /// <summary>
        /// Gets or sets the Doc_type
        /// </summary>
        public int Doc_type { get; set; }

        /// <summary>
        /// Gets or sets the Doc_stat
        /// </summary>
        public int Doc_stat { get; set; }

        /// <summary>
        /// Gets or sets the Doc_folder
        /// </summary>
        public string Doc_folder { get; set; }

        /// <summary>
        /// Gets or sets the URL
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Gets or sets the Doc_desc
        /// </summary>
        public string Doc_desc { get; set; }

        /// <summary>
        /// Gets or sets the Doc_author
        /// </summary>
        public string Doc_author { get; set; }

        /// <summary>
        /// Gets or sets the Doc_approver
        /// </summary>
        public string Doc_approver { get; set; }

        /// <summary>
        /// Gets or sets the Doc_date
        /// </summary>
        public System.DateTime Doc_date { get; set; }

        /// <summary>
        /// Gets or sets the Date_load
        /// </summary>
        public System.DateTime Date_load { get; set; }

        /// <summary>
        /// Gets or sets the Date_delete
        /// </summary>
        public Nullable<System.DateTime> Date_delete { get; set; }

        /// <summary>
        /// Gets or sets the Doc_review
        /// </summary>
        public int Doc_review { get; set; }

        /// <summary>
        /// Gets or sets the Doc_note
        /// </summary>
        public string Doc_note { get; set; }

        /// <summary>
        /// Gets or sets the Doc_rel_for
        /// </summary>
        public int Doc_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Doc_comp_num
        /// </summary>
        public Nullable<int> Doc_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Doc_pers_num
        /// </summary>
        public Nullable<int> Doc_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Doc_equip_num
        /// </summary>
        public Nullable<int> Doc_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Doc_lic_num
        /// </summary>
        public Nullable<int> Doc_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the Doc_loc_num
        /// </summary>
        public Nullable<int> Doc_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Doc_SR_ID
        /// </summary>
        public int Doc_SR_ID { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind
        /// </summary>
        public int Doc_priv_ind { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_licensing
        /// </summary>
        public Nullable<bool> Doc_priv_ind_licensing { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_GC
        /// </summary>
        public Nullable<bool> Doc_priv_ind_GC { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_audit
        /// </summary>
        public Nullable<bool> Doc_priv_ind_audit { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_FI
        /// </summary>
        public Nullable<bool> Doc_priv_ind_FI { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_legal
        /// </summary>
        public Nullable<bool> Doc_priv_ind_legal { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_SED
        /// </summary>
        public Nullable<bool> Doc_priv_ind_SED { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_HR
        /// </summary>
        public Nullable<bool> Doc_priv_ind_HR { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_risk
        /// </summary>
        public Nullable<bool> Doc_priv_ind_risk { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_CS
        /// </summary>
        public Nullable<bool> Doc_priv_ind_CS { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_comms
        /// </summary>
        public Nullable<bool> Doc_priv_ind_comms { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_IT
        /// </summary>
        public Nullable<bool> Doc_priv_ind_IT { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_ind_Board
        /// </summary>
        public Nullable<bool> Doc_priv_ind_Board { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_role
        /// </summary>
        public int Doc_priv_role { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_group_1
        /// </summary>
        public Nullable<bool> Doc_priv_group_1 { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_group_2
        /// </summary>
        public Nullable<bool> Doc_priv_group_2 { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_group_3
        /// </summary>
        public Nullable<bool> Doc_priv_group_3 { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_group_4
        /// </summary>
        public Nullable<bool> Doc_priv_group_4 { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_group_5
        /// </summary>
        public Nullable<bool> Doc_priv_group_5 { get; set; }

        /// <summary>
        /// Gets or sets the Doc_priv_group_6
        /// </summary>
        public Nullable<bool> Doc_priv_group_6 { get; set; }

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
