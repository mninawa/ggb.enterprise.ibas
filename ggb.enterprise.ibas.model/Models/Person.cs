namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Person" />
    /// </summary>
    public partial class Person : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            this.Addresses = new List<Address>();
            this.Bank_acc = new List<Bank_acc>();
            this.Comms = new List<Comm>();
            this.Comp_alloc = new List<Comp_alloc>();
            this.Comp_rel = new List<Comp_rel>();
            this.Documents = new List<Document>();
            this.Events = new List<Event>();
            this.Financial_info = new List<Financial_info>();
            this.Financings = new List<Financing>();
            this.Licences = new List<Licence>();
            this.Licence_tax = new List<Licence_tax>();
            this.License_fee = new List<License_fee>();
            this.Locations = new List<Location>();
            this.Offences = new List<Offence>();
            this.Person_relation1 = new List<Person_relation>();
            this.Ques_ans = new List<Ques_ans>();
            this.Registers = new List<Register>();
            this.Service_request = new List<Service_request>();
            this.SR_role = new List<SR_role>();
        }

        /// <summary>
        /// Gets or sets the Surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the First_name
        /// </summary>
        public string First_name { get; set; }

        /// <summary>
        /// Gets or sets the Initials
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// Gets or sets the Alias_name
        /// </summary>
        public string Alias_name { get; set; }

        /// <summary>
        /// Gets or sets the Maiden_name
        /// </summary>
        public string Maiden_name { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public int Title { get; set; }

        /// <summary>
        /// Gets or sets the Person_group
        /// </summary>
        public int Person_group { get; set; }

        /// <summary>
        /// Gets or sets the Person_status
        /// </summary>
        public int Person_status { get; set; }

        /// <summary>
        /// Gets or sets the ID_type
        /// </summary>
        public int ID_type { get; set; }

        /// <summary>
        /// Gets or sets the ID_number
        /// </summary>
        public int ID_number { get; set; }

        /// <summary>
        /// Gets or sets the Pers_date_birth
        /// </summary>
        public System.DateTime Pers_date_birth { get; set; }

        /// <summary>
        /// Gets or sets the Pers_place_brith_ind
        /// </summary>
        public int Pers_place_brith_ind { get; set; }

        /// <summary>
        /// Gets or sets the Pers_place_birth
        /// </summary>
        public string Pers_place_birth { get; set; }

        /// <summary>
        /// Gets or sets the Per_date_decease
        /// </summary>
        public Nullable<System.DateTime> Per_date_decease { get; set; }

        /// <summary>
        /// Gets or sets the Height
        /// </summary>
        public Nullable<decimal> Height { get; set; }

        /// <summary>
        /// Gets or sets the Weight
        /// </summary>
        public Nullable<decimal> Weight { get; set; }

        /// <summary>
        /// Gets or sets the Complexion
        /// </summary>
        public string Complexion { get; set; }

        /// <summary>
        /// Gets or sets the Eye_color
        /// </summary>
        public string Eye_color { get; set; }

        /// <summary>
        /// Gets or sets the Hair_color
        /// </summary>
        public string Hair_color { get; set; }

        /// <summary>
        /// Gets or sets the Marks
        /// </summary>
        public string Marks { get; set; }

        /// <summary>
        /// Gets or sets the Sex
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// Gets or sets the Race
        /// </summary>
        public int Race { get; set; }

        /// <summary>
        /// Gets or sets the Marital_stat
        /// </summary>
        public int Marital_stat { get; set; }

        /// <summary>
        /// Gets or sets the Per_home_num
        /// </summary>
        public string Per_home_num { get; set; }

        /// <summary>
        /// Gets or sets the Per_work_num
        /// </summary>
        public string Per_work_num { get; set; }

        /// <summary>
        /// Gets or sets the Per_cell_num
        /// </summary>
        public string Per_cell_num { get; set; }

        /// <summary>
        /// Gets or sets the Per_fax_num
        /// </summary>
        public string Per_fax_num { get; set; }

        /// <summary>
        /// Gets or sets the Per_email
        /// </summary>
        public string Per_email { get; set; }

        /// <summary>
        /// Gets or sets the Alt_contact_name
        /// </summary>
        public string Alt_contact_name { get; set; }

        /// <summary>
        /// Gets or sets the Alt_contact_num
        /// </summary>
        public string Alt_contact_num { get; set; }

        /// <summary>
        /// Gets or sets the Alt_relation_type
        /// </summary>
        public Nullable<int> Alt_relation_type { get; set; }

        /// <summary>
        /// Gets or sets the CC_code
        /// </summary>
        public string CC_code { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Millatary_ind
        /// </summary>
        public bool Millatary_ind { get; set; }

        /// <summary>
        /// Gets or sets the Income_tax_num
        /// </summary>
        public string Income_tax_num { get; set; }

        /// <summary>
        /// Gets or sets the Income_tax_date
        /// </summary>
        public Nullable<System.DateTime> Income_tax_date { get; set; }

        /// <summary>
        /// Gets or sets the VAT_num
        /// </summary>
        public string VAT_num { get; set; }

        /// <summary>
        /// Gets or sets the VAT_date
        /// </summary>
        public Nullable<System.DateTime> VAT_date { get; set; }

        /// <summary>
        /// Gets or sets the Revenue_office
        /// </summary>
        public string Revenue_office { get; set; }

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
        public virtual ICollection<Comp_alloc> Comp_alloc { get; set; }

        /// <summary>
        /// Gets or sets the Comp_rel
        /// </summary>
        public virtual ICollection<Comp_rel> Comp_rel { get; set; }

        /// <summary>
        /// Gets or sets the Documents
        /// </summary>
        public virtual ICollection<Document> Documents { get; set; }

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
        /// Gets or sets the Person_citizen
        /// </summary>
        public virtual Person_citizen Person_citizen { get; set; }

        /// <summary>
        /// Gets or sets the Person_credit_hist
        /// </summary>
        public virtual Person_credit_hist Person_credit_hist { get; set; }

        /// <summary>
        /// Gets or sets the Person_education
        /// </summary>
        public virtual Person_education Person_education { get; set; }

        /// <summary>
        /// Gets or sets the Person_employ
        /// </summary>
        public virtual Person_employ Person_employ { get; set; }

        /// <summary>
        /// Gets or sets the Person_gambling
        /// </summary>
        public virtual Person_gambling Person_gambling { get; set; }

        /// <summary>
        /// Gets or sets the Person_mil_service
        /// </summary>
        public virtual Person_mil_service Person_mil_service { get; set; }

        /// <summary>
        /// Gets or sets the Person_relation
        /// </summary>
        public virtual Person_relation Person_relation { get; set; }

        /// <summary>
        /// Gets or sets the Person_relation1
        /// </summary>
        public virtual ICollection<Person_relation> Person_relation1 { get; set; }

        /// <summary>
        /// Gets or sets the Profess_history
        /// </summary>
        public virtual Profess_history Profess_history { get; set; }

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
        /// Gets or sets the SR_role
        /// </summary>
        public virtual ICollection<SR_role> SR_role { get; set; }

        /// <summary>
        /// Gets or sets the User
        /// </summary>
        public virtual User User { get; set; }
    }
}
