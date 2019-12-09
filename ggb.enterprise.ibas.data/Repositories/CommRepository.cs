namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ICommRepository" />
    /// </summary>
    public interface ICommRepository : IRepository<Comm, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="CommRepository" />
    /// </summary>
    public class CommRepository : RepositoryBase<Comm, int>, ICommRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public CommRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
