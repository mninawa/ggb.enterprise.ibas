namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicence_conditionService" />
    /// </summary>
    public interface ILicence_conditionService
    {
        /// <summary>
        /// The GetLicence_condition
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_condition();

        /// <summary>
        /// The GetLicence_condition
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_condition(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetLicence_condition
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetLicence_condition(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Licence_condition"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Licence_condition entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Licence_condition"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Licence_condition entity);
    }
}
