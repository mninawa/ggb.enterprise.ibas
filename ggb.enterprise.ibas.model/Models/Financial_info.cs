namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Financial_info" />
    /// </summary>
    public partial class Financial_info : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the FIinfo_rel_for
        /// </summary>
        public int FIinfo_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_comp_num
        /// </summary>
        public Nullable<int> FIinfo_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_pers_num
        /// </summary>
        public Nullable<int> FIinfo_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the FI_cat
        /// </summary>
        public int FI_cat { get; set; }

        /// <summary>
        /// Gets or sets the FI_type
        /// </summary>
        public int FI_type { get; set; }

        /// <summary>
        /// Gets or sets the FI_stat
        /// </summary>
        public int FI_stat { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_amount
        /// </summary>
        public decimal FIinfo_amount { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_spouse_amount
        /// </summary>
        public decimal FIinfo_spouse_amount { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_name
        /// </summary>
        public string FIinfo_name { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_address
        /// </summary>
        public string FIinfo_address { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_acc_type
        /// </summary>
        public string Fiinfo_acc_type { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_account_num
        /// </summary>
        public string FIinfo_account_num { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_date_open
        /// </summary>
        public Nullable<System.DateTime> FIinfo_date_open { get; set; }

        /// <summary>
        /// Gets or sets the FIinfo_date_due
        /// </summary>
        public Nullable<System.DateTime> FIinfo_date_due { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_org_amount
        /// </summary>
        public Nullable<decimal> Fiinfo_org_amount { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_unpaid_bal
        /// </summary>
        public Nullable<decimal> Fiinfo_unpaid_bal { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_pay_period
        /// </summary>
        public string Fiinfo_pay_period { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_int_rate
        /// </summary>
        public Nullable<decimal> Fiinfo_int_rate { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_matur_date
        /// </summary>
        public Nullable<System.DateTime> Fiinfo_matur_date { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_purpose
        /// </summary>
        public string Fiinfo_purpose { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_collat
        /// </summary>
        public string Fiinfo_collat { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_type_ent
        /// </summary>
        public string Fiinfo_type_ent { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_nature_acc
        /// </summary>
        public string Fiinfo_nature_acc { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_num_shares
        /// </summary>
        public Nullable<decimal> Fiinfo_num_shares { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_perc_own
        /// </summary>
        public Nullable<decimal> Fiinfo_perc_own { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_purch_price
        /// </summary>
        public Nullable<decimal> Fiinfo_purch_price { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_purch_date
        /// </summary>
        public Nullable<System.DateTime> Fiinfo_purch_date { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_name_held
        /// </summary>
        public string Fiinfo_name_held { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_market_val
        /// </summary>
        public Nullable<decimal> Fiinfo_market_val { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_ann_income
        /// </summary>
        public Nullable<decimal> Fiinfo_ann_income { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_sec_desc
        /// </summary>
        public string Fiinfo_sec_desc { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_other
        /// </summary>
        public string Fiinfo_other { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_tax_year
        /// </summary>
        public string Fiinfo_tax_year { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_return_date
        /// </summary>
        public Nullable<System.DateTime> Fiinfo_return_date { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_tax_ref_num
        /// </summary>
        public string Fiinfo_tax_ref_num { get; set; }

        /// <summary>
        /// Gets or sets the Fiinfo_other_pers
        /// </summary>
        public string Fiinfo_other_pers { get; set; }

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
