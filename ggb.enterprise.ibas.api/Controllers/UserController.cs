using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Threading.Tasks;
using ggb.enterprise.ibas.api.Models;
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
using graphservice.api.Models;
using AutoMapper;

namespace ggb.enterprise.ibas.api.Controllers
{
   

    public class UserController : ApiController
    {
        private readonly IPersonService _personService;
        public UserController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        [Route("api/user/getuser")]
        public async Task<IHttpActionResult> GetUserById()
        {
            // If not data came in, then return
            if (this.Request.Content == null)
            {
                return Content(HttpStatusCode.Conflict, new ResponseContent("Request content is NULL", HttpStatusCode.Conflict));
            }

            // Read the input claims from the request body
            string input = Request.Content.ReadAsStringAsync().Result;

            // Check input content value
            if (string.IsNullOrEmpty(input))
            {
                return Content(HttpStatusCode.Conflict, new ResponseContent("Request content is empty", HttpStatusCode.Conflict));
            }

            InputClaimsModel inputClaims = JsonConvert.DeserializeObject(input, typeof(InputClaimsModel)) as InputClaimsModel;

            if (inputClaims == null)
            {
                return Content(HttpStatusCode.Conflict, new ResponseContent("Can not deserialize input claims", HttpStatusCode.Conflict));

            }

            Person data = _personService.GetPerson(int.Parse( inputClaims.personId,0)).Data;
            if (data.Identifier != null)
            {
                var result = Mapper.Map<Person, PersonViewModel>(data);
                return Content(HttpStatusCode.Accepted, result);
            }

            return Content(HttpStatusCode.Accepted, new ResponseContent("User not found", HttpStatusCode.Accepted));
        }
 
    }
}
