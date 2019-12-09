namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Offence" />
    /// </summary>
    public partial class Offence : EntityBase<string>
    {
        /// <summary>
        /// Gets or sets the Offence_type
        /// </summary>
        public int Offence_type { get; set; }

        /// <summary>
        /// Gets or sets the Off_rel_for
        /// </summary>
        public int Off_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Off_comp_num
        /// </summary>
        public Nullable<int> Off_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Off_pers_num
        /// </summary>
        public Nullable<int> Off_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Nature_offence
        /// </summary>
        public string Nature_offence { get; set; }

        /// <summary>
        /// Gets or sets the Off_details
        /// </summary>
        public string Off_details { get; set; }

        /// <summary>
        /// Gets or sets the Off_country_num
        /// </summary>
        public int Off_country_num { get; set; }

        /// <summary>
        /// Gets or sets the Off_province_num
        /// </summary>
        public Nullable<int> Off_province_num { get; set; }

        /// <summary>
        /// Gets or sets the Off_state_num
        /// </summary>
        public Nullable<int> Off_state_num { get; set; }

        /// <summary>
        /// Gets or sets the Off_municipality
        /// </summary>
        public Nullable<int> Off_municipality { get; set; }

        /// <summary>
        /// Gets or sets the Off_city_num
        /// </summary>
        public int Off_city_num { get; set; }

        /// <summary>
        /// Gets or sets the Offence_date
        /// </summary>
        public System.DateTime Offence_date { get; set; }

        /// <summary>
        /// Gets or sets the Offence_stat
        /// </summary>
        public int Offence_stat { get; set; }

        /// <summary>
        /// Gets or sets the Court_Name
        /// </summary>
        public string Court_Name { get; set; }

        /// <summary>
        /// Gets or sets the Court_Date
        /// </summary>
        public Nullable<System.DateTime> Court_Date { get; set; }

        /// <summary>
        /// Gets or sets the Courtcase_num
        /// </summary>
        public string Courtcase_num { get; set; }

        /// <summary>
        /// Gets or sets the Outcome
        /// </summary>
        public Nullable<int> Outcome { get; set; }

        /// <summary>
        /// Gets or sets the Civil_amount
        /// </summary>
        public Nullable<decimal> Civil_amount { get; set; }

        /// <summary>
        /// Gets or sets the Date_of_conviction
        /// </summary>
        public Nullable<System.DateTime> Date_of_conviction { get; set; }

        /// <summary>
        /// Gets or sets the Penalty
        /// </summary>
        public Nullable<int> Penalty { get; set; }

        /// <summary>
        /// Gets or sets the Penalty_other
        /// </summary>
        public string Penalty_other { get; set; }

        /// <summary>
        /// Gets or sets the Charge
        /// </summary>
        public string Charge { get; set; }

        /// <summary>
        /// Gets or sets the City
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// Gets or sets the Company
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Gets or sets the Municipality
        /// </summary>
        public virtual Municipality Municipality { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Province
        /// </summary>
        public virtual Province Province { get; set; }

        /// <summary>
        /// Gets or sets the State
        /// </summary>
        public virtual State State { get; set; }
    }
}
