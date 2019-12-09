namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;

    /// <summary>
    /// Defines the <see cref="Region" />
    /// </summary>
    public partial class Region : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the Reg_desc
        /// </summary>
        public string Reg_desc { get; set; }

        /// <summary>
        /// Gets or sets the Reg_prov_num
        /// </summary>
        public int Reg_prov_num { get; set; }

        /// <summary>
        /// Gets or sets the Reg_mun_num
        /// </summary>
        public int Reg_mun_num { get; set; }

        /// <summary>
        /// Gets or sets the Municipality
        /// </summary>
        public virtual Municipality Municipality { get; set; }

        /// <summary>
        /// Gets or sets the Province
        /// </summary>
        public virtual Province Province { get; set; }
    }
}
