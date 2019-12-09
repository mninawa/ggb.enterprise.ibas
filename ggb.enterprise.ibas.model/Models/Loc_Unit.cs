namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;

    /// <summary>
    /// Defines the <see cref="Loc_Unit" />
    /// </summary>
    public partial class Loc_Unit : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Unit_num
        /// </summary>
        public int Unit_num { get; set; }

        /// <summary>
        /// Gets or sets the Floor
        /// </summary>
        public Nullable<int> Floor { get; set; }

        /// <summary>
        /// Gets or sets the Unit
        /// </summary>
        public int Unit { get; set; }

        /// <summary>
        /// Gets or sets the IP_add
        /// </summary>
        public string IP_add { get; set; }

        /// <summary>
        /// Gets or sets the Position
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the Area_name
        /// </summary>
        public string Area_name { get; set; }

        /// <summary>
        /// Gets or sets the Location
        /// </summary>
        public virtual Location Location { get; set; }
    }
}
