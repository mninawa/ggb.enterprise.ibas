namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILoc_UnitRepository" />
    /// </summary>
    public interface ILoc_UnitRepository : IRepository<Loc_Unit, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Loc_UnitRepository" />
    /// </summary>
    public class Loc_UnitRepository : RepositoryBase<Loc_Unit, int>, ILoc_UnitRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loc_UnitRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Loc_UnitRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
