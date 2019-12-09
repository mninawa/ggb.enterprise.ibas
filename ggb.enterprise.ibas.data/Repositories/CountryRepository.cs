namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ICountryRepository" />
    /// </summary>
    public interface ICountryRepository : IRepository<Country, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="CountryRepository" />
    /// </summary>
    public class CountryRepository : RepositoryBase<Country, int>, ICountryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public CountryRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
