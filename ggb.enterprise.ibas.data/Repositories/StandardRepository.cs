namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IStandardRepository" />
    /// </summary>
    public interface IStandardRepository : IRepository<Standard, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="StandardRepository" />
    /// </summary>
    public class StandardRepository : RepositoryBase<Standard, int>, IStandardRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public StandardRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
