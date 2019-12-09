namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Comp_alloc" />
    /// </summary>
    public partial class Comp_alloc : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Alloc_depart
        /// </summary>
        public int Alloc_depart { get; set; }

        /// <summary>
        /// Gets or sets the Aloc_bus_role
        /// </summary>
        public int Aloc_bus_role { get; set; }

        /// <summary>
        /// Gets or sets the Perform_Year
        /// </summary>
        public string Perform_Year { get; set; }

        /// <summary>
        /// Gets or sets the Perform_quarter
        /// </summary>
        public string Perform_quarter { get; set; }

        /// <summary>
        /// Gets or sets the Alloc_pers_num
        /// </summary>
        public Nullable<int> Alloc_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the From_yearmonth
        /// </summary>
        public string From_yearmonth { get; set; }

        /// <summary>
        /// Gets or sets the To_yearmonth
        /// </summary>
        public string To_yearmonth { get; set; }

        /// <summary>
        /// Gets or sets the Company
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
