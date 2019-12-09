namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Person_relation" />
    /// </summary>
    public partial class Person_relation : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Rel_rel_for
        /// </summary>
        public int Rel_rel_for { get; set; }

        /// <summary>
        /// Gets or sets the Related_person_num
        /// </summary>
        public Nullable<int> Related_person_num { get; set; }

        /// <summary>
        /// Gets or sets the Related_entity_number
        /// </summary>
        public Nullable<int> Related_entity_number { get; set; }

        /// <summary>
        /// Gets or sets the Relation_type
        /// </summary>
        public int Relation_type { get; set; }

        /// <summary>
        /// Gets or sets the Rel_start_date
        /// </summary>
        public System.DateTime Rel_start_date { get; set; }

        /// <summary>
        /// Gets or sets the Rel_end_date
        /// </summary>
        public Nullable<System.DateTime> Rel_end_date { get; set; }

        /// <summary>
        /// Gets or sets the Date_marriage
        /// </summary>
        public Nullable<System.DateTime> Date_marriage { get; set; }

        /// <summary>
        /// Gets or sets the Place_marriage
        /// </summary>
        public string Place_marriage { get; set; }

        /// <summary>
        /// Gets or sets the Marriage_contract
        /// </summary>
        public Nullable<int> Marriage_contract { get; set; }

        /// <summary>
        /// Gets or sets the Date_divorce
        /// </summary>
        public Nullable<System.DateTime> Date_divorce { get; set; }

        /// <summary>
        /// Gets or sets the Entity
        /// </summary>
        public virtual Entity Entity { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Person1
        /// </summary>
        public virtual Person Person1 { get; set; }
    }
}
