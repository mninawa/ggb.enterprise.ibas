namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IRegisterRepository" />
    /// </summary>
    public interface IRegisterRepository : IRepository<Register, string>
    {
    }

    /// <summary>
    /// Defines the <see cref="RegisterRepository" />
    /// </summary>
    public class RegisterRepository : RepositoryBase<Register, string>, IRegisterRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public RegisterRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
