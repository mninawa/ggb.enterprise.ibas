namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Enum_list" />
    /// </summary>
    public partial class Enum_list : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Enum_type
        /// </summary>
        public string Enum_type { get; set; }

        /// <summary>
        /// Gets or sets the Enum_value
        /// </summary>
        public string Enum_value { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public string Table { get; set; }
    }
}
