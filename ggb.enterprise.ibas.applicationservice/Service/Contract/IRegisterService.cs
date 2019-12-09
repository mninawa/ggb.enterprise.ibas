namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IRegisterService" />
    /// </summary>
    public interface IRegisterService
    {
        /// <summary>
        /// The GetRegister
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetRegister();

        /// <summary>
        /// The GetRegister
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetRegister(string id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetRegister
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetRegister(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Register"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Register entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Register"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Register entity);
    }
}
