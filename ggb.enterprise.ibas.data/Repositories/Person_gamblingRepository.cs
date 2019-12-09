namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_gamblingRepository" />
    /// </summary>
    public interface IPerson_gamblingRepository : IRepository<Person_gambling, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Person_gamblingRepository" />
    /// </summary>
    public class Person_gamblingRepository : RepositoryBase<Person_gambling, int>, IPerson_gamblingRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_gamblingRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Person_gamblingRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
