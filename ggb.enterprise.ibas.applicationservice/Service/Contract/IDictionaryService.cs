namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IDictionaryService" />
    /// </summary>
    public interface IDictionaryService
    {
        /// <summary>
        /// The GetDictionary
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDictionary();

        /// <summary>
        /// The GetDictionary
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDictionary(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetDictionary
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDictionary(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Dictionary"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Dictionary entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Dictionary"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Dictionary entity);
    }
}
