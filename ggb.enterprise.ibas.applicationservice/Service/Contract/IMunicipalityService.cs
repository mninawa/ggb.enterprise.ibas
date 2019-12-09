namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IMunicipalityService" />
    /// </summary>
    public interface IMunicipalityService
    {
        /// <summary>
        /// The GetMunicipality
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetMunicipality();

        /// <summary>
        /// The GetMunicipality
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetMunicipality(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetMunicipality
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetMunicipality(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Municipality"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Municipality entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Municipality"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Municipality entity);
    }
}
