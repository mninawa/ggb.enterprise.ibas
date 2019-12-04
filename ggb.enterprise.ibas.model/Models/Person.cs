using System;
using System.Collections.Generic;
using ggb.enterprise.ibas.common.model;
namespace ggb.enterprise.ibas.model.Models
{
    public partial class Person : EntityBase<int>
    {
        public string Surname { get; set; } public string First_name { get; set; }
        public string Initials { get; set; } public string Alias_name { get; set; }
        public string Maiden_name { get; set; } public decimal Title { get; set; }
        public Nullable<decimal> Person_group { get; set; }
        public Nullable<decimal> Person_status { get; set; }
        public decimal ID_type { get; set; }
        public decimal ID_number { get; set; }
        public Nullable<System.DateTime> Pers_date_birth { get; set; }
        public Nullable<decimal> Pers_place_brith_ind { get; set; }
        public string Pers_place_birth { get; set; }
        public Nullable<System.DateTime> Per_date_decease { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string Complexion { get; set; }
        public string Eye_color { get; set; }
        public string Hair_color { get; set; }
        public string Marks { get; set; }
        public Nullable<decimal> Sex { get; set; }
        public Nullable<decimal> Race { get; set; }
        public Nullable<decimal> Marital_stat { get; set; }
        public string Per_home_num { get; set; }
        public string Per_work_num { get; set; }
        public string Per_cell_num { get; set; }
        public string Per_fax_num { get; set; }
        public string Per_email { get; set; }
        public string Alt_contact_name { get; set; }
        public string Alt_contact_num { get; set; }
        public Nullable<decimal> Alt_relation_type { get; set; }
        public string CC_code { get; set; }
        public byte[] Millatary_ind { get; set; }
        public string Income_tax_num { get; set; }
        public Nullable<System.DateTime> Income_tax_date { get; set; }
        public string VAT_num { get; set; }
        public Nullable<System.DateTime> VAT_date { get; set; }
        public string Revenue_office { get; set; }
        public virtual User User { get; set; }
    }
}