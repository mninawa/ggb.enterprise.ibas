namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISR_recommendRepository" />
    /// </summary>
    public interface ISR_recommendRepository : IRepository<SR_recommend, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="SR_recommendRepository" />
    /// </summary>
    public class SR_recommendRepository : RepositoryBase<SR_recommend, int>, ISR_recommendRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SR_recommendRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public SR_recommendRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
