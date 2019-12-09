namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IEntityRepository" />
    /// </summary>
    public interface IEntityRepository : IRepository<Entity, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="EntityRepository" />
    /// </summary>
    public class EntityRepository : RepositoryBase<Entity, int>, IEntityRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public EntityRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
