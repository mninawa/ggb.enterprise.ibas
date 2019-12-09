namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="City" />
    /// </summary>
    public partial class City : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="City"/> class.
        /// </summary>
        public City()
        {
            this.Addresses = new List<Address>();
            this.Offences = new List<Offence>();
        }

        /// <summary>
        /// Gets or sets the City_desc
        /// </summary>
        public string City_desc { get; set; }

        /// <summary>
        /// Gets or sets the City_mun_num
        /// </summary>
        public Nullable<int> City_mun_num { get; set; }

        /// <summary>
        /// Gets or sets the City_state_num
        /// </summary>
        public Nullable<int> City_state_num { get; set; }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Municipality
        /// </summary>
        public virtual Municipality Municipality { get; set; }

        /// <summary>
        /// Gets or sets the State
        /// </summary>
        public virtual State State { get; set; }

        /// <summary>
        /// Gets or sets the Offences
        /// </summary>
        public virtual ICollection<Offence> Offences { get; set; }
    }
}
