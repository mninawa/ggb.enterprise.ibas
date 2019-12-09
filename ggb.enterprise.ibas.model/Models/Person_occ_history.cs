namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Person_occ_history" />
    /// </summary>
    public partial class Person_occ_history : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Occ_emp_name
        /// </summary>
        public string Occ_emp_name { get; set; }

        /// <summary>
        /// Gets or sets the Job_title
        /// </summary>
        public int Job_title { get; set; }

        /// <summary>
        /// Gets or sets the Job_start_date
        /// </summary>
        public System.DateTime Job_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Job_end_date
        /// </summary>
        public System.DateTime Job_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Duties
        /// </summary>
        public string Duties { get; set; }

        /// <summary>
        /// Gets or sets the Person_employ
        /// </summary>
        public virtual Person_employ Person_employ { get; set; }
    }
}
