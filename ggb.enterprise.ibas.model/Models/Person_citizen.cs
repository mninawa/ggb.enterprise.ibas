namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Person_citizen" />
    /// </summary>
    public partial class Person_citizen : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Passport_num
        /// </summary>
        public int Passport_num { get; set; }

        /// <summary>
        /// Gets or sets the ID_pass_type
        /// </summary>
        public int ID_pass_type { get; set; }

        /// <summary>
        /// Gets or sets the Country_id
        /// </summary>
        public int Country_id { get; set; }

        /// <summary>
        /// Gets or sets the Date_issue
        /// </summary>
        public System.DateTime Date_issue { get; set; }

        /// <summary>
        /// Gets or sets the Date_expire
        /// </summary>
        public System.DateTime Date_expire { get; set; }

        /// <summary>
        /// Gets or sets the Place_issue
        /// </summary>
        public string Place_issue { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
