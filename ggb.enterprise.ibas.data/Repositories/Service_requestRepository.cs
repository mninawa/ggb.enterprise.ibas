namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IService_requestRepository" />
    /// </summary>
    public interface IService_requestRepository : IRepository<Service_request, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Service_requestRepository" />
    /// </summary>
    public class Service_requestRepository : RepositoryBase<Service_request, int>, IService_requestRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service_requestRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Service_requestRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
