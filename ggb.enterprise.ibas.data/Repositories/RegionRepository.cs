namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IRegionRepository" />
    /// </summary>
    public interface IRegionRepository : IRepository<Region, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="RegionRepository" />
    /// </summary>
    public class RegionRepository : RepositoryBase<Region, int>, IRegionRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public RegionRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
