namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISoftwareService" />
    /// </summary>
    public interface ISoftwareService
    {
        /// <summary>
        /// The GetSoftware
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSoftware();

        /// <summary>
        /// The GetSoftware
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSoftware(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetSoftware
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSoftware(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Software"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Software entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Software"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Software entity);
    }
}
