namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IOffenceRepository" />
    /// </summary>
    public interface IOffenceRepository : IRepository<Offence, string>
    {
    }

    /// <summary>
    /// Defines the <see cref="OffenceRepository" />
    /// </summary>
    public class OffenceRepository : RepositoryBase<Offence, string>, IOffenceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OffenceRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public OffenceRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
