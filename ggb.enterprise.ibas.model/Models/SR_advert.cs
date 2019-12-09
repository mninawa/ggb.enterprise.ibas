namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="SR_advert" />
    /// </summary>
    public partial class SR_advert : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Adv_desc
        /// </summary>
        public string Adv_desc { get; set; }

        /// <summary>
        /// Gets or sets the Adv_start_date
        /// </summary>
        public System.DateTime Adv_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Adv_end_date
        /// </summary>
        public System.DateTime Adv_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual Service_request Service_request { get; set; }
    }
}
