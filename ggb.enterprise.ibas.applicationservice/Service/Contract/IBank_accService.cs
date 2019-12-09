namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IBank_accService" />
    /// </summary>
    public interface IBank_accService
    {
        /// <summary>
        /// The GetBank_acc
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBank_acc();

        /// <summary>
        /// The GetBank_acc
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBank_acc(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetBank_acc
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBank_acc(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Bank_acc"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Bank_acc entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Bank_acc"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Bank_acc entity);
    }
}
