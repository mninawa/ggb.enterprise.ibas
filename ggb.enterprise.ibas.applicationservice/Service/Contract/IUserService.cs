
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

	public interface IUserService 
    {

        ServiceResult GetUser();
        ServiceResult GetUser(int id);
        ServiceResult GetCount(Refining refining);
        ServiceResult GetUser(Refining refining);
        ServiceResult Save(User entity);
        ServiceResult Delete(User entity);

    }
 }