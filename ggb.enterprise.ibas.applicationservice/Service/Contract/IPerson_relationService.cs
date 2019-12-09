namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_relationService" />
    /// </summary>
    public interface IPerson_relationService
    {
        /// <summary>
        /// The GetPerson_relation
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_relation();

        /// <summary>
        /// The GetPerson_relation
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_relation(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetPerson_relation
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_relation(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Person_relation"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Person_relation entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Person_relation"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Person_relation entity);
    }
}
