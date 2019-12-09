namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IAddressRepository" />
    /// </summary>
    public interface IAddressRepository : IRepository<Address, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="AddressRepository" />
    /// </summary>
    public class AddressRepository : RepositoryBase<Address, int>, IAddressRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public AddressRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
