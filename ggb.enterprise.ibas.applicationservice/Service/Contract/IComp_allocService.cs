namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IComp_allocService" />
    /// </summary>
    public interface IComp_allocService
    {
        /// <summary>
        /// The GetComp_alloc
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetComp_alloc();

        /// <summary>
        /// The GetComp_alloc
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetComp_alloc(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetComp_alloc
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetComp_alloc(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Comp_alloc"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Comp_alloc entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Comp_alloc"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Comp_alloc entity);
    }
}
