namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IFinancial_infoService" />
    /// </summary>
    public interface IFinancial_infoService
    {
        /// <summary>
        /// The GetFinancial_info
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetFinancial_info();

        /// <summary>
        /// The GetFinancial_info
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetFinancial_info(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetFinancial_info
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetFinancial_info(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Financial_info"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Financial_info entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Financial_info"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Financial_info entity);
    }
}
