namespace ggb.enterprise.ibas.data.Repositories
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IEquipmentRepository" />
    /// </summary>
    public interface IEquipmentRepository : IRepository<Equipment, int>
    {
    }

    /// <summary>
    /// Defines the <see cref="EquipmentRepository" />
    /// </summary>
    public class EquipmentRepository : RepositoryBase<Equipment, int>, IEquipmentRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unitOfWork<see cref="IUnitOfWork"/></param>
        public EquipmentRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
