namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IEnum_listRepository" />
    /// </summary>
    public interface IEnum_listRepository : IRepository<Enum_list, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Enum_listRepository" />
    /// </summary>
    public class Enum_listRepository : RepositoryBase<Enum_list, int>, IEnum_listRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Enum_listRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Enum_listRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
