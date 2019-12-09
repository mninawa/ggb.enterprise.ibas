namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="AddressMap" />
    /// </summary>
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressMap"/> class.
        /// </summary>
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Erf_num)
                .HasMaxLength(20);

            this.Property(t => t.Address_line_1)
                .IsRequired().HasMaxLength(50);

            this.Property(t => t.Address_line_2)
                .HasMaxLength(50);

            this.Property(t => t.Street)
                .IsRequired().HasMaxLength(50);

            this.Property(t => t.Suburb)
                .HasMaxLength(50);

            this.Property(t => t.Postal_code)
                .IsRequired().HasMaxLength(10);

            this.Property(t => t.Lease_agree_num)
                .HasMaxLength(20);

            this.Property(t => t.Owner_name)
                .HasMaxLength(50);

            this.Property(t => t.Renting_agency)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Address");
            this.Property(t => t.Identifier).HasColumnName("Address_num");
            this.Property(t => t.Adr_rel_for).HasColumnName("Adr_rel_for");
            this.Property(t => t.Adr_comp_num).HasColumnName("Adr_comp_num");
            this.Property(t => t.Adr_pers_num).HasColumnName("Adr_pers_num");
            this.Property(t => t.Adr_equip_num).HasColumnName("Adr_equip_num");
            this.Property(t => t.Adr_lic_num).HasColumnName("Adr_lic_num");
            this.Property(t => t.Adr_loc_num).HasColumnName("Adr_loc_num");
            this.Property(t => t.Address_type).HasColumnName("Address_type");
            this.Property(t => t.Address_stat).HasColumnName("Address_stat");
            this.Property(t => t.Ownership_stat).HasColumnName("Ownership_stat");
            this.Property(t => t.Erf_num).HasColumnName("Erf_num");
            this.Property(t => t.Address_line_1).HasColumnName("Address_line_1");
            this.Property(t => t.Address_line_2).HasColumnName("Address_line_2");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.Suburb).HasColumnName("Suburb");
            this.Property(t => t.Adr_city_num).HasColumnName("Adr_city_num");
            this.Property(t => t.Adre_mun_num).HasColumnName("Adre_mun_num");
            this.Property(t => t.Adr_prov_num).HasColumnName("Adr_prov_num");
            this.Property(t => t.Adre_state_num).HasColumnName("Adre_state_num");
            this.Property(t => t.Adr_country_num).HasColumnName("Adr_country_num");
            this.Property(t => t.Postal_code).HasColumnName("Postal_code");
            this.Property(t => t.Lease_agree_num).HasColumnName("Lease_agree_num");
            this.Property(t => t.Owner_name).HasColumnName("Owner_name");
            this.Property(t => t.Renting_agency).HasColumnName("Renting_agency");
            this.Property(t => t.Add_start_date).HasColumnName("Add_start_date");
            this.Property(t => t.Lease_date_end).HasColumnName("Lease_date_end");

            // Relationships
            this.HasRequired(t => t.City)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adr_city_num);
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adr_comp_num);
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adr_country_num);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adr_equip_num);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adr_lic_num);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adr_loc_num);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adr_pers_num);
            this.HasRequired(t => t.Province)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adr_prov_num);
            this.HasRequired(t => t.Municipality)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adre_mun_num);
            this.HasRequired(t => t.State)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.Adre_state_num);
        }
    }
}
