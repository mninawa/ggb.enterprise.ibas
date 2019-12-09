namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IBase_OSService" />
    /// </summary>
    public interface IBase_OSService
    {
        /// <summary>
        /// The GetBase_OS
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBase_OS();

        /// <summary>
        /// The GetBase_OS
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBase_OS(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetBase_OS
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBase_OS(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Base_OS"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Base_OS entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Base_OS"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Base_OS entity);
    }
}
