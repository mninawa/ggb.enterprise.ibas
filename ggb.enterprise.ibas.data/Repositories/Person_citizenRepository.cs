namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_citizenRepository" />
    /// </summary>
    public interface IPerson_citizenRepository : IRepository<Person_citizen, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Person_citizenRepository" />
    /// </summary>
    public class Person_citizenRepository : RepositoryBase<Person_citizen, int>, IPerson_citizenRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_citizenRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Person_citizenRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
