namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="sysdiagram" />
    /// </summary>
    public partial class sysdiagram : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the principal_id
        /// </summary>
        public int principal_id { get; set; }

        /// <summary>
        /// Gets or sets the version
        /// </summary>
        public Nullable<int> version { get; set; }

        /// <summary>
        /// Gets or sets the definition
        /// </summary>
        public byte[] definition { get; set; }
    }
}
