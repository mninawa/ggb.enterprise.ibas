namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Municipality" />
    /// </summary>
    public partial class Municipality : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Municipality"/> class.
        /// </summary>
        public Municipality()
        {
            this.Addresses = new List<Address>();
            this.Cities = new List<City>();
            this.Offences = new List<Offence>();
            this.Regions = new List<Region>();
        }

        /// <summary>
        /// Gets or sets the Municipality_desc
        /// </summary>
        public string Municipality_desc { get; set; }

        /// <summary>
        /// Gets or sets the Mun_prov_num
        /// </summary>
        public Nullable<int> Mun_prov_num { get; set; }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Cities
        /// </summary>
        public virtual ICollection<City> Cities { get; set; }

        /// <summary>
        /// Gets or sets the Province
        /// </summary>
        public virtual Province Province { get; set; }

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
