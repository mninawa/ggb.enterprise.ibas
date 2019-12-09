namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IStateService" />
    /// </summary>
    public interface IStateService
    {
        /// <summary>
        /// The GetState
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetState();

        /// <summary>
        /// The GetState
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetState(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetState
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetState(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="State"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(State entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="State"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(State entity);
    }
}
