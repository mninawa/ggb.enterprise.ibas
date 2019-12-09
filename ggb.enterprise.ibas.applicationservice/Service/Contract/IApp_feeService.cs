namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IApp_feeService" />
    /// </summary>
    public interface IApp_feeService
    {
        /// <summary>
        /// The GetApp_fee
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetApp_fee();

        /// <summary>
        /// The GetApp_fee
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetApp_fee(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetApp_fee
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetApp_fee(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="App_fee"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(App_fee entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="App_fee"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(App_fee entity);
    }
}
