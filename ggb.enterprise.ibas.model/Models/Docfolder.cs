namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Docfolder" />
    /// </summary>
    public partial class Docfolder : EntityBase<string>
    {
        /// <summary>
        /// Gets or sets the Docfold_desc
        /// </summary>
        public string Docfold_desc { get; set; }

        /// <summary>
        /// Gets or sets the Hierarchy_ids
        /// </summary>
        public string Hierarchy_ids { get; set; }

        /// <summary>
        /// Gets or sets the Summary
        /// </summary>
        public string Summary { get; set; }
    }
}
