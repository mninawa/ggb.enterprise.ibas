namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPersonRepository" />
    /// </summary>
    public interface IPersonRepository : IRepository<Person, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="PersonRepository" />
    /// </summary>
    public class PersonRepository : RepositoryBase<Person, int>, IPersonRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public PersonRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
