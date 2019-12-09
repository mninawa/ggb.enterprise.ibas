namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="Person_relationMap" />
    /// </summary>
    public class Person_relationMap : EntityTypeConfiguration<Person_relation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person_relationMap"/> class.
        /// </summary>
        public Person_relationMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Place_marriage)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Person_relation");
            this.Property(t => t.Identifier).HasColumnName("Persrel_pers_num");
            this.Property(t => t.Rel_rel_for).HasColumnName("Rel_rel_for");
            this.Property(t => t.Related_person_num).HasColumnName("Related_person_num");
            this.Property(t => t.Related_entity_number).HasColumnName("Related_entity_number");
            this.Property(t => t.Relation_type).HasColumnName("Relation_type");
            this.Property(t => t.Rel_start_date).HasColumnName("Rel_start_date");
            this.Property(t => t.Rel_end_date).HasColumnName("Rel_end_date");
            this.Property(t => t.Date_marriage).HasColumnName("Date_marriage");
            this.Property(t => t.Place_marriage).HasColumnName("Place_marriage");
            this.Property(t => t.Marriage_contract).HasColumnName("Marriage_contract");
            this.Property(t => t.Date_divorce).HasColumnName("Date_divorce");

            // Relationships
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.Person_relation)
                .HasForeignKey(d => d.Related_entity_number);
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Person_relation);
            this.HasOptional(t => t.Person1)
                .WithMany(t => t.Person_relation1)
                .HasForeignKey(d => d.Related_person_num);
        }
    }
}
