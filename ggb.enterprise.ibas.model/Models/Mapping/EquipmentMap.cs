namespace ggb.enterprise.ibas.model.Models
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// Defines the <see cref="EquipmentMap" />
    /// </summary>
    public class EquipmentMap : EntityTypeConfiguration<Equipment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentMap"/> class.
        /// </summary>
        public EquipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties
            this.Property(t => t.Equip_name)
                .IsRequired()
 .HasMaxLength(50);

            this.Property(t => t.Equip_description)
                .IsRequired()
 .HasMaxLength(200);

            this.Property(t => t.Equipment_manu)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_game_name)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_serial_number)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_asset_number)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_note)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_sign)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_stat)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_conf)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_model_name)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_model_type)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_disp)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_progressive_link)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_reel_strip)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_game)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_bill_serial_number)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_life_cycle)
                .HasMaxLength(100);

            this.Property(t => t.NF3)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_bvm)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_wap_prog_theme)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_number_of_pay_lines)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_payl)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_reel)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_owner_type)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_bank_name)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_zone_name)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_bvt)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_test_laboratory_name)
                .HasMaxLength(100);

            this.Property(t => t.Equipment_test_report_no)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Equipment");
            this.Property(t => t.Identifier).HasColumnName("Equip_num");
            this.Property(t => t.Equip_name).HasColumnName("Equip_name");
            this.Property(t => t.Equip_description).HasColumnName("Equip_description");
            this.Property(t => t.Equip_cat).HasColumnName("Equip_cat");
            this.Property(t => t.Equip_type).HasColumnName("Equip_type");
            this.Property(t => t.Equip_stat).HasColumnName("Equip_stat");
            this.Property(t => t.Equipment_manu).HasColumnName("Equipment_manu");
            this.Property(t => t.Equipment_game_name).HasColumnName("Equipment_game_name");
            this.Property(t => t.Equipment_serial_number).HasColumnName("Equipment_serial_number");
            this.Property(t => t.Equipment_asset_number).HasColumnName("Equipment_asset_number");
            this.Property(t => t.Equipment_note).HasColumnName("Equipment_note");
            this.Property(t => t.Equipment_comp).HasColumnName("Equipment_comp");
            this.Property(t => t.Equipment_license_number).HasColumnName("Equipment_license_number");
            this.Property(t => t.Equipment_loca).HasColumnName("Equipment_loca");
            this.Property(t => t.Equipment_sign).HasColumnName("Equipment_sign");
            this.Property(t => t.Equipment_stat).HasColumnName("Equipment_stat");
            this.Property(t => t.Equipment_deno).HasColumnName("Equipment_deno");
            this.Property(t => t.Equipment_gmu).HasColumnName("Equipment_gmu");
            this.Property(t => t.Equipment_conf).HasColumnName("Equipment_conf");
            this.Property(t => t.Equipment_model_name).HasColumnName("Equipment_model_name");
            this.Property(t => t.Equipment_model_type).HasColumnName("Equipment_model_type");
            this.Property(t => t.Equipment_multi_denomination).HasColumnName("Equipment_multi_denomination");
            this.Property(t => t.Equipment_hold_percentage).HasColumnName("Equipment_hold_percentage");
            this.Property(t => t.Equipment_disp).HasColumnName("Equipment_disp");
            this.Property(t => t.Equipment_var_hold_percentage).HasColumnName("Equipment_var_hold_percentage");
            this.Property(t => t.Equipment_online_date).HasColumnName("Equipment_online_date");
            this.Property(t => t.Equipment_game_hold_percentage).HasColumnName("Equipment_game_hold_percentage");
            this.Property(t => t.Equipment_multi_game).HasColumnName("Equipment_multi_game");
            this.Property(t => t.Equipment_progressive_link).HasColumnName("Equipment_progressive_link");
            this.Property(t => t.Equipment_progression_rate).HasColumnName("Equipment_progression_rate");
            this.Property(t => t.Equipment_reel_strip).HasColumnName("Equipment_reel_strip");
            this.Property(t => t.Equipment_stoo).HasColumnName("Equipment_stoo");
            this.Property(t => t.Equipment_prog).HasColumnName("Equipment_prog");
            this.Property(t => t.Equipment_game).HasColumnName("Equipment_game");
            this.Property(t => t.Equipment_bill_serial_number).HasColumnName("Equipment_bill_serial_number");
            this.Property(t => t.Equipment_life_cycle).HasColumnName("Equipment_life_cycle");
            this.Property(t => t.Equipment_tournament_play).HasColumnName("Equipment_tournament_play");
            this.Property(t => t.Equipment_video_game).HasColumnName("Equipment_video_game");
            this.Property(t => t.Equipment_credit_game).HasColumnName("Equipment_credit_game");
            this.Property(t => t.Equipment_max_coin_in).HasColumnName("Equipment_max_coin_in");
            this.Property(t => t.Equipment_max_handle_pull_per_minute).HasColumnName("Equipment_max_handle_pull_per_minute");
            this.Property(t => t.Equipment_ecash_enabled).HasColumnName("Equipment_ecash_enabled");
            this.Property(t => t.NF1).HasColumnName("NF1");
            this.Property(t => t.NF2).HasColumnName("NF2");
            this.Property(t => t.Equipment_epr).HasColumnName("Equipment_epr");
            this.Property(t => t.NF3).HasColumnName("NF3");
            this.Property(t => t.Equipment_playable_tickets).HasColumnName("Equipment_playable_tickets");
            this.Property(t => t.Equipment_crc_tkt_ecash_disabled).HasColumnName("Equipment_crc_tkt_ecash_disabled");
            this.Property(t => t.Equipment_x_se).HasColumnName("Equipment_x_se");
            this.Property(t => t.Equipment_entry_bet_credits).HasColumnName("Equipment_entry_bet_credits");
            this.Property(t => t.Equipment_bvm).HasColumnName("Equipment_bvm");
            this.Property(t => t.Equipment_wap_prog_theme).HasColumnName("Equipment_wap_prog_theme");
            this.Property(t => t.Equipment_number_of_pay_lines).HasColumnName("Equipment_number_of_pay_lines");
            this.Property(t => t.Equipment_roul).HasColumnName("Equipment_roul");
            this.Property(t => t.Equipment_payl).HasColumnName("Equipment_payl");
            this.Property(t => t.Equipment_reel).HasColumnName("Equipment_reel");
            this.Property(t => t.Equipment_smart_card).HasColumnName("Equipment_smart_card");
            this.Property(t => t.Equipment_cashless_system).HasColumnName("Equipment_cashless_system");
            this.Property(t => t.Equipment_owner_type).HasColumnName("Equipment_owner_type");
            this.Property(t => t.Equipment_bank_name).HasColumnName("Equipment_bank_name");
            this.Property(t => t.Equipment_zone_name).HasColumnName("Equipment_zone_name");
            this.Property(t => t.Equipment_allow_non_cash_withdraw).HasColumnName("Equipment_allow_non_cash_withdraw");
            this.Property(t => t.Equipment_game_supports_auto_pay).HasColumnName("Equipment_game_supports_auto_pay");
            this.Property(t => t.Equipment_bvt).HasColumnName("Equipment_bvt");
            this.Property(t => t.Equipment_standard_error).HasColumnName("Equipment_standard_error");
            this.Property(t => t.Equipment_test_laboratory_name).HasColumnName("Equipment_test_laboratory_name");
            this.Property(t => t.Equipment_test_report_no).HasColumnName("Equipment_test_report_no");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.Equipment_comp);
            this.HasOptional(t => t.Licence)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.Equipment_license_number);
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.Equipment_loca);
        }
    }
}
