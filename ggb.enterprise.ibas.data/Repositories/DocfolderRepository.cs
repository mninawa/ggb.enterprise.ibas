namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IDocfolderRepository" />
    /// </summary>
    public interface IDocfolderRepository : IRepository<Docfolder, string>
    {
    }

    /// <summary>
    /// Defines the <see cref="DocfolderRepository" />
    /// </summary>
    public class DocfolderRepository : RepositoryBase<Docfolder, string>, IDocfolderRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocfolderRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public DocfolderRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
