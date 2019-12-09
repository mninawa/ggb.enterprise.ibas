namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_educationService" />
    /// </summary>
    public interface IPerson_educationService
    {
        /// <summary>
        /// The GetPerson_education
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_education();

        /// <summary>
        /// The GetPerson_education
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_education(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetPerson_education
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_education(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Person_education"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Person_education entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Person_education"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Person_education entity);
    }
}
