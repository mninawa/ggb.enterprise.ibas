namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ICityService" />
    /// </summary>
    public interface ICityService
    {
        /// <summary>
        /// The GetCity
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCity();

        /// <summary>
        /// The GetCity
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCity(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetCity
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCity(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="City"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(City entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="City"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(City entity);
    }
}
