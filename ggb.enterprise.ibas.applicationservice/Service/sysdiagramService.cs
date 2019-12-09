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
    /// Defines the <see cref="sysdiagramService" />
    /// </summary>
    public class sysdiagramService : IsysdiagramService
    {
        /// <summary>
        /// Defines the _repository
        /// </summary>
        private readonly IsysdiagramRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="sysdiagramService"/> class.
        /// </summary>
        /// <param name="repository">The repository<see cref="IsysdiagramRepository"/></param>
        public sysdiagramService(IsysdiagramRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// The Getsysdiagram
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Getsysdiagram()
        {
            return new ServiceResult(true) { Data = _repository.GetAll().AsQueryable() };
        }

        /// <summary>
        /// The Getsysdiagram
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Getsysdiagram(int id)
        {
            return new ServiceResult(true) { Data = _repository.Get(x => x.Identifier == id) };
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
        /// The Getsysdiagram
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Getsysdiagram(Refining refining)
        {
            return new ServiceResult(true) { Data = _repository.GetMany(refining) };
        }

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="sysdiagram"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Save(sysdiagram entity)
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

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="sysdiagram"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Delete(sysdiagram entity)
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
