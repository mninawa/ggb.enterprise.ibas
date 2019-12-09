namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IService_catService" />
    /// </summary>
    public interface IService_catService
    {
        /// <summary>
        /// The GetService_cat
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetService_cat();

        /// <summary>
        /// The GetService_cat
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetService_cat(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetService_cat
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetService_cat(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Service_cat"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Service_cat entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Service_cat"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Service_cat entity);
    }
}
