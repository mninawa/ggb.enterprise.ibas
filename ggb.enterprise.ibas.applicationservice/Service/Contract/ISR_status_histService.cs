namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISR_status_histService" />
    /// </summary>
    public interface ISR_status_histService
    {
        /// <summary>
        /// The GetSR_status_hist
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_status_hist();

        /// <summary>
        /// The GetSR_status_hist
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_status_hist(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetSR_status_hist
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_status_hist(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="SR_status_hist"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(SR_status_hist entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="SR_status_hist"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(SR_status_hist entity);
    }
}
