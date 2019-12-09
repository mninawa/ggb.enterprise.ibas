namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Service_request" />
    /// </summary>
    public partial class Service_request : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service_request"/> class.
        /// </summary>
        public Service_request()
        {
            this.Comms = new List<Comm>();
            this.Documents = new List<Document>();
            this.Events = new List<Event>();
            this.Licence_tax = new List<Licence_tax>();
            this.License_fee = new List<License_fee>();
            this.Ques_ans = new List<Ques_ans>();
            this.Registers = new List<Register>();
        }

        /// <summary>
        /// Gets or sets the SR_rel_for
        /// </summary>
        public int SR_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the SR_comp_num
        /// </summary>
        public Nullable<int> SR_comp_num { get; set; }

        /// <summary>
        /// Gets or sets the SR_pers_num
        /// </summary>
        public Nullable<int> SR_pers_num { get; set; }

        /// <summary>
        /// Gets or sets the SR_equip_num
        /// </summary>
        public Nullable<int> SR_equip_num { get; set; }

        /// <summary>
        /// Gets or sets the SR_lic_num
        /// </summary>
        public Nullable<int> SR_lic_num { get; set; }

        /// <summary>
        /// Gets or sets the SR_loc_num
        /// </summary>
        public Nullable<int> SR_loc_num { get; set; }

        /// <summary>
        /// Gets or sets the Entity_num
        /// </summary>
        public Nullable<int> Entity_num { get; set; }

        /// <summary>
        /// Gets or sets the SR_Stat
        /// </summary>
        public int SR_Stat { get; set; }

        /// <summary>
        /// Gets or sets the SLA_Stat
        /// </summary>
        public int SLA_Stat { get; set; }

        /// <summary>
        /// Gets or sets the SR_desc
        /// </summary>
        public string SR_desc { get; set; }

        /// <summary>
        /// Gets or sets the SR_service_cat
        /// </summary>
        public int SR_service_cat { get; set; }

        /// <summary>
        /// Gets or sets the SR_dept
        /// </summary>
        public int SR_dept { get; set; }

        /// <summary>
        /// Gets or sets the SR_sub_cap
        /// </summary>
        public int SR_sub_cap { get; set; }

        /// <summary>
        /// Gets or sets the SR_service_type
        /// </summary>
        public int SR_service_type { get; set; }

        /// <summary>
        /// Gets or sets the SR_service
        /// </summary>
        public int SR_service { get; set; }

        /// <summary>
        /// Gets or sets the SR_CC_code
        /// </summary>
        public Nullable<int> SR_CC_code { get; set; }

        /// <summary>
        /// Gets or sets the Create_by
        /// </summary>
        public int Create_by { get; set; }

        /// <summary>
        /// Gets or sets the Request_by
        /// </summary>
        public Nullable<int> Request_by { get; set; }

        /// <summary>
        /// Gets or sets the Close_by
        /// </summary>
        public Nullable<int> Close_by { get; set; }

        /// <summary>
        /// Gets or sets the Create_date
        /// </summary>
        public System.DateTime Create_date { get; set; }

        /// <summary>
        /// Gets or sets the Request_date
        /// </summary>
        public Nullable<System.DateTime> Request_date { get; set; }

        /// <summary>
        /// Gets or sets the SLA_start_date
        /// </summary>
        public Nullable<System.DateTime> SLA_start_date { get; set; }

        /// <summary>
        /// Gets or sets the SLA_end
        /// </summary>
        public Nullable<System.DateTime> SLA_end { get; set; }

        /// <summary>
        /// Gets or sets the MAD_date
        /// </summary>
        public Nullable<System.DateTime> MAD_date { get; set; }

        /// <summary>
        /// Gets or sets the Close_date
        /// </summary>
        public Nullable<System.DateTime> Close_date { get; set; }

        /// <summary>
        /// Gets or sets the Escalate_ind
        /// </summary>
        public Nullable<int> Escalate_ind { get; set; }

        /// <summary>
        /// Gets or sets the Escalate_date
        /// </summary>
        public Nullable<System.DateTime> Escalate_date { get; set; }

        /// <summary>
        /// Gets or sets the SR_priority
        /// </summary>
        public Nullable<int> SR_priority { get; set; }

        /// <summary>
        /// Gets or sets the SR_priority_motivate
        /// </summary>
        public string SR_priority_motivate { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind
        /// </summary>
        public int Priv_ind { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_licensing
        /// </summary>
        public Nullable<bool> Priv_ind_licensing { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_GC
        /// </summary>
        public Nullable<bool> Priv_ind_GC { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_audit
        /// </summary>
        public Nullable<bool> Priv_ind_audit { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_FI
        /// </summary>
        public Nullable<bool> Priv_ind_FI { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_legal
        /// </summary>
        public Nullable<bool> Priv_ind_legal { get; set; }

        /// <summary>
        /// Gets or sets the SR_Priv_ind_SED
        /// </summary>
        public Nullable<bool> SR_Priv_ind_SED { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_HR
        /// </summary>
        public Nullable<bool> Priv_ind_HR { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_risk
        /// </summary>
        public Nullable<bool> Priv_ind_risk { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_CS
        /// </summary>
        public Nullable<bool> Priv_ind_CS { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_comms
        /// </summary>
        public Nullable<bool> Priv_ind_comms { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_IT
        /// </summary>
        public Nullable<bool> Priv_ind_IT { get; set; }

        /// <summary>
        /// Gets or sets the Priv_ind_Board
        /// </summary>
        public Nullable<bool> Priv_ind_Board { get; set; }

        /// <summary>
        /// Gets or sets the Priv_role
        /// </summary>
        public int Priv_role { get; set; }

        /// <summary>
        /// Gets or sets the Priv_group_1
        /// </summary>
        public Nullable<bool> Priv_group_1 { get; set; }

        /// <summary>
        /// Gets or sets the Priv_group_2
        /// </summary>
        public Nullable<bool> Priv_group_2 { get; set; }

        /// <summary>
        /// Gets or sets the Priv_group_3
        /// </summary>
        public Nullable<bool> Priv_group_3 { get; set; }

        /// <summary>
        /// Gets or sets the Priv_group_4
        /// </summary>
        public Nullable<bool> Priv_group_4 { get; set; }

        /// <summary>
        /// Gets or sets the Priv_group_5
        /// </summary>
        public Nullable<bool> Priv_group_5 { get; set; }

        /// <summary>
        /// Gets or sets the Priv_group_6
        /// </summary>
        public Nullable<bool> Priv_group_6 { get; set; }

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
        /// Gets or sets the Entity
        /// </summary>
        public virtual Entity Entity { get; set; }

        /// <summary>
        /// Gets or sets the Equipment
        /// </summary>
        public virtual Equipment Equipment { get; set; }

        /// <summary>
        /// Gets or sets the Events
        /// </summary>
        public virtual ICollection<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the Financing
        /// </summary>
        public virtual Financing Financing { get; set; }

        /// <summary>
        /// Gets or sets the Licence
        /// </summary>
        public virtual Licence Licence { get; set; }

        /// <summary>
        /// Gets or sets the Licence_tax
        /// </summary>
        public virtual ICollection<Licence_tax> Licence_tax { get; set; }

        /// <summary>
        /// Gets or sets the License_fee
        /// </summary>
        public virtual ICollection<License_fee> License_fee { get; set; }

        /// <summary>
        /// Gets or sets the Location
        /// </summary>
        public virtual Location Location { get; set; }

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
        /// Gets or sets the Service_cat
        /// </summary>
        public virtual Service_cat Service_cat { get; set; }

        /// <summary>
        /// Gets or sets the Service_cat1
        /// </summary>
        public virtual Service_cat Service_cat1 { get; set; }

        /// <summary>
        /// Gets or sets the Service_cat2
        /// </summary>
        public virtual Service_cat Service_cat2 { get; set; }

        /// <summary>
        /// Gets or sets the Service_cat3
        /// </summary>
        public virtual Service_cat Service_cat3 { get; set; }

        /// <summary>
        /// Gets or sets the User
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the User1
        /// </summary>
        public virtual User User1 { get; set; }

        /// <summary>
        /// Gets or sets the User2
        /// </summary>
        public virtual User User2 { get; set; }

        /// <summary>
        /// Gets or sets the SR_advert
        /// </summary>
        public virtual SR_advert SR_advert { get; set; }

        /// <summary>
        /// Gets or sets the SR_recommend
        /// </summary>
        public virtual SR_recommend SR_recommend { get; set; }

        /// <summary>
        /// Gets or sets the SR_role
        /// </summary>
        public virtual SR_role SR_role { get; set; }

        /// <summary>
        /// Gets or sets the SR_status_hist
        /// </summary>
        public virtual SR_status_hist SR_status_hist { get; set; }
    }
}
