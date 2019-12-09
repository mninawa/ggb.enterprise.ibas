namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IComp_relRepository" />
    /// </summary>
    public interface IComp_relRepository : IRepository<Comp_rel, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Comp_relRepository" />
    /// </summary>
    public class Comp_relRepository : RepositoryBase<Comp_rel, int>, IComp_relRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comp_relRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Comp_relRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
