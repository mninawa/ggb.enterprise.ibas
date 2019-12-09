namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IBank_tranService" />
    /// </summary>
    public interface IBank_tranService
    {
        /// <summary>
        /// The GetBank_tran
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBank_tran();

        /// <summary>
        /// The GetBank_tran
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBank_tran(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetBank_tran
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetBank_tran(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Bank_tran"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Bank_tran entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Bank_tran"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Bank_tran entity);
    }
}
