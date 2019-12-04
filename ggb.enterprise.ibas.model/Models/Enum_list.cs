
using System;
using System.Collections.Generic;
using ggb.enterprise.ibas.common.model;

namespace ggb.enterprise.ibas.model.Models
{

    public partial class Enum_list : EntityBase<int>
    {
        public string Enum_type { get; set; }
        public string Enum_value { get; set; }
        public string Table { get; set; }
    }
}
