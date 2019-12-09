namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Ques_ansMap" />
    /// </summary>
    public class Ques_ansMap : EntityTypeConfiguration<Ques_ans>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ques_ansMap"/> class.
        /// </summary>
        public Ques_ansMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.QA_detail)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Ques_ans");
            this.Property(t => t.Identifier).HasColumnName("QA_num");
            this.Property(t => t.QA_rel_for).HasColumnName("QA_rel_for");
            this.Property(t => t.QA_comp_num).HasColumnName("QA_comp_num");
            this.Property(t => t.QA_pers_num).HasColumnName("QA_pers_num");
            this.Property(t => t.QA_equip_num).HasColumnName("QA_equip_num");
            this.Property(t => t.QA_lic_num).HasColumnName("QA_lic_num");
            this.Property(t => t.QA_loc_num).HasColumnName("QA_loc_num");
            this.Property(t => t.QA_SR_ID).HasColumnName("QA_SR_ID");
            this.Property(t => t.Ques_num).HasColumnName("Ques_num");
            this.Property(t => t.QA_ind).HasColumnName("QA_ind");
            this.Property(t => t.QA_detail).HasColumnName("QA_detail");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Ques_ans)
                .HasForeignKey(d => d.QA_comp_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Ques_ans)
                .HasForeignKey(d => d.QA_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Ques_ans)
                .HasForeignKey(d => d.QA_lic_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Ques_ans)
                .HasForeignKey(d => d.QA_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Ques_ans)
                .HasForeignKey(d => d.QA_pers_num);
            this.HasRequired(t => t.Service_request)
                .WithMany(t => t.Ques_ans)
                .HasForeignKey(d => d.QA_SR_ID);
        }
    }
}
