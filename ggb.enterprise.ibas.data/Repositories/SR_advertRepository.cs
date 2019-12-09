namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ISR_advertRepository" />
    /// </summary>
    public interface ISR_advertRepository : IRepository<SR_advert, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="SR_advertRepository" />
    /// </summary>
    public class SR_advertRepository : RepositoryBase<SR_advert, int>, ISR_advertRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SR_advertRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public SR_advertRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
