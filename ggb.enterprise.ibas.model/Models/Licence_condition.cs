namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Licence_condition" />
    /// </summary>
    public partial class Licence_condition : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Cond_num
        /// </summary>
        public int Cond_num { get; set; }

        /// <summary>
        /// Gets or sets the Cond_type
        /// </summary>
        public int Cond_type { get; set; }

        /// <summary>
        /// Gets or sets the Cond_dict_num
        /// </summary>
        public string Cond_dict_num { get; set; }

        /// <summary>
        /// Gets or sets the Cond_desc
        /// </summary>
        public string Cond_desc { get; set; }

        /// <summary>
        /// Gets or sets the Cond_reason
        /// </summary>
        public string Cond_reason { get; set; }

        /// <summary>
        /// Gets or sets the Cond_stat
        /// </summary>
        public int Cond_stat { get; set; }

        /// <summary>
        /// Gets or sets the Cond_start_date
        /// </summary>
        public System.DateTime Cond_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Cond_end_date
        /// </summary>
        public System.DateTime Cond_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Licence
        /// </summary>
        public virtual Licence Licence { get; set; }
    }
}
