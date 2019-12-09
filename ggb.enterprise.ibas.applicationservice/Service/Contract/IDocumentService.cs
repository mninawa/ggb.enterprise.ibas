namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IDocumentService" />
    /// </summary>
    public interface IDocumentService
    {
        /// <summary>
        /// The GetDocument
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDocument();

        /// <summary>
        /// The GetDocument
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDocument(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetDocument
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetDocument(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Document"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Document entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Document"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Document entity);
    }
}
