namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPersonService" />
    /// </summary>
    public interface IPersonService
    {
        /// <summary>
        /// The GetPerson
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson();

        /// <summary>
        /// The GetPerson
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetPerson
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Person"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Person entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Person"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Person entity);
    }
}
