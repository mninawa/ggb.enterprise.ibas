
using System;
using System.Collections.Generic;
using ggb.enterprise.ibas.common.model;

namespace ggb.enterprise.ibas.model.Models
{


    public partial class User_device : EntityBase<int>
    {
        public string Dev_user_name { get; set; }
        public string Device_num { get; set; }
        public decimal Device_make { get; set; }
        public decimal Device_type { get; set; }
    }
}
