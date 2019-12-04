
using System;
using System.Collections.Generic;
using ggb.enterprise.ibas.common.model;

namespace ggb.enterprise.ibas.model.Models
{

    public partial class User : EntityBase<int>
    {
        public string User_name { get; set; }
        public decimal User_stat { get; set; }
        public decimal User_buss_role { get; set; }
        public string User_password { get; set; }
        public string Repeat_password { get; set; }
        public System.DateTime User_start { get; set; }
        public Nullable<System.DateTime> User_end { get; set; }
        public virtual Person Person { get; set; }
    }
}
