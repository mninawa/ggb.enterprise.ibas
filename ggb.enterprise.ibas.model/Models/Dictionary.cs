namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Dictionary" />
    /// </summary>
    public partial class Dictionary : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dictionary"/> class.
        /// </summary>
        public Dictionary()
        {
            this.SR_recommend = new List<SR_recommend>();
        }

        /// <summary>
        /// Gets or sets the Dictionary_cat
        /// </summary>
        public int Dictionary_cat { get; set; }

        /// <summary>
        /// Gets or sets the Dictionary_type
        /// </summary>
        public int Dictionary_type { get; set; }

        /// <summary>
        /// Gets or sets the Dictionary_desc
        /// </summary>
        public string Dictionary_desc { get; set; }

        /// <summary>
        /// Gets or sets the Dictionary_stat
        /// </summary>
        public int Dictionary_stat { get; set; }

        /// <summary>
        /// Gets or sets the SR_recommend
        /// </summary>
        public virtual ICollection<SR_recommend> SR_recommend { get; set; }
    }
}
