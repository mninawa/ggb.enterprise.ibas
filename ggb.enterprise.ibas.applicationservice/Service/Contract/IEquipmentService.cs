namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IEquipmentService" />
    /// </summary>
    public interface IEquipmentService
    {
        /// <summary>
        /// The GetEquipment
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEquipment();

        /// <summary>
        /// The GetEquipment
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEquipment(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetEquipment
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetEquipment(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Equipment"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Equipment entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Equipment"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Equipment entity);
    }
}
