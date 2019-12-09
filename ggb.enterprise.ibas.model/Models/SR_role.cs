namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="SR_role" />
    /// </summary>
    public partial class SR_role : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the SR_role_pers_num
        /// </summary>
        public int SR_role_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the App_role
        /// </summary>
        public int App_role { get; set; }

        /// <summary>
        /// Gets or sets the Role_start_date
        /// </summary>
        public System.DateTime Role_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Role_end_date
        /// </summary>
        public System.DateTime Role_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual Service_request Service_request { get; set; }
    }
}
