namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Company" />
    /// </summary>
    public partial class Company : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
        {
            this.Addresses = new List<Address>();
            this.Bank_acc = new List<Bank_acc>();
            this.Comms = new List<Comm>();
            this.Comp_rel1 = new List<Comp_rel>();
            this.Documents = new List<Document>();
            this.Equipments = new List<Equipment>();
            this.Events = new List<Event>();
            this.Financial_info = new List<Financial_info>();
            this.Financings = new List<Financing>();
            this.Licences = new List<Licence>();
            this.Licence_tax = new List<Licence_tax>();
            this.License_fee = new List<License_fee>();
            this.Locations = new List<Location>();
            this.Offences = new List<Offence>();
            this.Ques_ans = new List<Ques_ans>();
            this.Registers = new List<Register>();
            this.Service_request = new List<Service_request>();
        }

        /// <summary>
        /// Gets or sets the Company_reg_num
        /// </summary>
        public string Company_reg_num { get; set; }

        /// <summary>
        /// Gets or sets the Company_name
        /// </summary>
        public string Company_name { get; set; }

        /// <summary>
        /// Gets or sets the Company_trade_name
        /// </summary>
        public string Company_trade_name { get; set; }

        /// <summary>
        /// Gets or sets the Comp_group
        /// </summary>
        public int Comp_group { get; set; }

        /// <summary>
        /// Gets or sets the Comp_type
        /// </summary>
        public int Comp_type { get; set; }

        /// <summary>
        /// Gets or sets the Comp_cat
        /// </summary>
        public int Comp_cat { get; set; }

        /// <summary>
        /// Gets or sets the Comp_spec
        /// </summary>
        public Nullable<int> Comp_spec { get; set; }

        /// <summary>
        /// Gets or sets the Comp_stat
        /// </summary>
        public int Comp_stat { get; set; }

        /// <summary>
        /// Gets or sets the Comp_own
        /// </summary>
        public int Comp_own { get; set; }

        /// <summary>
        /// Gets or sets the Incorporation_date
        /// </summary>
        public Nullable<System.DateTime> Incorporation_date { get; set; }

        /// <summary>
        /// Gets or sets the Place_of_incorporation
        /// </summary>
        public string Place_of_incorporation { get; set; }

        /// <summary>
        /// Gets or sets the Comp_size
        /// </summary>
        public Nullable<int> Comp_size { get; set; }

        /// <summary>
        /// Gets or sets the Comp_risk
        /// </summary>
        public Nullable<int> Comp_risk { get; set; }

        /// <summary>
        /// Gets or sets the Nature_businness
        /// </summary>
        public string Nature_businness { get; set; }

        /// <summary>
        /// Gets or sets the Comp_work_num
        /// </summary>
        public string Comp_work_num { get; set; }

        /// <summary>
        /// Gets or sets the Comp_alt_num
        /// </summary>
        public string Comp_alt_num { get; set; }

        /// <summary>
        /// Gets or sets the Comp_cell_num
        /// </summary>
        public string Comp_cell_num { get; set; }

        /// <summary>
        /// Gets or sets the Comp_fax_num
        /// </summary>
        public string Comp_fax_num { get; set; }

        /// <summary>
        /// Gets or sets the Comp_telefax_No
        /// </summary>
        public Nullable<int> Comp_telefax_No { get; set; }

        /// <summary>
        /// Gets or sets the Comp_email
        /// </summary>
        public string Comp_email { get; set; }

        /// <summary>
        /// Gets or sets the Num_share_less5_
        /// </summary>
        public Nullable<int> Num_share_less5_ { get; set; }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Bank_acc
        /// </summary>
        public virtual ICollection<Bank_acc> Bank_acc { get; set; }

        /// <summary>
        /// Gets or sets the Comms
        /// </summary>
        public virtual ICollection<Comm> Comms { get; set; }

        /// <summary>
        /// Gets or sets the Comp_alloc
        /// </summary>
        public virtual Comp_alloc Comp_alloc { get; set; }

        /// <summary>
        /// Gets or sets the Comp_rel
        /// </summary>
        public virtual Comp_rel Comp_rel { get; set; }

        /// <summary>
        /// Gets or sets the Comp_rel1
        /// </summary>
        public virtual ICollection<Comp_rel> Comp_rel1 { get; set; }

        /// <summary>
        /// Gets or sets the Documents
        /// </summary>
        public virtual ICollection<Document> Documents { get; set; }

        /// <summary>
        /// Gets or sets the Equipments
        /// </summary>
        public virtual ICollection<Equipment> Equipments { get; set; }

        /// <summary>
        /// Gets or sets the Events
        /// </summary>
        public virtual ICollection<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the Financial_info
        /// </summary>
        public virtual ICollection<Financial_info> Financial_info { get; set; }

        /// <summary>
        /// Gets or sets the Financings
        /// </summary>
        public virtual ICollection<Financing> Financings { get; set; }

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
        /// Gets or sets the Locations
        /// </summary>
        public virtual ICollection<Location> Locations { get; set; }

        /// <summary>
        /// Gets or sets the Offences
        /// </summary>
        public virtual ICollection<Offence> Offences { get; set; }

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
