namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IProfess_historyRepository" />
    /// </summary>
    public interface IProfess_historyRepository : IRepository<Profess_history, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Profess_historyRepository" />
    /// </summary>
    public class Profess_historyRepository : RepositoryBase<Profess_history, int>, IProfess_historyRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Profess_historyRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Profess_historyRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
