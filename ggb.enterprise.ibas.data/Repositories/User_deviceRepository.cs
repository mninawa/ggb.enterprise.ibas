namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IUser_deviceRepository" />
    /// </summary>
    public interface IUser_deviceRepository : IRepository<User_device, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="User_deviceRepository" />
    /// </summary>
    public class User_deviceRepository : RepositoryBase<User_device, int>, IUser_deviceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User_deviceRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public User_deviceRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
