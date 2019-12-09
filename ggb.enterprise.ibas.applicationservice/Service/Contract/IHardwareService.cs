namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IHardwareService" />
    /// </summary>
    public interface IHardwareService
    {
        /// <summary>
        /// The GetHardware
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetHardware();

        /// <summary>
        /// The GetHardware
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetHardware(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetHardware
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetHardware(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Hardware"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Hardware entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Hardware"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Hardware entity);
    }
}
