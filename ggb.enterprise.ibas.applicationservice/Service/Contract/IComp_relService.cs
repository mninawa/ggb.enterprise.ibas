namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IComp_relService" />
    /// </summary>
    public interface IComp_relService
    {
        /// <summary>
        /// The GetComp_rel
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetComp_rel();

        /// <summary>
        /// The GetComp_rel
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetComp_rel(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetComp_rel
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetComp_rel(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Comp_rel"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Comp_rel entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Comp_rel"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Comp_rel entity);
    }
}
