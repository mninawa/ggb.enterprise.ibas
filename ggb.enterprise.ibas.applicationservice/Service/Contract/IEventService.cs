namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IEventService" />
    /// </summary>
    public interface IEventService
    {
        /// <summary>
        /// The GetEvent
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEvent();

        /// <summary>
        /// The GetEvent
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEvent(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetEvent
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEvent(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Event"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Event entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Event"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Event entity);
    }
}
