namespace ggb.enterprise.ibas.applicationservice.Service
{
    using ggb.enterprise.ibas.applicationservice.Contract;
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.data.Repositories;
    using ggb.enterprise.ibas.model.Models;
    using System;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="RegisterService" />
    /// </summary>
    public class RegisterService : IRegisterService
    {
        /// <summary>
        /// Defines the _repository
        /// </summary>
        private readonly IRegisterRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterService"/> class.
        /// </summary>
        /// <param name="repository">The repository<see cref="IRegisterRepository"/></param>
        public RegisterService(IRegisterRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// The GetRegister
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetRegister()
        {
            return new ServiceResult(true) { Data = _repository.GetAll().AsQueryable() };
        }

        /// <summary>
        /// The GetRegister
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetRegister(string id)
        {
            return new ServiceResult(true) { Data = _repository.Get(x => x.Identifier.Equals(id)) };
        }

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetCount(Refining refining)
        {
            return new ServiceResult(true) { Data = _repository.GetCount(refining) };
        }

        /// <summary>
        /// The GetRegister
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetRegister(Refining refining)
        {
            return new ServiceResult(true) { Data = _repository.GetMany(refining) };
        }

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Register"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Save(Register entity)
        {
            try
            {
                if (entity.Identifier.Equals(""))
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

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Register"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Delete(Register entity)
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
