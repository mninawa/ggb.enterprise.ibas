namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Person_credit_hist" />
    /// </summary>
    public partial class Person_credit_hist : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Creditor_Name
        /// </summary>
        public string Creditor_Name { get; set; }

        /// <summary>
        /// Gets or sets the Credit_history_Type
        /// </summary>
        public int Credit_history_Type { get; set; }

        /// <summary>
        /// Gets or sets the Amount_owing
        /// </summary>
        public string Amount_owing { get; set; }

        /// <summary>
        /// Gets or sets the Amount_default
        /// </summary>
        public string Amount_default { get; set; }

        /// <summary>
        /// Gets or sets the Days_default
        /// </summary>
        public int Days_default { get; set; }

        /// <summary>
        /// Gets or sets the Reason_dafault
        /// </summary>
        public int Reason_dafault { get; set; }

        /// <summary>
        /// Gets or sets the Reason_dafault_other
        /// </summary>
        public string Reason_dafault_other { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
