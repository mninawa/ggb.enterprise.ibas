namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Licence_tax" />
    /// </summary>
    public partial class Licence_tax : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Tax_rel_for
        /// </summary>
        public int Tax_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Lictax_comp_num
        /// </summary>
        public Nullable<int> Lictax_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Tax_pers_num
        /// </summary>
        public Nullable<int> Tax_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Tax_equip_num
        /// </summary>
        public Nullable<int> Tax_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Tax_lic_num
        /// </summary>
        public Nullable<int> Tax_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the Tac_loc_num
        /// </summary>
        public int Tac_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Tax_SR_ID
        /// </summary>
        public int Tax_SR_ID { get; set; }

        /// <summary>
        /// Gets or sets the Tax_period
        /// </summary>
        public Nullable<int> Tax_period { get; set; }

        /// <summary>
        /// Gets or sets the Tax_payt_type
        /// </summary>
        public Nullable<int> Tax_payt_type { get; set; }

        /// <summary>
        /// Gets or sets the Tax_pay_stat
        /// </summary>
        public Nullable<int> Tax_pay_stat { get; set; }

        /// <summary>
        /// Gets or sets the Payment_confirm_by
        /// </summary>
        public System.DateTime Payment_confirm_by { get; set; }

        /// <summary>
        /// Gets or sets the Payment_date
        /// </summary>
        public System.DateTime Payment_date { get; set; }

        /// <summary>
        /// Gets or sets the Tax_lic_type
        /// </summary>
        public int Tax_lic_type { get; set; }

        /// <summary>
        /// Gets or sets the Tax_amount
        /// </summary>
        public decimal Tax_amount { get; set; }

        /// <summary>
        /// Gets or sets the Tax_audit_Ind
        /// </summary>
        public Nullable<int> Tax_audit_Ind { get; set; }

        /// <summary>
        /// Gets or sets the Tax_audit_date
        /// </summary>
        public Nullable<System.DateTime> Tax_audit_date { get; set; }

        /// <summary>
        /// Gets or sets the Tax_audit_note
        /// </summary>
        public string Tax_audit_note { get; set; }

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
