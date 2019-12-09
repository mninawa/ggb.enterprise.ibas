namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IBase_OSRepository" />
    /// </summary>
    public interface IBase_OSRepository : IRepository<Base_OS, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Base_OSRepository" />
    /// </summary>
    public class Base_OSRepository : RepositoryBase<Base_OS, int>, IBase_OSRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Base_OSRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Base_OSRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
