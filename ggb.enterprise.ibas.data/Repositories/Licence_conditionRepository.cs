namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="ILicence_conditionRepository" />
    /// </summary>
    public interface ILicence_conditionRepository : IRepository<Licence_condition, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Licence_conditionRepository" />
    /// </summary>
    public class Licence_conditionRepository : RepositoryBase<Licence_condition, int>, ILicence_conditionRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence_conditionRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Licence_conditionRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
