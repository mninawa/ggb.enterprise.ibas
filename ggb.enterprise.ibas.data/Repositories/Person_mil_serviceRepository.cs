namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_mil_serviceRepository" />
    /// </summary>
    public interface IPerson_mil_serviceRepository : IRepository<Person_mil_service, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Person_mil_serviceRepository" />
    /// </summary>
    public class Person_mil_serviceRepository : RepositoryBase<Person_mil_service, int>, IPerson_mil_serviceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_mil_serviceRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Person_mil_serviceRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
