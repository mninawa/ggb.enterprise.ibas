namespace ggb.enterprise.ibas.model.Models
{
    using ggb.enterprise.ibas.common.model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Equipment" />
    /// </summary>
    public partial class Equipment : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Equipment"/> class.
        /// </summary>
        public Equipment()
        {
            this.Addresses = new List<Address>();
            this.Comms = new List<Comm>();
            this.Documents = new List<Document>();
            this.Events = new List<Event>();
            this.Financings = new List<Financing>();
            this.Licence_tax = new List<Licence_tax>();
            this.License_fee = new List<License_fee>();
            this.Ques_ans = new List<Ques_ans>();
            this.Registers = new List<Register>();
            this.Service_request = new List<Service_request>();
            this.Licences = new List<Licence>();
            this.Locations = new List<Location>();
        }

        /// <summary>
        /// Gets or sets the Equip_name
        /// </summary>
        public string Equip_name { get; set; }

        /// <summary>
        /// Gets or sets the Equip_description
        /// </summary>
        public string Equip_description { get; set; }

        /// <summary>
        /// Gets or sets the Equip_cat
        /// </summary>
        public int Equip_cat { get; set; }

        /// <summary>
        /// Gets or sets the Equip_type
        /// </summary>
        public int Equip_type { get; set; }

        /// <summary>
        /// Gets or sets the Equip_stat
        /// </summary>
        public int Equip_stat { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_manu
        /// </summary>
        public string Equipment_manu { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_game_name
        /// </summary>
        public string Equipment_game_name { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_serial_number
        /// </summary>
        public string Equipment_serial_number { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_asset_number
        /// </summary>
        public string Equipment_asset_number { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_note
        /// </summary>
        public string Equipment_note { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_comp
        /// </summary>
        public Nullable<int> Equipment_comp { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_license_number
        /// </summary>
        public Nullable<int> Equipment_license_number { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_loca
        /// </summary>
        public Nullable<int> Equipment_loca { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_sign
        /// </summary>
        public string Equipment_sign { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_stat
        /// </summary>
        public string Equipment_stat { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_deno
        /// </summary>
        public Nullable<int> Equipment_deno { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_gmu
        /// </summary>
        public Nullable<int> Equipment_gmu { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_conf
        /// </summary>
        public string Equipment_conf { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_model_name
        /// </summary>
        public string Equipment_model_name { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_model_type
        /// </summary>
        public string Equipment_model_type { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_multi_denomination
        /// </summary>
        public Nullable<bool> Equipment_multi_denomination { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_hold_percentage
        /// </summary>
        public Nullable<int> Equipment_hold_percentage { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_disp
        /// </summary>
        public string Equipment_disp { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_var_hold_percentage
        /// </summary>
        public Nullable<bool> Equipment_var_hold_percentage { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_online_date
        /// </summary>
        public Nullable<System.DateTime> Equipment_online_date { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_game_hold_percentage
        /// </summary>
        public Nullable<int> Equipment_game_hold_percentage { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_multi_game
        /// </summary>
        public Nullable<bool> Equipment_multi_game { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_progressive_link
        /// </summary>
        public string Equipment_progressive_link { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_progression_rate
        /// </summary>
        public Nullable<int> Equipment_progression_rate { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_reel_strip
        /// </summary>
        public string Equipment_reel_strip { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_stoo
        /// </summary>
        public Nullable<bool> Equipment_stoo { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_prog
        /// </summary>
        public Nullable<bool> Equipment_prog { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_game
        /// </summary>
        public string Equipment_game { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_bill_serial_number
        /// </summary>
        public string Equipment_bill_serial_number { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_life_cycle
        /// </summary>
        public string Equipment_life_cycle { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_tournament_play
        /// </summary>
        public Nullable<bool> Equipment_tournament_play { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_video_game
        /// </summary>
        public Nullable<bool> Equipment_video_game { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_credit_game
        /// </summary>
        public Nullable<bool> Equipment_credit_game { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_max_coin_in
        /// </summary>
        public Nullable<int> Equipment_max_coin_in { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_max_handle_pull_per_minute
        /// </summary>
        public Nullable<int> Equipment_max_handle_pull_per_minute { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_ecash_enabled
        /// </summary>
        public Nullable<bool> Equipment_ecash_enabled { get; set; }

        /// <summary>
        /// Gets or sets the NF1
        /// </summary>
        public Nullable<bool> NF1 { get; set; }

        /// <summary>
        /// Gets or sets the NF2
        /// </summary>
        public Nullable<bool> NF2 { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_epr
        /// </summary>
        public Nullable<bool> Equipment_epr { get; set; }

        /// <summary>
        /// Gets or sets the NF3
        /// </summary>
        public string NF3 { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_playable_tickets
        /// </summary>
        public Nullable<bool> Equipment_playable_tickets { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_crc_tkt_ecash_disabled
        /// </summary>
        public Nullable<bool> Equipment_crc_tkt_ecash_disabled { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_x_se
        /// </summary>
        public Nullable<bool> Equipment_x_se { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_entry_bet_credits
        /// </summary>
        public Nullable<int> Equipment_entry_bet_credits { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_bvm
        /// </summary>
        public string Equipment_bvm { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_wap_prog_theme
        /// </summary>
        public string Equipment_wap_prog_theme { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_number_of_pay_lines
        /// </summary>
        public string Equipment_number_of_pay_lines { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_roul
        /// </summary>
        public Nullable<bool> Equipment_roul { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_payl
        /// </summary>
        public string Equipment_payl { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_reel
        /// </summary>
        public string Equipment_reel { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_smart_card
        /// </summary>
        public Nullable<bool> Equipment_smart_card { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_cashless_system
        /// </summary>
        public Nullable<bool> Equipment_cashless_system { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_owner_type
        /// </summary>
        public string Equipment_owner_type { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_bank_name
        /// </summary>
        public string Equipment_bank_name { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_zone_name
        /// </summary>
        public string Equipment_zone_name { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_allow_non_cash_withdraw
        /// </summary>
        public Nullable<bool> Equipment_allow_non_cash_withdraw { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_game_supports_auto_pay
        /// </summary>
        public Nullable<bool> Equipment_game_supports_auto_pay { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_bvt
        /// </summary>
        public string Equipment_bvt { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_standard_error
        /// </summary>
        public Nullable<int> Equipment_standard_error { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_test_laboratory_name
        /// </summary>
        public string Equipment_test_laboratory_name { get; set; }

        /// <summary>
        /// Gets or sets the Equipment_test_report_no
        /// </summary>
        public string Equipment_test_report_no { get; set; }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Comms
        /// </summary>
        public virtual ICollection<Comm> Comms { get; set; }

        /// <summary>
        /// Gets or sets the Company
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the Documents
        /// </summary>
        public virtual ICollection<Document> Documents { get; set; }

        /// <summary>
        /// Gets or sets the Licence
        /// </summary>
        public virtual Licence Licence { get; set; }

        /// <summary>
        /// Gets or sets the Location
        /// </summary>
        public virtual Location Location { get; set; }

        /// <summary>
        /// Gets or sets the Events
        /// </summary>
        public virtual ICollection<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the Financings
        /// </summary>
        public virtual ICollection<Financing> Financings { get; set; }

        /// <summary>
        /// Gets or sets the Licence_tax
        /// </summary>
        public virtual ICollection<Licence_tax> Licence_tax { get; set; }

        /// <summary>
        /// Gets or sets the License_fee
        /// </summary>
        public virtual ICollection<License_fee> License_fee { get; set; }

        /// <summary>
        /// Gets or sets the Ques_ans
        /// </summary>
        public virtual ICollection<Ques_ans> Ques_ans { get; set; }

        /// <summary>
        /// Gets or sets the Registers
        /// </summary>
        public virtual ICollection<Register> Registers { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public virtual ICollection<Service_request> Service_request { get; set; }

        /// <summary>
        /// Gets or sets the Licences
        /// </summary>
        public virtual ICollection<Licence> Licences { get; set; }

        /// <summary>
        /// Gets or sets the Locations
        /// </summary>
        public virtual ICollection<Location> Locations { get; set; }
    }
}
