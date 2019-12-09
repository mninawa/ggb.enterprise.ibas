namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IUser_deviceService" />
    /// </summary>
    public interface IUser_deviceService
    {
        /// <summary>
        /// The GetUser_device
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetUser_device();

        /// <summary>
        /// The GetUser_device
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetUser_device(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetUser_device
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetUser_device(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="User_device"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(User_device entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="User_device"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(User_device entity);
    }
}
