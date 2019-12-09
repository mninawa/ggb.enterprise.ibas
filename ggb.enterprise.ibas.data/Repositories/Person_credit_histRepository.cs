namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IPerson_credit_histRepository" />
    /// </summary>
    public interface IPerson_credit_histRepository : IRepository<Person_credit_hist, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Person_credit_histRepository" />
    /// </summary>
    public class Person_credit_histRepository : RepositoryBase<Person_credit_hist, int>, IPerson_credit_histRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_credit_histRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Person_credit_histRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
