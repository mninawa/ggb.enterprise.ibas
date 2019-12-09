namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicence_termService" />
    /// </summary>
    public interface ILicence_termService
    {
        /// <summary>
        /// The GetLicence_term
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_term();

        /// <summary>
        /// The GetLicence_term
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_term(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetLicence_term
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_term(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Licence_term"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Licence_term entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Licence_term"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Licence_term entity);
    }
}
