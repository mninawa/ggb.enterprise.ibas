namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicence_termRepository" />
    /// </summary>
    public interface ILicence_termRepository : IRepository<Licence_term, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Licence_termRepository" />
    /// </summary>
    public class Licence_termRepository : RepositoryBase<Licence_term, int>, ILicence_termRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence_termRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Licence_termRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
