namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IStateRepository" />
    /// </summary>
    public interface IStateRepository : IRepository<State, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="StateRepository" />
    /// </summary>
    public class StateRepository : RepositoryBase<State, int>, IStateRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public StateRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
