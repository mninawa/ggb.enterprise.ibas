namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IComp_allocRepository" />
    /// </summary>
    public interface IComp_allocRepository : IRepository<Comp_alloc, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Comp_allocRepository" />
    /// </summary>
    public class Comp_allocRepository : RepositoryBase<Comp_alloc, int>, IComp_allocRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comp_allocRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Comp_allocRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
