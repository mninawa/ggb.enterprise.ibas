namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISoftwareRepository" />
    /// </summary>
    public interface ISoftwareRepository : IRepository<Software, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="SoftwareRepository" />
    /// </summary>
    public class SoftwareRepository : RepositoryBase<Software, int>, ISoftwareRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public SoftwareRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
