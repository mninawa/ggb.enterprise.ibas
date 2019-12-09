namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Standard" />
    /// </summary>
    public partial class Standard : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Standard_desc
        /// </summary>
        public string Standard_desc { get; set; }

        /// <summary>
        /// Gets or sets the Standard_cat
        /// </summary>
        public int Standard_cat { get; set; }

        /// <summary>
        /// Gets or sets the Standard_type
        /// </summary>
        public int Standard_type { get; set; }

        /// <summary>
        /// Gets or sets the Standard_stat
        /// </summary>
        public int Standard_stat { get; set; }

        /// <summary>
        /// Gets or sets the Standard_from_date
        /// </summary>
        public System.DateTime Standard_from_date { get; set; }

        /// <summary>
        /// Gets or sets the Standard_to_date
        /// </summary>
        public Nullable<System.DateTime> Standard_to_date { get; set; }
    }
}
