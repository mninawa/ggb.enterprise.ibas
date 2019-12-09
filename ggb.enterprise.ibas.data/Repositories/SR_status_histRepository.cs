namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISR_status_histRepository" />
    /// </summary>
    public interface ISR_status_histRepository : IRepository<SR_status_hist, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="SR_status_histRepository" />
    /// </summary>
    public class SR_status_histRepository : RepositoryBase<SR_status_hist, int>, ISR_status_histRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SR_status_histRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public SR_status_histRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
