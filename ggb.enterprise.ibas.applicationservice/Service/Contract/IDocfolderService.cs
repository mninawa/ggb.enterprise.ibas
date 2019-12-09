namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IDocfolderService" />
    /// </summary>
    public interface IDocfolderService
    {
        /// <summary>
        /// The GetDocfolder
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDocfolder();

        /// <summary>
        /// The GetDocfolder
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDocfolder(string id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetDocfolder
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDocfolder(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Docfolder"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Docfolder entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Docfolder"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Docfolder entity);
    }
}
