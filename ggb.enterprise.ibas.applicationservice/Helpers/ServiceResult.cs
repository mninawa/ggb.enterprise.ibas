namespace ggb.enterprise.ibas.applicationservice.Helpers
{
    /// <summary>
    /// Defines the <see cref="ServiceResult" />
    /// </summary>
    public class ServiceResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResult"/> class.
        /// </summary>
        /// <param name="success">The success<see cref="bool"/></param>
        public ServiceResult(bool success)
        {
            Success = success;
        }

        /// <summary>
        /// Gets or sets a value indicating whether Success
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the Data
        /// </summary>
        public dynamic Data { get; set; }

        /// <summary>
        /// Gets or sets the Error
        /// </summary>
        public string Error { get; set; }
    }
}
