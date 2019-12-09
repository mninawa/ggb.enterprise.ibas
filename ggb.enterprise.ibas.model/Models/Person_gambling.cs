namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Person_gambling" />
    /// </summary>
    public partial class Person_gambling : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Gamb_rel_for
        /// </summary>
        public int Gamb_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Gambling_company_num
        /// </summary>
        public Nullable<int> Gambling_company_num { get; set; }

        /// <summary>
        /// Gets or sets the Gamb_ent_number
        /// </summary>
        public Nullable<int> Gamb_ent_number { get; set; }

        /// <summary>
        /// Gets or sets the Gamb_lic_type
        /// </summary>
        public int Gamb_lic_type { get; set; }

        /// <summary>
        /// Gets or sets the Jurisdiction
        /// </summary>
        public Nullable<int> Jurisdiction { get; set; }

        /// <summary>
        /// Gets or sets the Gam_start_date
        /// </summary>
        public Nullable<System.DateTime> Gam_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Gam_end_Date
        /// </summary>
        public System.DateTime Gam_end_Date { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Gets or sets the Entity
        /// </summary>
        public virtual Entity Entity { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
