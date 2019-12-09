namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IStandardService" />
    /// </summary>
    public interface IStandardService
    {
        /// <summary>
        /// The GetStandard
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetStandard();

        /// <summary>
        /// The GetStandard
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetStandard(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetStandard
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetStandard(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Standard"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Standard entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Standard"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Standard entity);
    }
}
