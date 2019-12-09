namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IEventRepository" />
    /// </summary>
    public interface IEventRepository : IRepository<Event, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="EventRepository" />
    /// </summary>
    public class EventRepository : RepositoryBase<Event, int>, IEventRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public EventRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
