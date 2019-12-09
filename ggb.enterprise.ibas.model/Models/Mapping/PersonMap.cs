namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="PersonMap" />
    /// </summary>
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonMap"/> class.
        /// </summary>
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Surname)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.First_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Initials)
                .IsRequired()
 .HasMaxLength(10);

            this.Property(t => t.Alias_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Maiden_name)
                .HasMaxLength(50);

            this.Property(t => t.Pers_place_birth)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Complexion)
                .HasMaxLength(20);

            this.Property(t => t.Eye_color)
                .HasMaxLength(20);

            this.Property(t => t.Hair_color)
                .HasMaxLength(20);

            this.Property(t => t.Marks)
                .HasMaxLength(200);

            this.Property(t => t.Per_home_num)
                .HasMaxLength(13);

            this.Property(t => t.Per_work_num)
                .HasMaxLength(13);

            this.Property(t => t.Per_cell_num)
                .HasMaxLength(13);

            this.Property(t => t.Per_fax_num)
                .HasMaxLength(13);

            this.Property(t => t.Per_email)
                .HasMaxLength(50);

            this.Property(t => t.Alt_contact_name)
                .HasMaxLength(50);

            this.Property(t => t.Alt_contact_num)
                .HasMaxLength(13);

            this.Property(t => t.CC_code)
                .HasMaxLength(10);

            this.Property(t => t.Income_tax_num)
                .HasMaxLength(20);

            this.Property(t => t.VAT_num)
                .HasMaxLength(20);

            this.Property(t => t.Revenue_office)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Person");
            this.Property(t => t.Identifier).HasColumnName("Person_num");
            this.Property(t => t.Surname).HasColumnName("Surname");
            this.Property(t => t.First_name).HasColumnName("First_name");
            this.Property(t => t.Initials).HasColumnName("Initials");
            this.Property(t => t.Alias_name).HasColumnName("Alias_name");
            this.Property(t => t.Maiden_name).HasColumnName("Maiden_name");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Person_group).HasColumnName("Person_group");
            this.Property(t => t.Person_status).HasColumnName("Person_status");
            this.Property(t => t.ID_type).HasColumnName("ID_type");
            this.Property(t => t.ID_number).HasColumnName("ID_number");
            this.Property(t => t.Pers_date_birth).HasColumnName("Pers_date_birth");
            this.Property(t => t.Pers_place_brith_ind).HasColumnName("Pers_place_brith_ind");
            this.Property(t => t.Pers_place_birth).HasColumnName("Pers_place_birth");
            this.Property(t => t.Per_date_decease).HasColumnName("Per_date_decease");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Complexion).HasColumnName("Complexion");
            this.Property(t => t.Eye_color).HasColumnName("Eye_color");
            this.Property(t => t.Hair_color).HasColumnName("Hair_color");
            this.Property(t => t.Marks).HasColumnName("Marks");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Race).HasColumnName("Race");
            this.Property(t => t.Marital_stat).HasColumnName("Marital_stat");
            this.Property(t => t.Per_home_num).HasColumnName("Per_home_num");
            this.Property(t => t.Per_work_num).HasColumnName("Per_work_num");
            this.Property(t => t.Per_cell_num).HasColumnName("Per_cell_num");
            this.Property(t => t.Per_fax_num).HasColumnName("Per_fax_num");
            this.Property(t => t.Per_email).HasColumnName("Per_email");
            this.Property(t => t.Alt_contact_name).HasColumnName("Alt_contact_name");
            this.Property(t => t.Alt_contact_num).HasColumnName("Alt_contact_num");
            this.Property(t => t.Alt_relation_type).HasColumnName("Alt_relation_type");
            this.Property(t => t.CC_code).HasColumnName("CC_code");
            this.Property(t => t.Millatary_ind).HasColumnName("Millatary_ind");
            this.Property(t => t.Income_tax_num).HasColumnName("Income_tax_num");
            this.Property(t => t.Income_tax_date).HasColumnName("Income_tax_date");
            this.Property(t => t.VAT_num).HasColumnName("VAT_num");
            this.Property(t => t.VAT_date).HasColumnName("VAT_date");
            this.Property(t => t.Revenue_office).HasColumnName("Revenue_office");
        }
    }
}
