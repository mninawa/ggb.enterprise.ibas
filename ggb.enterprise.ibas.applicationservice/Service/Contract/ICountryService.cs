namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ICountryService" />
    /// </summary>
    public interface ICountryService
    {
        /// <summary>
        /// The GetCountry
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCountry();

        /// <summary>
        /// The GetCountry
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCountry(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetCountry
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCountry(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Country"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Country entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Country"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Country entity);
    }
}
