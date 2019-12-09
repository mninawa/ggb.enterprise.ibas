namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IsysdiagramService" />
    /// </summary>
    public interface IsysdiagramService
    {
        /// <summary>
        /// The Getsysdiagram
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Getsysdiagram();

        /// <summary>
        /// The Getsysdiagram
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Getsysdiagram(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The Getsysdiagram
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Getsysdiagram(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="sysdiagram"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(sysdiagram entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="sysdiagram"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(sysdiagram entity);
    }
}
