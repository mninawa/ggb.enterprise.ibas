namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="App_fee" />
    /// </summary>
    public partial class App_fee : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the App_lic_type
        /// </summary>
        public int App_lic_type { get; set; }

        /// <summary>
        /// Gets or sets the App_fee_type
        /// </summary>
        public int App_fee_type { get; set; }

        /// <summary>
        /// Gets or sets the App_fee_type_cat
        /// </summary>
        public int App_fee_type_cat { get; set; }

        /// <summary>
        /// Gets or sets the App_fee_type_subcat
        /// </summary>
        public Nullable<int> App_fee_type_subcat { get; set; }

        /// <summary>
        /// Gets or sets the App_fee_amount
        /// </summary>
        public decimal App_fee_amount { get; set; }

        /// <summary>
        /// Gets or sets the Fee_start_date
        /// </summary>
        public System.DateTime Fee_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Fee_end_date
        /// </summary>
        public Nullable<System.DateTime> Fee_end_date { get; set; }
    }
}
