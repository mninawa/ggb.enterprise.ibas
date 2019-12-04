using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ggb.enterprise.ibas.applicationservice.Helpers
{
    public class ServiceResult
    {
        public ServiceResult(bool success)
        {
            Success = success;
        }

        public bool Success { get; set; }

        public dynamic Data { get; set; }
        public string Error { get; set; }
    }
}
