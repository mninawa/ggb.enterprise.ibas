namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IQues_ansRepository" />
    /// </summary>
    public interface IQues_ansRepository : IRepository<Ques_ans, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="Ques_ansRepository" />
    /// </summary>
    public class Ques_ansRepository : RepositoryBase<Ques_ans, int>, IQues_ansRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ques_ansRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public Ques_ansRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
