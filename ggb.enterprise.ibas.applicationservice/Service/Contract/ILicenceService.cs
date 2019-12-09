namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicenceService" />
    /// </summary>
    public interface ILicenceService
    {
        /// <summary>
        /// The GetLicence
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence();

        /// <summary>
        /// The GetLicence
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetLicence
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Licence"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Licence entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Licence"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Licence entity);
    }
}
