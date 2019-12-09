namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicence_taxRepository" />
    /// </summary>
    public interface ILicence_taxRepository : IRepository<Licence_tax, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Licence_taxRepository" />
    /// </summary>
    public class Licence_taxRepository : RepositoryBase<Licence_tax, int>, ILicence_taxRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence_taxRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Licence_taxRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
