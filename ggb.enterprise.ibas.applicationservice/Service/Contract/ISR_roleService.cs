namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISR_roleService" />
    /// </summary>
    public interface ISR_roleService
    {
        /// <summary>
        /// The GetSR_role
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_role();

        /// <summary>
        /// The GetSR_role
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_role(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetSR_role
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_role(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="SR_role"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(SR_role entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="SR_role"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(SR_role entity);
    }
}
