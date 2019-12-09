namespace ggb.enterprise.ibas.applicationservice.Contract
{
    using ggb.enterprise.ibas.applicationservice.Helpers;
    using ggb.enterprise.ibas.common.model.Dto;
    using ggb.enterprise.ibas.model.Models;

    /// <summary>
    /// Defines the <see cref="IQues_ansService" />
    /// </summary>
    public interface IQues_ansService
    {
        /// <summary>
        /// The GetQues_ans
        /// </summary>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetQues_ans();

        /// <summary>
        /// The GetQues_ans
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetQues_ans(int id);

        /// <summary>
        /// The GetCount
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetCount(Refining refining);

        /// <summary>
        /// The GetQues_ans
        /// </summary>
        /// <param name="refining">The refining<see cref="Refining"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult GetQues_ans(Refining refining);

        /// <summary>
        /// The Save
        /// </summary>
        /// <param name="entity">The entity<see cref="Ques_ans"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Save(Ques_ans entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="Ques_ans"/></param>
        /// <returns>The <see cref="ServiceResult"/></returns>
        ServiceResult Delete(Ques_ans entity);
    }
}
