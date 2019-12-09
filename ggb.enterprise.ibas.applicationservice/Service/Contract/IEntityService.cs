namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IEntityService" />
    /// </summary>
    public interface IEntityService
    {
        /// <summary>
        /// The GetEntity
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEntity();

        /// <summary>
        /// The GetEntity
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEntity(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetEntity
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEntity(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Entity"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Entity entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Entity"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Entity entity);
    }
}
