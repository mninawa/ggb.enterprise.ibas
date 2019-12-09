namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="SR_recommend" />
    /// </summary>
    public partial class SR_recommend : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Recom_num
        /// </summary>
        public int Recom_num { get; set; }

        /// <summary>
        /// Gets or sets the Recom_date
        /// </summary>
        public System.DateTime Recom_date { get; set; }

        /// <summary>
        /// Gets or sets the Recom_stat
        /// </summary>
        public int Recom_stat { get; set; }

        /// <summary>
        /// Gets or sets the Recom_dict_num
        /// </summary>
        public int Recom_dict_num { get; set; }

        /// <summary>
        /// Gets or sets the Recom_desc
        /// </summary>
        public string Recom_desc { get; set; }

        /// <summary>
        /// Gets or sets the Dictionary
        /// </summary>
        public virtual Dictionary Dictionary { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual Service_request Service_request { get; set; }
    }
}
