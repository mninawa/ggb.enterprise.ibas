namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="User_device" />
    /// </summary>
    public partial class User_device : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Dev_user_name
        /// </summary>
        public string Dev_user_name { get; set; }

        /// <summary>
        /// Gets or sets the Device_num
        /// </summary>
        public string Device_num { get; set; }

        /// <summary>
        /// Gets or sets the Device_make
        /// </summary>
        public int Device_make { get; set; }

        /// <summary>
        /// Gets or sets the Device_type
        /// </summary>
        public int Device_type { get; set; }
    }
}
