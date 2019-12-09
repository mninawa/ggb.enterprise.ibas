namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IProvinceService" />
    /// </summary>
    public interface IProvinceService
    {
        /// <summary>
        /// The GetProvince
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetProvince();

        /// <summary>
        /// The GetProvince
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetProvince(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetProvince
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetProvince(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Province"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Province entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Province"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Province entity);
    }
}
