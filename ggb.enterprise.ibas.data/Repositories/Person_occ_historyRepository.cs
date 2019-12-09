namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_occ_historyRepository" />
    /// </summary>
    public interface IPerson_occ_historyRepository : IRepository<Person_occ_history, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Person_occ_historyRepository" />
    /// </summary>
    public class Person_occ_historyRepository : RepositoryBase<Person_occ_history, int>, IPerson_occ_historyRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_occ_historyRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Person_occ_historyRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
