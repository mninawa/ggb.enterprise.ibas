namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IFinancingService" />
    /// </summary>
    public interface IFinancingService
    {
        /// <summary>
        /// The GetFinancing
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetFinancing();

        /// <summary>
        /// The GetFinancing
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetFinancing(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetFinancing
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetFinancing(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Financing"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Financing entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Financing"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Financing entity);
    }
}
