namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IUserService" />
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// The GetUser
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetUser();

        /// <summary>
        /// The GetUser
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetUser(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetUser
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetUser(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="User"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(User entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="User"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(User entity);
    }
}
