namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IService_cat_relRepository" />
    /// </summary>
    public interface IService_cat_relRepository : IRepository<Service_cat_rel, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Service_cat_relRepository" />
    /// </summary>
    public class Service_cat_relRepository : RepositoryBase<Service_cat_rel, int>, IService_cat_relRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service_cat_relRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Service_cat_relRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
