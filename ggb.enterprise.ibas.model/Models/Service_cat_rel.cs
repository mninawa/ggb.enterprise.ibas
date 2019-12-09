namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Service_cat_rel" />
    /// </summary>
    public partial class Service_cat_rel : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Serv_comp_cat
        /// </summary>
        public int Serv_comp_cat { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Relevance_ind
        /// </summary>
        public bool Relevance_ind { get; set; }
    }
}
