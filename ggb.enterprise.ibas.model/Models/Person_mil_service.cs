namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Person_mil_service" />
    /// </summary>
    public partial class Person_mil_service : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Military_num
        /// </summary>
        public int Military_num { get; set; }

        /// <summary>
        /// Gets or sets the Mill_country_id
        /// </summary>
        public int Mill_country_id { get; set; }

        /// <summary>
        /// Gets or sets the Arm_service
        /// </summary>
        public string Arm_service { get; set; }

        /// <summary>
        /// Gets or sets the Mill_branch
        /// </summary>
        public string Mill_branch { get; set; }

        /// <summary>
        /// Gets or sets the Mil_start_date
        /// </summary>
        public System.DateTime Mil_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Type_discharge
        /// </summary>
        public int Type_discharge { get; set; }

        /// <summary>
        /// Gets or sets the Date_discharge
        /// </summary>
        public System.DateTime Date_discharge { get; set; }

        /// <summary>
        /// Gets or sets the Rank_discharge
        /// </summary>
        public int Rank_discharge { get; set; }

        /// <summary>
        /// Gets or sets the Serial_num
        /// </summary>
        public string Serial_num { get; set; }

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
