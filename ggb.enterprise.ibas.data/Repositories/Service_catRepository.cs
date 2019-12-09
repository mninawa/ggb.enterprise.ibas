namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IService_catRepository" />
    /// </summary>
    public interface IService_catRepository : IRepository<Service_cat, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Service_catRepository" />
    /// </summary>
    public class Service_catRepository : RepositoryBase<Service_cat, int>, IService_catRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service_catRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Service_catRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
