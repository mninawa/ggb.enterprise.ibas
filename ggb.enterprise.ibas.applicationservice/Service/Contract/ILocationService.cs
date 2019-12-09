namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILocationService" />
    /// </summary>
    public interface ILocationService
    {
        /// <summary>
        /// The GetLocation
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLocation();

        /// <summary>
        /// The GetLocation
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLocation(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetLocation
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLocation(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Location"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Location entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Location"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Location entity);
    }
}
