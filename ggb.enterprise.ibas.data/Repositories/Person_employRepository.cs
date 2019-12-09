namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_employRepository" />
    /// </summary>
    public interface IPerson_employRepository : IRepository<Person_employ, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Person_employRepository" />
    /// </summary>
    public class Person_employRepository : RepositoryBase<Person_employ, int>, IPerson_employRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_employRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Person_employRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
