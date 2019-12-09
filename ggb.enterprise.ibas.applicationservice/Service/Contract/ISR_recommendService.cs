namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISR_recommendService" />
    /// </summary>
    public interface ISR_recommendService
    {
        /// <summary>
        /// The GetSR_recommend
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_recommend();

        /// <summary>
        /// The GetSR_recommend
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_recommend(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetSR_recommend
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_recommend(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="SR_recommend"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(SR_recommend entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="SR_recommend"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(SR_recommend entity);
    }
}
