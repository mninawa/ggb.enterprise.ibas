namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IFinancial_infoRepository" />
    /// </summary>
    public interface IFinancial_infoRepository : IRepository<Financial_info, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Financial_infoRepository" />
    /// </summary>
    public class Financial_infoRepository : RepositoryBase<Financial_info, int>, IFinancial_infoRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Financial_infoRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Financial_infoRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
