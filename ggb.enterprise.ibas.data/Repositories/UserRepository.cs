namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IUserRepository" />
    /// </summary>
    public interface IUserRepository : IRepository<User, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="UserRepository" />
    /// </summary>
    public class UserRepository : RepositoryBase<User, int>, IUserRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
