namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IMunicipalityRepository" />
    /// </summary>
    public interface IMunicipalityRepository : IRepository<Municipality, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="MunicipalityRepository" />
    /// </summary>
    public class MunicipalityRepository : RepositoryBase<Municipality, int>, IMunicipalityRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MunicipalityRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public MunicipalityRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
