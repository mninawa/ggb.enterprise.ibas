namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IFinancingRepository" />
    /// </summary>
    public interface IFinancingRepository : IRepository<Financing, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="FinancingRepository" />
    /// </summary>
    public class FinancingRepository : RepositoryBase<Financing, int>, IFinancingRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancingRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public FinancingRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
