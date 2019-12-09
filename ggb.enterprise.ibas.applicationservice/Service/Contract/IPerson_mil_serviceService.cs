namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_mil_serviceService" />
    /// </summary>
    public interface IPerson_mil_serviceService
    {
        /// <summary>
        /// The GetPerson_mil_service
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_mil_service();

        /// <summary>
        /// The GetPerson_mil_service
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_mil_service(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetPerson_mil_service
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_mil_service(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Person_mil_service"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Person_mil_service entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Person_mil_service"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Person_mil_service entity);
    }
}
