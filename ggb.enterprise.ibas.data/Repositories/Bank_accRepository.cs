namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IBank_accRepository" />
    /// </summary>
    public interface IBank_accRepository : IRepository<Bank_acc, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Bank_accRepository" />
    /// </summary>
    public class Bank_accRepository : RepositoryBase<Bank_acc, int>, IBank_accRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank_accRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Bank_accRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
