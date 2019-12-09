namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IDocumentRepository" />
    /// </summary>
    public interface IDocumentRepository : IRepository<Document, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="DocumentRepository" />
    /// </summary>
    public class DocumentRepository : RepositoryBase<Document, int>, IDocumentRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public DocumentRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
