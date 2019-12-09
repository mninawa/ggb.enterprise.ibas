namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicense_feeRepository" />
    /// </summary>
    public interface ILicense_feeRepository : IRepository<License_fee, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="License_feeRepository" />
    /// </summary>
    public class License_feeRepository : RepositoryBase<License_fee, int>, ILicense_feeRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="License_feeRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public License_feeRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
