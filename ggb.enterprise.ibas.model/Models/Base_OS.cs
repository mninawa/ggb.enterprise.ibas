namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Base_OS" />
    /// </summary>
    public partial class Base_OS : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Base_OS_operating_name
        /// </summary>
        public string Base_OS_operating_name { get; set; }

        /// <summary>
        /// Gets or sets the Base_OS_cat
        /// </summary>
        public int Base_OS_cat { get; set; }

        /// <summary>
        /// Gets or sets the Base_OS_type
        /// </summary>
        public int Base_OS_type { get; set; }

        /// <summary>
        /// Gets or sets the Base_OS_stat
        /// </summary>
        public int Base_OS_stat { get; set; }

        /// <summary>
        /// Gets or sets the Base_OS_from_date
        /// </summary>
        public System.DateTime Base_OS_from_date { get; set; }

        /// <summary>
        /// Gets or sets the Base_OS_to_date
        /// </summary>
        public Nullable<System.DateTime> Base_OS_to_date { get; set; }

        /// <summary>
        /// Gets or sets the Base_OS_value
        /// </summary>
        public string Base_OS_value { get; set; }
    }
}
