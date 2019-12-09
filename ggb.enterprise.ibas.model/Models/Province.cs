namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Province" />
    /// </summary>
    public partial class Province : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Province"/> class.
        /// </summary>
        public Province()
        {
            this.Addresses = new List<Address>();
            this.Municipalities = new List<Municipality>();
            this.Offences = new List<Offence>();
            this.Regions = new List<Region>();
        }

        /// <summary>
        /// Gets or sets the Province_desc
        /// </summary>
        public string Province_desc { get; set; }

        /// <summary>
        /// Gets or sets the Prov_country_num
        /// </summary>
        public int Prov_country_num { get; set; }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Gets or sets the Municipalities
        /// </summary>
        public virtual ICollection<Municipality> Municipalities { get; set; }

        /// <summary>
        /// Gets or sets the Offences
        /// </summary>
        public virtual ICollection<Offence> Offences { get; set; }

        /// <summary>
        /// Gets or sets the Regions
        /// </summary>
        public virtual ICollection<Region> Regions { get; set; }
    }
}
