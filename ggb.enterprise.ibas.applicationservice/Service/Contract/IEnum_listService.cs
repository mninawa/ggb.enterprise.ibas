namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IEnum_listService" />
    /// </summary>
    public interface IEnum_listService
    {
        /// <summary>
        /// The GetEnum_list
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEnum_list();

        /// <summary>
        /// The GetEnum_list
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEnum_list(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetEnum_list
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEnum_list(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Enum_list"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Enum_list entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Enum_list"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Enum_list entity);
    }
}
