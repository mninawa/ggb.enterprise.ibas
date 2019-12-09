namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_occ_historyService" />
    /// </summary>
    public interface IPerson_occ_historyService
    {
        /// <summary>
        /// The GetPerson_occ_history
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_occ_history();

        /// <summary>
        /// The GetPerson_occ_history
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_occ_history(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetPerson_occ_history
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetPerson_occ_history(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Person_occ_history"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Person_occ_history entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Person_occ_history"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Person_occ_history entity);
    }
}
