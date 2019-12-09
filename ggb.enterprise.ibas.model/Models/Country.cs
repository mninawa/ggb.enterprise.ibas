namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Country" />
    /// </summary>
    public partial class Country : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        public Country()
        {
            this.Addresses = new List<Address>();
            this.Offences = new List<Offence>();
            this.Person_citizen = new List<Person_citizen>();
            this.Person_gambling = new List<Person_gambling>();
            this.Person_mil_service = new List<Person_mil_service>();
            this.Provinces = new List<Province>();
            this.States = new List<State>();
        }

        /// <summary>
        /// Gets or sets the Country_desc
        /// </summary>
        public string Country_desc { get; set; }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Offences
        /// </summary>
        public virtual ICollection<Offence> Offences { get; set; }

        /// <summary>
        /// Gets or sets the Person_citizen
        /// </summary>
        public virtual ICollection<Person_citizen> Person_citizen { get; set; }

        /// <summary>
        /// Gets or sets the Person_gambling
        /// </summary>
        public virtual ICollection<Person_gambling> Person_gambling { get; set; }

        /// <summary>
        /// Gets or sets the Person_mil_service
        /// </summary>
        public virtual ICollection<Person_mil_service> Person_mil_service { get; set; }

        /// <summary>
        /// Gets or sets the Provinces
        /// </summary>
        public virtual ICollection<Province> Provinces { get; set; }

        /// <summary>
        /// Gets or sets the States
        /// </summary>
        public virtual ICollection<State> States { get; set; }
    }
}
