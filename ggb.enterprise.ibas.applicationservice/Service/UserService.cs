
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

namespace ggb.enterprise.ibas.applicationservice.Service
{
	public class UserService :  IUserService
    {
		private readonly IUserRepository _repository;
       
        public UserService(IUserRepository repository)          
        {
            _repository = repository;
        }

		public ServiceResult GetUser()
		{
            return new ServiceResult(true) { Data = _repository.GetAll().AsQueryable() };
		}

        public ServiceResult GetUser(int id)
        {
            return new ServiceResult(true) { Data = _repository.Get(x => x.Identifier == id) };
        }

        public ServiceResult GetCount(Refining refining)
        {
            return new ServiceResult(true) { Data = _repository.GetCount(refining) };
        }


		public ServiceResult GetUser(Refining refining)
        {
            return new ServiceResult(true) { Data = _repository.GetMany(refining) };
        }

		public  ServiceResult Save(User entity)
        {
            try
            {
                if (entity.Identifier == 0)
                    _repository.Add(entity);
                else
                    _repository.Update(entity);

                return new ServiceResult(true);
            }
            catch (Exception ex)
            {
                return new ServiceResult(false) { Error = ex.ToString() };
            }
        }

		public ServiceResult Delete(User entity)
        {
            try
            {
                _repository.Delete(entity);
                return new ServiceResult(true);
            }
            catch (Exception ex)
            {
                return new ServiceResult(false) { Error = ex.ToString() };
            }
        }
	}
}