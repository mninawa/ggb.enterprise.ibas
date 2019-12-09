namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IDictionaryRepository" />
    /// </summary>
    public interface IDictionaryRepository : IRepository<Dictionary, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="DictionaryRepository" />
    /// </summary>
    public class DictionaryRepository : RepositoryBase<Dictionary, int>, IDictionaryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public DictionaryRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
