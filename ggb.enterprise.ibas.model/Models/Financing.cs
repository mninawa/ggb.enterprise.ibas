namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Financing" />
    /// </summary>
    public partial class Financing : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Payment_type
        /// </summary>
        public Nullable<int> Payment_type { get; set; }

        /// <summary>
        /// Gets or sets the FI_rel_for
        /// </summary>
        public int FI_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the FI_comp_num
        /// </summary>
        public Nullable<int> FI_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the FI_pers_num
        /// </summary>
        public Nullable<int> FI_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Equip_num
        /// </summary>
        public Nullable<int> Equip_num { get; set; }

        /// <summary>
        /// Gets or sets the FI_lic_num
        /// </summary>
        public Nullable<int> FI_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the FI_loc_num
        /// </summary>
        public Nullable<int> FI_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Payment_Status
        /// </summary>
        public Nullable<int> Payment_Status { get; set; }

        /// <summary>
        /// Gets or sets the FI_ref_num
        /// </summary>
        public Nullable<int> FI_ref_num { get; set; }

        /// <summary>
        /// Gets or sets the Finance_note
        /// </summary>
        public string Finance_note { get; set; }

        /// <summary>
        /// Gets or sets the FI_acc_num
        /// </summary>
        public Nullable<int> FI_acc_num { get; set; }

        /// <summary>
        /// Gets or sets the Types_FI_facility
        /// </summary>
        public string Types_FI_facility { get; set; }

        /// <summary>
        /// Gets or sets the Amount_facility
        /// </summary>
        public Nullable<decimal> Amount_facility { get; set; }

        /// <summary>
        /// Gets or sets the Repayment_Period
        /// </summary>
        public string Repayment_Period { get; set; }

        /// <summary>
        /// Gets or sets the Repayment_Terms
        /// </summary>
        public string Repayment_Terms { get; set; }

        /// <summary>
        /// Gets or sets the FI_ent_number
        /// </summary>
        public string FI_ent_number { get; set; }

        /// <summary>
        /// Gets or sets the Finance_num
        /// </summary>
        public int Finance_num { get; set; }

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
