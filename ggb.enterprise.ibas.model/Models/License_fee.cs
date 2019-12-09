namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="License_fee" />
    /// </summary>
    public partial class License_fee : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Fee_rel_for
        /// </summary>
        public int Fee_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Licfee_comp_num
        /// </summary>
        public Nullable<int> Licfee_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Fee_pers_num
        /// </summary>
        public Nullable<int> Fee_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Fee_equip_num
        /// </summary>
        public Nullable<int> Fee_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Fee_lic_num
        /// </summary>
        public Nullable<int> Fee_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the Fee_loc_num
        /// </summary>
        public int Fee_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Fee_SR_ID
        /// </summary>
        public int Fee_SR_ID { get; set; }

        /// <summary>
        /// Gets or sets the Fee_pay_type
        /// </summary>
        public Nullable<int> Fee_pay_type { get; set; }

        /// <summary>
        /// Gets or sets the Fee_type
        /// </summary>
        public int Fee_type { get; set; }

        /// <summary>
        /// Gets or sets the Fee_type_cat
        /// </summary>
        public int Fee_type_cat { get; set; }

        /// <summary>
        /// Gets or sets the Fee_type_subcat
        /// </summary>
        public Nullable<int> Fee_type_subcat { get; set; }

        /// <summary>
        /// Gets or sets the Fee_amount
        /// </summary>
        public decimal Fee_amount { get; set; }

        /// <summary>
        /// Gets or sets the Fee_pay_stat
        /// </summary>
        public Nullable<int> Fee_pay_stat { get; set; }

        /// <summary>
        /// Gets or sets the Fee_pay_confirm_by
        /// </summary>
        public System.DateTime Fee_pay_confirm_by { get; set; }

        /// <summary>
        /// Gets or sets the Fee_pay_date
        /// </summary>
        public System.DateTime Fee_pay_date { get; set; }

        /// <summary>
        /// Gets or sets the Fee_lic_type
        /// </summary>
        public int Fee_lic_type { get; set; }

        /// <summary>
        /// Gets or sets the Fee_audit_Ind
        /// </summary>
        public Nullable<int> Fee_audit_Ind { get; set; }

        /// <summary>
        /// Gets or sets the Fee_audit_note
        /// </summary>
        public string Fee_audit_note { get; set; }

        /// <summary>
        /// Gets or sets the Fee_audit_date
        /// </summary>
        public Nullable<System.DateTime> Fee_audit_date { get; set; }

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
