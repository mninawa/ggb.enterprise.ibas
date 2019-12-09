namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Location" />
    /// </summary>
    public partial class Location : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        public Location()
        {
            this.Addresses = new List<Address>();
            this.Comms = new List<Comm>();
            this.Documents = new List<Document>();
            this.Equipments = new List<Equipment>();
            this.Events = new List<Event>();
            this.Financings = new List<Financing>();
            this.Licences = new List<Licence>();
            this.Licence_tax = new List<Licence_tax>();
            this.License_fee = new List<License_fee>();
            this.Ques_ans = new List<Ques_ans>();
            this.Registers = new List<Register>();
            this.Service_request = new List<Service_request>();
        }

        /// <summary>
        /// Gets or sets the Loc_name
        /// </summary>
        public string Loc_name { get; set; }

        /// <summary>
        /// Gets or sets the Loc_desc
        /// </summary>
        public string Loc_desc { get; set; }

        /// <summary>
        /// Gets or sets the Loc_rel_for
        /// </summary>
        public int Loc_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Loc_comp_num
        /// </summary>
        public Nullable<int> Loc_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the Loc_pers_num
        /// </summary>
        public Nullable<int> Loc_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the Loc_equip_num
        /// </summary>
        public Nullable<int> Loc_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the Loc_lic_num
        /// </summary>
        public Nullable<int> Loc_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the Loc_SR_ID
        /// </summary>
        public int Loc_SR_ID { get; set; }

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
        /// Gets or sets the Licence
        /// </summary>
        public virtual Licence Licence { get; set; }

        /// <summary>
        /// Gets or sets the Licence1
        /// </summary>
        public virtual Licence Licence1 { get; set; }

        /// <summary>
        /// Gets or sets the Licences
        /// </summary>
        public virtual ICollection<Licence> Licences { get; set; }

        /// <summary>
        /// Gets or sets the Licence_tax
        /// </summary>
        public virtual ICollection<Licence_tax> Licence_tax { get; set; }

        /// <summary>
        /// Gets or sets the License_fee
        /// </summary>
        public virtual ICollection<License_fee> License_fee { get; set; }

        /// <summary>
        /// Gets or sets the Loc_Unit
        /// </summary>
        public virtual Loc_Unit Loc_Unit { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

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
    }
}
