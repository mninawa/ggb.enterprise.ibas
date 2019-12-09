namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Ques_ans" />
    /// </summary>
    public partial class Ques_ans : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the QA_rel_for
        /// </summary>
        public int QA_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the QA_comp_num
        /// </summary>
        public Nullable<int> QA_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the QA_pers_num
        /// </summary>
        public Nullable<int> QA_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the QA_equip_num
        /// </summary>
        public Nullable<int> QA_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the QA_lic_num
        /// </summary>
        public Nullable<int> QA_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the QA_loc_num
        /// </summary>
        public Nullable<int> QA_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the QA_SR_ID
        /// </summary>
        public int QA_SR_ID { get; set; }

        /// <summary>
        /// Gets or sets the Ques_num
        /// </summary>
        public int Ques_num { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether QA_ind
        /// </summary>
        public bool QA_ind { get; set; }

        /// <summary>
        /// Gets or sets the QA_detail
        /// </summary>
        public string QA_detail { get; set; }

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
