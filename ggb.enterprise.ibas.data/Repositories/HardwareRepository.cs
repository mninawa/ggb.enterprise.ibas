namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IHardwareRepository" />
    /// </summary>
    public interface IHardwareRepository : IRepository<Hardware, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="HardwareRepository" />
    /// </summary>
    public class HardwareRepository : RepositoryBase<Hardware, int>, IHardwareRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public HardwareRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
