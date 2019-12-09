namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISR_advertService" />
    /// </summary>
    public interface ISR_advertService
    {
        /// <summary>
        /// The GetSR_advert
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_advert();

        /// <summary>
        /// The GetSR_advert
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_advert(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetSR_advert
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetSR_advert(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="SR_advert"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(SR_advert entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="SR_advert"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(SR_advert entity);
    }
}
