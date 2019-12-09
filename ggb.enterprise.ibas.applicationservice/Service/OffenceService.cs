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
    /// Defines the <see cref="OffenceService" />
    /// </summary>
    public class OffenceService : IOffenceService
    {
        /// <summary>
        /// Defines the _repository
        /// </summary>
        private readonly IOffenceRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="OffenceService"/> class.
        /// </summary>
        /// <param name="repository">The repository<see cref="IOffenceRepository"/></param>
        public OffenceService(IOffenceRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// The GetOffence
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetOffence()
        {
            return new ServiceResult(true) { Data = _repository.GetAll().AsQueryable() };
        }

        /// <summary>
        /// The GetOffence
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetOffence(string id)
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
        /// The GetOffence
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetOffence(Refining refining)
        {
            return new ServiceResult(true) { Data = _repository.GetMany(refining) };
        }

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Offence"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Save(Offence entity)
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
        /// <param name="entity">The entity<see cref="Offence"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Delete(Offence entity)
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
