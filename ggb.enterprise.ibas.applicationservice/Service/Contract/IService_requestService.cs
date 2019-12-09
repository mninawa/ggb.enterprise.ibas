namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IService_requestService" />
    /// </summary>
    public interface IService_requestService
    {
        /// <summary>
        /// The GetService_request
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetService_request();

        /// <summary>
        /// The GetService_request
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetService_request(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetService_request
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetService_request(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Service_request"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Service_request entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Service_request"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Service_request entity);
    }
}
