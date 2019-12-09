namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IProfess_historyService" />
    /// </summary>
    public interface IProfess_historyService
    {
        /// <summary>
        /// The GetProfess_history
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetProfess_history();

        /// <summary>
        /// The GetProfess_history
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetProfess_history(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetProfess_history
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetProfess_history(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Profess_history"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Profess_history entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Profess_history"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Profess_history entity);
    }
}
