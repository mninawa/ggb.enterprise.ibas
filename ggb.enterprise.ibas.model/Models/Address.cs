namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Address" />
    /// </summary>
    public partial class Address : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Adr_rel_for
        /// </summary>
        public int Adr_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Adr_comp_num
        /// </summary>
        public Nullable<int> Adr_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Adr_pers_num
        /// </summary>
        public Nullable<int> Adr_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Adr_equip_num
        /// </summary>
        public Nullable<int> Adr_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Adr_lic_num
        /// </summary>
        public Nullable<int> Adr_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the Adr_loc_num
        /// </summary>
        public Nullable<int> Adr_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Address_type
        /// </summary>
        public int Address_type { get; set; }

        /// <summary>
        /// Gets or sets the Address_stat
        /// </summary>
        public int Address_stat { get; set; }

        /// <summary>
        /// Gets or sets the Ownership_stat
        /// </summary>
        public int Ownership_stat { get; set; }

        /// <summary>
        /// Gets or sets the Erf_num
        /// </summary>
        public string Erf_num { get; set; }

        /// <summary>
        /// Gets or sets the Address_line_1
        /// </summary>
        public string Address_line_1 { get; set; }

        /// <summary>
        /// Gets or sets the Address_line_2
        /// </summary>
        public string Address_line_2 { get; set; }

        /// <summary>
        /// Gets or sets the Street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the Suburb
        /// </summary>
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or sets the Adr_city_num
        /// </summary>
        public int Adr_city_num { get; set; }

        /// <summary>
        /// Gets or sets the Adre_mun_num
        /// </summary>
        public int Adre_mun_num { get; set; }

        /// <summary>
        /// Gets or sets the Adr_prov_num
        /// </summary>
        public int Adr_prov_num { get; set; }

        /// <summary>
        /// Gets or sets the Adre_state_num
        /// </summary>
        public int Adre_state_num { get; set; }

        /// <summary>
        /// Gets or sets the Adr_country_num
        /// </summary>
        public int Adr_country_num { get; set; }

        /// <summary>
        /// Gets or sets the Postal_code
        /// </summary>
        public string Postal_code { get; set; }

        /// <summary>
        /// Gets or sets the Lease_agree_num
        /// </summary>
        public string Lease_agree_num { get; set; }

        /// <summary>
        /// Gets or sets the Owner_name
        /// </summary>
        public string Owner_name { get; set; }

        /// <summary>
        /// Gets or sets the Renting_agency
        /// </summary>
        public string Renting_agency { get; set; }

        /// <summary>
        /// Gets or sets the Add_start_date
        /// </summary>
        public Nullable<System.DateTime> Add_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Lease_date_end
        /// </summary>
        public Nullable<System.DateTime> Lease_date_end { get; set; }

        /// <summary>
        /// Gets or sets the City
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// Gets or sets the Company
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Gets or sets the Equipment
        /// </summary>
        public virtual Equipment Equipment { get; set; }

        /// <summary>
        /// Gets or sets the Licence
        /// </summary>
        public virtual Licence Licence { get; set; }

        /// <summary>
        /// Gets or sets the Location
        /// </summary>
        public virtual Location Location { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Province
        /// </summary>
        public virtual Province Province { get; set; }

        /// <summary>
        /// Gets or sets the Municipality
        /// </summary>
        public virtual Municipality Municipality { get; set; }

        /// <summary>
        /// Gets or sets the State
        /// </summary>
        public virtual State State { get; set; }
    }
}
