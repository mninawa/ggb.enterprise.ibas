namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IRegionService" />
    /// </summary>
    public interface IRegionService
    {
        /// <summary>
        /// The GetRegion
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetRegion();

        /// <summary>
        /// The GetRegion
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetRegion(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetRegion
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetRegion(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Region"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Region entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Region"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Region entity);
    }
}
