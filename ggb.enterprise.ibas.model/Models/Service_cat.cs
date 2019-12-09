namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Service_cat" />
    /// </summary>
    public partial class Service_cat : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service_cat"/> class.
        /// </summary>
        public Service_cat()
        {
            this.Service_request = new List<Service_request>();
            this.Service_request1 = new List<Service_request>();
            this.Service_request2 = new List<Service_request>();
            this.Service_request3 = new List<Service_request>();
        }

        /// <summary>
        /// Gets or sets the Serv_depart
        /// </summary>
        public int Serv_depart { get; set; }

        /// <summary>
        /// Gets or sets the Sub_cap
        /// </summary>
        public string Sub_cap { get; set; }

        /// <summary>
        /// Gets or sets the Service_type
        /// </summary>
        public string Service_type { get; set; }

        /// <summary>
        /// Gets or sets the Service
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Gets or sets the Service_cat1
        /// </summary>
        public Nullable<int> Service_cat1 { get; set; }

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
        /// Gets or sets the Service_request3
        /// </summary>
        public virtual ICollection<Service_request> Service_request3 { get; set; }
    }
}
