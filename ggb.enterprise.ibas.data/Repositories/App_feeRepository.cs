namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IApp_feeRepository" />
    /// </summary>
    public interface IApp_feeRepository : IRepository<App_fee, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="App_feeRepository" />
    /// </summary>
    public class App_feeRepository : RepositoryBase<App_fee, int>, IApp_feeRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App_feeRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public App_feeRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
