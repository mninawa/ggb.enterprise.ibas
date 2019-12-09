namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IsysdiagramRepository" />
    /// </summary>
    public interface IsysdiagramRepository : IRepository<sysdiagram, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="sysdiagramRepository" />
    /// </summary>
    public class sysdiagramRepository : RepositoryBase<sysdiagram, int>, IsysdiagramRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="sysdiagramRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public sysdiagramRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
