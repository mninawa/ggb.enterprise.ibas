namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IAddressService" />
    /// </summary>
    public interface IAddressService
    {
        /// <summary>
        /// The GetAddress
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetAddress();

        /// <summary>
        /// The GetAddress
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetAddress(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetAddress
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetAddress(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Address"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Address entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Address"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Address entity);
    }
}
