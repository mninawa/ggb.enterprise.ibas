namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="User" />
    /// </summary>
    public partial class User : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            this.Service_request = new List<Service_request>();
            this.Service_request1 = new List<Service_request>();
            this.Service_request2 = new List<Service_request>();
            this.SR_status_hist = new List<SR_status_hist>();
            this.SR_status_hist1 = new List<SR_status_hist>();
        }

        /// <summary>
        /// Gets or sets the User_name
        /// </summary>
        public string User_name { get; set; }

        /// <summary>
        /// Gets or sets the User_stat
        /// </summary>
        public int User_stat { get; set; }

        /// <summary>
        /// Gets or sets the User_buss_role
        /// </summary>
        public int User_buss_role { get; set; }

        /// <summary>
        /// Gets or sets the User_password
        /// </summary>
        public string User_password { get; set; }

        /// <summary>
        /// Gets or sets the Repeat_password
        /// </summary>
        public string Repeat_password { get; set; }

        /// <summary>
        /// Gets or sets the User_start
        /// </summary>
        public System.DateTime User_start { get; set; }

        /// <summary>
        /// Gets or sets the User_end
        /// </summary>
        public Nullable<System.DateTime> User_end { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual ICollection<Service_request> Service_request { get; set; }

        /// <summary>
        /// Gets or sets the Service_request1
        /// </summary>
        public virtual ICollection<Service_request> Service_request1 { get; set; }

        /// <summary>
        /// Gets or sets the Service_request2
        /// </summary>
        public virtual ICollection<Service_request> Service_request2 { get; set; }

        /// <summary>
        /// Gets or sets the SR_status_hist
        /// </summary>
        public virtual ICollection<SR_status_hist> SR_status_hist { get; set; }

        /// <summary>
        /// Gets or sets the SR_status_hist1
        /// </summary>
        public virtual ICollection<SR_status_hist> SR_status_hist1 { get; set; }
    }
}
