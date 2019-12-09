namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Comp_rel" />
    /// </summary>
    public partial class Comp_rel : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Comp_rel_for
        /// </summary>
        public int Comp_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Rel_comp_num
        /// </summary>
        public Nullable<int> Rel_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Rel_pers_num
        /// </summary>
        public Nullable<int> Rel_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Rel_ent_number
        /// </summary>
        public Nullable<int> Rel_ent_number { get; set; }

        /// <summary>
        /// Gets or sets the Role_type
        /// </summary>
        public Nullable<int> Role_type { get; set; }

        /// <summary>
        /// Gets or sets the Sharehold_stat
        /// </summary>
        public Nullable<int> Sharehold_stat { get; set; }

        /// <summary>
        /// Gets or sets the Shold_start_date
        /// </summary>
        public Nullable<System.DateTime> Shold_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Sharehold_end
        /// </summary>
        public Nullable<System.DateTime> Sharehold_end { get; set; }

        /// <summary>
        /// Gets or sets the Shareholding
        /// </summary>
        public Nullable<int> Shareholding { get; set; }

        /// <summary>
        /// Gets or sets the Sharehold_percent
        /// </summary>
        public Nullable<decimal> Sharehold_percent { get; set; }

        /// <summary>
        /// Gets or sets the Company
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the Company1
        /// </summary>
        public virtual Company Company1 { get; set; }

        /// <summary>
        /// Gets or sets the Event
        /// </summary>
        public virtual Event Event { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
