namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Person_employ" />
    /// </summary>
    public partial class Person_employ : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Employer_name
        /// </summary>
        public string Employer_name { get; set; }

        /// <summary>
        /// Gets or sets the Employer_address
        /// </summary>
        public string Employer_address { get; set; }

        /// <summary>
        /// Gets or sets the Emp_start_date
        /// </summary>
        public System.DateTime Emp_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Emp_end_date
        /// </summary>
        public System.DateTime Emp_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Reason_leaving
        /// </summary>
        public int Reason_leaving { get; set; }

        /// <summary>
        /// Gets or sets the Reason_other
        /// </summary>
        public string Reason_other { get; set; }

        /// <summary>
        /// Gets or sets the Contact_person
        /// </summary>
        public string Contact_person { get; set; }

        /// <summary>
        /// Gets or sets the Contact_email
        /// </summary>
        public string Contact_email { get; set; }

        /// <summary>
        /// Gets or sets the Contact_num
        /// </summary>
        public string Contact_num { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Discharge_ind
        /// </summary>
        public bool Discharge_ind { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Person_occ_history
        /// </summary>
        public virtual Person_occ_history Person_occ_history { get; set; }
    }
}
