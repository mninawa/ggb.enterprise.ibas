using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using ggb.enterprise.ibas.applicationservice.Helpers;
using ggb.enterprise.ibas.common.data;
using ggb.enterprise.ibas.common.model;
using ggb.enterprise.ibas.common.model.Enum;
using ggb.enterprise.ibas.data.Repositories;
using ggb.enterprise.ibas.common.data.extensions;
using ggb.enterprise.ibas.common.model.Dto;
using ggb.enterprise.ibas.applicationservice.Contract;
using ggb.enterprise.ibas.applicationservice.Service;
using ggb.enterprise.ibas.model.Models;
using Autofac.Integration.WebApi;
using ggb.enterprise.ibas.data.Models;


namespace ggb.enterprise.ibas.api.Controllers
{
    public class BaseController:Controller
    {

        [System.Web.Mvc.NonAction]
        internal dynamic ProcessServiceResult(ServiceResult result)
        {
            if (result.Success)
                return result.Data;

            return new ExpandoObject();
        }

    }
}