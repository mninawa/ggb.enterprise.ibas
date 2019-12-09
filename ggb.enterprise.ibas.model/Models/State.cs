namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="State" />
    /// </summary>
    public partial class State : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        public State()
        {
            this.Addresses = new List<Address>();
            this.Cities = new List<City>();
            this.Offences = new List<Offence>();
        }

        /// <summary>
        /// Gets or sets the State_desc
        /// </summary>
        public string State_desc { get; set; }

        /// <summary>
        /// Gets or sets the State_country_num
        /// </summary>
        public int State_country_num { get; set; }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Cities
        /// </summary>
        public virtual ICollection<City> Cities { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Gets or sets the Offences
        /// </summary>
        public virtual ICollection<Offence> Offences { get; set; }
    }
}
