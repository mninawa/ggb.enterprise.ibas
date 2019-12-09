namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Bank_acc" />
    /// </summary>
    public partial class Bank_acc : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Bank_rel_for
        /// </summary>
        public int Bank_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Bank_comp_num
        /// </summary>
        public Nullable<int> Bank_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Bank_pers_num
        /// </summary>
        public Nullable<int> Bank_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Bank_type
        /// </summary>
        public int Bank_type { get; set; }

        /// <summary>
        /// Gets or sets the Bank_name
        /// </summary>
        public string Bank_name { get; set; }

        /// <summary>
        /// Gets or sets the Branch_code
        /// </summary>
        public string Branch_code { get; set; }

        /// <summary>
        /// Gets or sets the Account_Type
        /// </summary>
        public string Account_Type { get; set; }

        /// <summary>
        /// Gets or sets the Account_No
        /// </summary>
        public int Account_No { get; set; }

        /// <summary>
        /// Gets or sets the Bank_address
        /// </summary>
        public string Bank_address { get; set; }

        /// <summary>
        /// Gets or sets the Bank_cont_name
        /// </summary>
        public string Bank_cont_name { get; set; }

        /// <summary>
        /// Gets or sets the Bank_cont_email
        /// </summary>
        public string Bank_cont_email { get; set; }

        /// <summary>
        /// Gets or sets the Bank_cont_number
        /// </summary>
        public string Bank_cont_number { get; set; }

        /// <summary>
        /// Gets or sets the Company
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
