namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Profess_history" />
    /// </summary>
    public partial class Profess_history : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Professional_num
        /// </summary>
        public int Professional_num { get; set; }

        /// <summary>
        /// Gets or sets the Institution
        /// </summary>
        public string Institution { get; set; }

        /// <summary>
        /// Gets or sets the Prof_type
        /// </summary>
        public int Prof_type { get; set; }

        /// <summary>
        /// Gets or sets the Prof_start_date
        /// </summary>
        public System.DateTime Prof_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Prof_end_date
        /// </summary>
        public System.DateTime Prof_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Prof_year_comp
        /// </summary>
        public string Prof_year_comp { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
