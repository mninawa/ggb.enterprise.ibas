namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISR_roleRepository" />
    /// </summary>
    public interface ISR_roleRepository : IRepository<SR_role, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="SR_roleRepository" />
    /// </summary>
    public class SR_roleRepository : RepositoryBase<SR_role, int>, ISR_roleRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SR_roleRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public SR_roleRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
