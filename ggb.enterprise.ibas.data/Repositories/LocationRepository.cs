namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILocationRepository" />
    /// </summary>
    public interface ILocationRepository : IRepository<Location, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="LocationRepository" />
    /// </summary>
    public class LocationRepository : RepositoryBase<Location, int>, ILocationRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public LocationRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
