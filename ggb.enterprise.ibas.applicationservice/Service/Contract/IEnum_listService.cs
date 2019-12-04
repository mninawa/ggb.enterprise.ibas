
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using ggb.enterprise.ibas.applicationservice.Helpers;
using ggb.enterprise.ibas.common.data;
using ggb.enterprise.ibas.common.model;
using ggb.enterprise.ibas.common.model.Enum;
using ggb.enterprise.ibas.data.Repositories;
using ggb.enterprise.ibas.common.data.extensions;
using ggb.enterprise.ibas.common.model.Dto;
using ggb.enterprise.ibas.applicationservice.Contract;
using ggb.enterprise.ibas.model.Models;
namespace ggb.enterprise.ibas.applicationservice.Contract
{

	public interface IEnum_listService
    {
        ServiceResult GetEnum_list();
        ServiceResult GetEnum_list(int id);
        ServiceResult GetCount(Refining refining);
        ServiceResult GetEnum_list(Refining refining);
        ServiceResult Save(Enum_list entity);
        ServiceResult Delete(Enum_list entity);
    }
 }