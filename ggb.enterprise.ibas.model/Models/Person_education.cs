namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Person_education" />
    /// </summary>
    public partial class Person_education : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Ed_institution
        /// </summary>
        public string Ed_institution { get; set; }

        /// <summary>
        /// Gets or sets the Qual_type
        /// </summary>
        public int Qual_type { get; set; }

        /// <summary>
        /// Gets or sets the Qual_desc
        /// </summary>
        public string Qual_desc { get; set; }

        /// <summary>
        /// Gets or sets the Educ_start_date
        /// </summary>
        public System.DateTime Educ_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Educ_end_date
        /// </summary>
        public Nullable<System.DateTime> Educ_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Educ_year_comp
        /// </summary>
        public string Educ_year_comp { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
