namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Bank_tran" />
    /// </summary>
    public partial class Bank_tran : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Tran_type
        /// </summary>
        public int Tran_type { get; set; }

        /// <summary>
        /// Gets or sets the Tran_ref
        /// </summary>
        public string Tran_ref { get; set; }

        /// <summary>
        /// Gets or sets the Tran_name
        /// </summary>
        public string Tran_name { get; set; }

        /// <summary>
        /// Gets or sets the Tran_desc
        /// </summary>
        public string Tran_desc { get; set; }

        /// <summary>
        /// Gets or sets the Tran_amount
        /// </summary>
        public decimal Tran_amount { get; set; }

        /// <summary>
        /// Gets or sets the Transaction_date
        /// </summary>
        public System.DateTime Transaction_date { get; set; }

        /// <summary>
        /// Gets or sets the Tran_time
        /// </summary>
        public System.TimeSpan Tran_time { get; set; }
    }
}
