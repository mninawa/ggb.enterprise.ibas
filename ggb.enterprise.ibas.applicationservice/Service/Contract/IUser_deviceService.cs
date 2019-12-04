
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

	public interface IUser_deviceService 
    {

        ServiceResult GetUser_device();
        ServiceResult GetUser_device(int id);
        ServiceResult GetCount(Refining refining);
        ServiceResult GetUser_device(Refining refining);
        ServiceResult Save(User_device entity);
        ServiceResult Delete(User_device entity);

    }
 }