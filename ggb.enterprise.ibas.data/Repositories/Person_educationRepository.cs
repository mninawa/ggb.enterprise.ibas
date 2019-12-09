namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_educationRepository" />
    /// </summary>
    public interface IPerson_educationRepository : IRepository<Person_education, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Person_educationRepository" />
    /// </summary>
    public class Person_educationRepository : RepositoryBase<Person_education, int>, IPerson_educationRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_educationRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Person_educationRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
