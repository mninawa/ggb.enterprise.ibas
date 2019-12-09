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
    /// Defines the <see cref="HardwareService" />
    /// </summary>
    public class HardwareService : IHardwareService
    {
        /// <summary>
        /// Defines the _repository
        /// </summary>
        private readonly IHardwareRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareService"/> class.
        /// </summary>
        /// <param name="repository">The repository<see cref="IHardwareRepository"/></param>
        public HardwareService(IHardwareRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// The GetHardware
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetHardware()
        {
            return new ServiceResult(true) { Data = _repository.GetAll().AsQueryable() };
        }

        /// <summary>
        /// The GetHardware
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetHardware(int id)
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
        /// The GetHardware
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetHardware(Refining refining)
        {
            return new ServiceResult(true) { Data = _repository.GetMany(refining) };
        }

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Hardware"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Save(Hardware entity)
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
        /// <param name="entity">The entity<see cref="Hardware"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Delete(Hardware entity)
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
