namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Hardware" />
    /// </summary>
    public partial class Hardware : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Hardware_name
        /// </summary>
        public string Hardware_name { get; set; }

        /// <summary>
        /// Gets or sets the Cab_manufact_date
        /// </summary>
        public System.DateTime Cab_manufact_date { get; set; }

        /// <summary>
        /// Gets or sets the Hardware_cat
        /// </summary>
        public int Hardware_cat { get; set; }

        /// <summary>
        /// Gets or sets the Hardware_type
        /// </summary>
        public int Hardware_type { get; set; }

        /// <summary>
        /// Gets or sets the Hardware_stat
        /// </summary>
        public int Hardware_stat { get; set; }

        /// <summary>
        /// Gets or sets the Hardware_from_date
        /// </summary>
        public System.DateTime Hardware_from_date { get; set; }

        /// <summary>
        /// Gets or sets the Hardware_to_date
        /// </summary>
        public Nullable<System.DateTime> Hardware_to_date { get; set; }
    }
}
