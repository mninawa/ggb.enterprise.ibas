namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Licence" />
    /// </summary>
    public partial class Licence : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence"/> class.
        /// </summary>
        public Licence()
        {
            this.Addresses = new List<Address>();
            this.Comms = new List<Comm>();
            this.Documents = new List<Document>();
            this.Equipments = new List<Equipment>();
            this.Events = new List<Event>();
            this.Financings = new List<Financing>();
            this.Licence_tax = new List<Licence_tax>();
            this.License_fee = new List<License_fee>();
            this.Locations = new List<Location>();
            this.Ques_ans = new List<Ques_ans>();
            this.Registers = new List<Register>();
            this.Service_request = new List<Service_request>();
            this.Locations1 = new List<Location>();
        }

        /// <summary>
        /// Gets or sets the Lic_rel_for
        /// </summary>
        public int Lic_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Lic_comp_num
        /// </summary>
        public Nullable<int> Lic_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Lic_pers_num
        /// </summary>
        public Nullable<int> Lic_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Lic_equip_num
        /// </summary>
        public Nullable<int> Lic_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Lic_loc_num
        /// </summary>
        public Nullable<int> Lic_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Licence_type
        /// </summary>
        public int Licence_type { get; set; }

        /// <summary>
        /// Gets or sets the Licence_code
        /// </summary>
        public string Licence_code { get; set; }

        /// <summary>
        /// Gets or sets the Licence_stat
        /// </summary>
        public int Licence_stat { get; set; }

        /// <summary>
        /// Gets or sets the Lic_start_date
        /// </summary>
        public System.DateTime Lic_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Licence_end_date
        /// </summary>
        public System.DateTime Licence_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Number_Renewable
        /// </summary>
        public int Number_Renewable { get; set; }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Comms
        /// </summary>
        public virtual ICollection<Comm> Comms { get; set; }

        /// <summary>
        /// Gets or sets the Company
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the Documents
        /// </summary>
        public virtual ICollection<Document> Documents { get; set; }

        /// <summary>
        /// Gets or sets the Equipments
        /// </summary>
        public virtual ICollection<Equipment> Equipments { get; set; }

        /// <summary>
        /// Gets or sets the Equipment
        /// </summary>
        public virtual Equipment Equipment { get; set; }

        /// <summary>
        /// Gets or sets the Events
        /// </summary>
        public virtual ICollection<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the Financings
        /// </summary>
        public virtual ICollection<Financing> Financings { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Licence_condition
        /// </summary>
        public virtual Licence_condition Licence_condition { get; set; }

        /// <summary>
        /// Gets or sets the Licence_tax
        /// </summary>
        public virtual ICollection<Licence_tax> Licence_tax { get; set; }

        /// <summary>
        /// Gets or sets the Licence_term
        /// </summary>
        public virtual Licence_term Licence_term { get; set; }

        /// <summary>
        /// Gets or sets the License_fee
        /// </summary>
        public virtual ICollection<License_fee> License_fee { get; set; }

        /// <summary>
        /// Gets or sets the Locations
        /// </summary>
        public virtual ICollection<Location> Locations { get; set; }

        /// <summary>
        /// Gets or sets the Ques_ans
        /// </summary>
        public virtual ICollection<Ques_ans> Ques_ans { get; set; }

        /// <summary>
        /// Gets or sets the Registers
        /// </summary>
        public virtual ICollection<Register> Registers { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual ICollection<Service_request> Service_request { get; set; }

        /// <summary>
        /// Gets or sets the Locations1
        /// </summary>
        public virtual ICollection<Location> Locations1 { get; set; }

        /// <summary>
        /// Gets or sets the Location
        /// </summary>
        public virtual Location Location { get; set; }
    }
}
