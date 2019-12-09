namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IOffenceService" />
    /// </summary>
    public interface IOffenceService
    {
        /// <summary>
        /// The GetOffence
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetOffence();

        /// <summary>
        /// The GetOffence
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetOffence(string id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetOffence
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetOffence(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Offence"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Offence entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Offence"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Offence entity);
    }
}
