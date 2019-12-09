namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Entity" />
    /// </summary>
    public partial class Entity : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity"/> class.
        /// </summary>
        public Entity()
        {
            this.Person_gambling = new List<Person_gambling>();
            this.Person_relation = new List<Person_relation>();
            this.Service_request = new List<Service_request>();
        }

        /// <summary>
        /// Gets or sets the Entity_Name
        /// </summary>
        public string Entity_Name { get; set; }

        /// <summary>
        /// Gets or sets the Entity_first_names
        /// </summary>
        public string Entity_first_names { get; set; }

        /// <summary>
        /// Gets or sets the Entity_alias
        /// </summary>
        public string Entity_alias { get; set; }

        /// <summary>
        /// Gets or sets the Entity_maiden
        /// </summary>
        public string Entity_maiden { get; set; }

        /// <summary>
        /// Gets or sets the Ent_ID_type
        /// </summary>
        public Nullable<int> Ent_ID_type { get; set; }

        /// <summary>
        /// Gets or sets the Ent_ID_num
        /// </summary>
        public Nullable<int> Ent_ID_num { get; set; }

        /// <summary>
        /// Gets or sets the Ent_date_birth
        /// </summary>
        public Nullable<System.DateTime> Ent_date_birth { get; set; }

        /// <summary>
        /// Gets or sets the Ent_place_brith_ind
        /// </summary>
        public Nullable<int> Ent_place_brith_ind { get; set; }

        /// <summary>
        /// Gets or sets the Ent_place_birth
        /// </summary>
        public string Ent_place_birth { get; set; }

        /// <summary>
        /// Gets or sets the Ent_date_decease
        /// </summary>
        public Nullable<System.DateTime> Ent_date_decease { get; set; }

        /// <summary>
        /// Gets or sets the Ent_address
        /// </summary>
        public string Ent_address { get; set; }

        /// <summary>
        /// Gets or sets the Occupation
        /// </summary>
        public string Occupation { get; set; }

        /// <summary>
        /// Gets or sets the Ent_home_num
        /// </summary>
        public string Ent_home_num { get; set; }

        /// <summary>
        /// Gets or sets the Ent_work_num
        /// </summary>
        public string Ent_work_num { get; set; }

        /// <summary>
        /// Gets or sets the Ent_cell_num
        /// </summary>
        public string Ent_cell_num { get; set; }

        /// <summary>
        /// Gets or sets the Ent_email
        /// </summary>
        public string Ent_email { get; set; }

        /// <summary>
        /// Gets or sets the Person_gambling
        /// </summary>
        public virtual ICollection<Person_gambling> Person_gambling { get; set; }

        /// <summary>
        /// Gets or sets the Person_relation
        /// </summary>
        public virtual ICollection<Person_relation> Person_relation { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual ICollection<Service_request> Service_request { get; set; }
    }
}
