namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Licence_term" />
    /// </summary>
    public partial class Licence_term : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Term_num
        /// </summary>
        public int Term_num { get; set; }

        /// <summary>
        /// Gets or sets the Term_type
        /// </summary>
        public int Term_type { get; set; }

        /// <summary>
        /// Gets or sets the Term_dict_num
        /// </summary>
        public string Term_dict_num { get; set; }

        /// <summary>
        /// Gets or sets the Term_desc
        /// </summary>
        public string Term_desc { get; set; }

        /// <summary>
        /// Gets or sets the Term_reason
        /// </summary>
        public string Term_reason { get; set; }

        /// <summary>
        /// Gets or sets the Term_stat
        /// </summary>
        public int Term_stat { get; set; }

        /// <summary>
        /// Gets or sets the Term_start_date
        /// </summary>
        public System.DateTime Term_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Term_end_date
        /// </summary>
        public System.DateTime Term_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Licence
        /// </summary>
        public virtual Licence Licence { get; set; }
    }
}
