namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicenceRepository" />
    /// </summary>
    public interface ILicenceRepository : IRepository<Licence, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="LicenceRepository" />
    /// </summary>
    public class LicenceRepository : RepositoryBase<Licence, int>, ILicenceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenceRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public LicenceRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
