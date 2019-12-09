namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ICompanyRepository" />
    /// </summary>
    public interface ICompanyRepository : IRepository<Company, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="CompanyRepository" />
    /// </summary>
    public class CompanyRepository : RepositoryBase<Company, int>, ICompanyRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public CompanyRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
