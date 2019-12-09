namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IBank_tranRepository" />
    /// </summary>
    public interface IBank_tranRepository : IRepository<Bank_tran, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Bank_tranRepository" />
    /// </summary>
    public class Bank_tranRepository : RepositoryBase<Bank_tran, int>, IBank_tranRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank_tranRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Bank_tranRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
