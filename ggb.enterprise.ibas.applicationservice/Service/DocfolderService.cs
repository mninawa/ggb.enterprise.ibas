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
    /// Defines the <see cref="DocfolderService" />
    /// </summary>
    public class DocfolderService : IDocfolderService
    {
        /// <summary>
        /// Defines the _repository
        /// </summary>
        private readonly IDocfolderRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocfolderService"/> class.
        /// </summary>
        /// <param name="repository">The repository<see cref="IDocfolderRepository"/></param>
        public DocfolderService(IDocfolderRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// The GetDocfolder
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetDocfolder()
        {
            return new ServiceResult(true) { Data = _repository.GetAll().AsQueryable() };
        }

        /// <summary>
        /// The GetDocfolder
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetDocfolder(string id)
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
        /// The GetDocfolder
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult GetDocfolder(Refining refining)
        {
            return new ServiceResult(true) { Data = _repository.GetMany(refining) };
        }

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Docfolder"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Save(Docfolder entity)
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
        /// <param name="entity">The entity<see cref="Docfolder"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        public ServiceResult Delete(Docfolder entity)
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
