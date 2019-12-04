
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

	public interface IPersonService 
    {

        ServiceResult GetPerson();
        ServiceResult GetPerson(int id);
        ServiceResult GetCount(Refining refining);
        ServiceResult GetPerson(Refining refining);
        ServiceResult Save(Person entity);
        ServiceResult Delete(Person entity);

    }
 }