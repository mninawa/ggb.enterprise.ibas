namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="SR_status_hist" />
    /// </summary>
    public partial class SR_status_hist : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Stat_change_date
        /// </summary>
        public System.DateTime Stat_change_date { get; set; }

        /// <summary>
        /// Gets or sets the Stat_change_time
        /// </summary>
        public System.TimeSpan Stat_change_time { get; set; }

        /// <summary>
        /// Gets or sets the SR_stat_before
        /// </summary>
        public int SR_stat_before { get; set; }

        /// <summary>
        /// Gets or sets the SR_stat_after
        /// </summary>
        public int SR_stat_after { get; set; }

        /// <summary>
        /// Gets or sets the SR_Business_role
        /// </summary>
        public int SR_Business_role { get; set; }

        /// <summary>
        /// Gets or sets the Assigned_to
        /// </summary>
        public int Assigned_to { get; set; }

        /// <summary>
        /// Gets or sets the Response_by
        /// </summary>
        public int Response_by { get; set; }

        /// <summary>
        /// Gets or sets the Date_responded
        /// </summary>
        public System.DateTime Date_responded { get; set; }

        /// <summary>
        /// Gets or sets the Comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual Service_request Service_request { get; set; }

        /// <summary>
        /// Gets or sets the User
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the User1
        /// </summary>
        public virtual User User1 { get; set; }
    }
}
