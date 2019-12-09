namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Software" />
    /// </summary>
    public partial class Software : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Software_name
        /// </summary>
        public string Software_name { get; set; }

        /// <summary>
        /// Gets or sets the Sof_nrcs_cert_number
        /// </summary>
        public string Sof_nrcs_cert_number { get; set; }

        /// <summary>
        /// Gets or sets the Soft_nrcs_cert_issue_date
        /// </summary>
        public Nullable<System.DateTime> Soft_nrcs_cert_issue_date { get; set; }

        /// <summary>
        /// Gets or sets the Soft_nrcs_cert_re_issue_date
        /// </summary>
        public Nullable<System.DateTime> Soft_nrcs_cert_re_issue_date { get; set; }

        /// <summary>
        /// Gets or sets the Soft_nrcs_LOC_num
        /// </summary>
        public string Soft_nrcs_LOC_num { get; set; }

        /// <summary>
        /// Gets or sets the Software_cat
        /// </summary>
        public int Software_cat { get; set; }

        /// <summary>
        /// Gets or sets the Software_type
        /// </summary>
        public int Software_type { get; set; }

        /// <summary>
        /// Gets or sets the Software_stat
        /// </summary>
        public int Software_stat { get; set; }

        /// <summary>
        /// Gets or sets the Software_from_date
        /// </summary>
        public System.DateTime Software_from_date { get; set; }

        /// <summary>
        /// Gets or sets the Software_to_date
        /// </summary>
        public Nullable<System.DateTime> Software_to_date { get; set; }
    }
}
