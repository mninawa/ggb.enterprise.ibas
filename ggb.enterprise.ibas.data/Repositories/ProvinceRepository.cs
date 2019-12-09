namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IProvinceRepository" />
    /// </summary>
    public interface IProvinceRepository : IRepository<Province, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="ProvinceRepository" />
    /// </summary>
    public class ProvinceRepository : RepositoryBase<Province, int>, IProvinceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvinceRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public ProvinceRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
