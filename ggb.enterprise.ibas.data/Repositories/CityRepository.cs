namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ICityRepository" />
    /// </summary>
    public interface ICityRepository : IRepository<City, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="CityRepository" />
    /// </summary>
    public class CityRepository : RepositoryBase<City, int>, ICityRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CityRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public CityRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
