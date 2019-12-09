namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicence_taxService" />
    /// </summary>
    public interface ILicence_taxService
    {
        /// <summary>
        /// The GetLicence_tax
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_tax();

        /// <summary>
        /// The GetLicence_tax
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_tax(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetLicence_tax
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_tax(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Licence_tax"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Licence_tax entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Licence_tax"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Licence_tax entity);
    }
}
