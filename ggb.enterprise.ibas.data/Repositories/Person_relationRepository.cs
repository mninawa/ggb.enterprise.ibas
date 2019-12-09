namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_relationRepository" />
    /// </summary>
    public interface IPerson_relationRepository : IRepository<Person_relation, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Person_relationRepository" />
    /// </summary>
    public class Person_relationRepository : RepositoryBase<Person_relation, int>, IPerson_relationRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_relationRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Person_relationRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
