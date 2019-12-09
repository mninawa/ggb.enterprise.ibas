namespace ggb.enterprise.ibas.data.Models
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;
    using System.Data.Entity;

    /// <summary>
    /// Defines the <see cref="GGB_DBContext" />
    /// </summary>
    public class GGB_DBContext : ApplicationContext
    {
        /// <summary>
        /// Initializes static members of the <see cref="GGB_DBContext"/> class.
        /// </summary>
        static GGB_DBContext()
        {
            Database.SetInitializer<GGB_DBContext>(null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GGB_DBContext"/> class.
        /// </summary>
        public GGB_DBContext()
            : base("Name=GGB_DBContext")
        {
        }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the App_fee
        /// </summary>
        public DbSet<App_fee> App_fee { get; set; }

        /// <summary>
        /// Gets or sets the Bank_acc
        /// </summary>
        public DbSet<Bank_acc> Bank_acc { get; set; }

        /// <summary>
        /// Gets or sets the Bank_tran
        /// </summary>
        public DbSet<Bank_tran> Bank_tran { get; set; }

        /// <summary>
        /// Gets or sets the Base_OS
        /// </summary>
        public DbSet<Base_OS> Base_OS { get; set; }

        /// <summary>
        /// Gets or sets the Cities
        /// </summary>
        public DbSet<City> Cities { get; set; }

        /// <summary>
        /// Gets or sets the Comms
        /// </summary>
        public DbSet<Comm> Comms { get; set; }

        /// <summary>
        /// Gets or sets the Comp_alloc
        /// </summary>
        public DbSet<Comp_alloc> Comp_alloc { get; set; }

        /// <summary>
        /// Gets or sets the Comp_rel
        /// </summary>
        public DbSet<Comp_rel> Comp_rel { get; set; }

        /// <summary>
        /// Gets or sets the Companies
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets the Countries
        /// </summary>
        public DbSet<Country> Countries { get; set; }

        /// <summary>
        /// Gets or sets the Dictionaries
        /// </summary>
        public DbSet<Dictionary> Dictionaries { get; set; }

        /// <summary>
        /// Gets or sets the Docfolders
        /// </summary>
        public DbSet<Docfolder> Docfolders { get; set; }

        /// <summary>
        /// Gets or sets the Documents
        /// </summary>
        public DbSet<Document> Documents { get; set; }

        /// <summary>
        /// Gets or sets the Entities
        /// </summary>
        public DbSet<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or sets the Enum_list
        /// </summary>
        public DbSet<Enum_list> Enum_list { get; set; }

        /// <summary>
        /// Gets or sets the Equipments
        /// </summary>
        public DbSet<Equipment> Equipments { get; set; }

        /// <summary>
        /// Gets or sets the Events
        /// </summary>
        public DbSet<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the Financial_info
        /// </summary>
        public DbSet<Financial_info> Financial_info { get; set; }

        /// <summary>
        /// Gets or sets the Financings
        /// </summary>
        public DbSet<Financing> Financings { get; set; }

        /// <summary>
        /// Gets or sets the Hardwares
        /// </summary>
        public DbSet<Hardware> Hardwares { get; set; }

        /// <summary>
        /// Gets or sets the Licences
        /// </summary>
        public DbSet<Licence> Licences { get; set; }

        /// <summary>
        /// Gets or sets the Licence_condition
        /// </summary>
        public DbSet<Licence_condition> Licence_condition { get; set; }

        /// <summary>
        /// Gets or sets the Licence_tax
        /// </summary>
        public DbSet<Licence_tax> Licence_tax { get; set; }

        /// <summary>
        /// Gets or sets the Licence_term
        /// </summary>
        public DbSet<Licence_term> Licence_term { get; set; }

        /// <summary>
        /// Gets or sets the License_fee
        /// </summary>
        public DbSet<License_fee> License_fee { get; set; }

        /// <summary>
        /// Gets or sets the Loc_Unit
        /// </summary>
        public DbSet<Loc_Unit> Loc_Unit { get; set; }

        /// <summary>
        /// Gets or sets the Locations
        /// </summary>
        public DbSet<Location> Locations { get; set; }

        /// <summary>
        /// Gets or sets the Municipalities
        /// </summary>
        public DbSet<Municipality> Municipalities { get; set; }

        /// <summary>
        /// Gets or sets the Offences
        /// </summary>
        public DbSet<Offence> Offences { get; set; }

        /// <summary>
        /// Gets or sets the People
        /// </summary>
        public DbSet<Person> People { get; set; }

        /// <summary>
        /// Gets or sets the Person_citizen
        /// </summary>
        public DbSet<Person_citizen> Person_citizen { get; set; }

        /// <summary>
        /// Gets or sets the Person_credit_hist
        /// </summary>
        public DbSet<Person_credit_hist> Person_credit_hist { get; set; }

        /// <summary>
        /// Gets or sets the Person_education
        /// </summary>
        public DbSet<Person_education> Person_education { get; set; }

        /// <summary>
        /// Gets or sets the Person_employ
        /// </summary>
        public DbSet<Person_employ> Person_employ { get; set; }

        /// <summary>
        /// Gets or sets the Person_gambling
        /// </summary>
        public DbSet<Person_gambling> Person_gambling { get; set; }

        /// <summary>
        /// Gets or sets the Person_mil_service
        /// </summary>
        public DbSet<Person_mil_service> Person_mil_service { get; set; }

        /// <summary>
        /// Gets or sets the Person_occ_history
        /// </summary>
        public DbSet<Person_occ_history> Person_occ_history { get; set; }

        /// <summary>
        /// Gets or sets the Person_relation
        /// </summary>
        public DbSet<Person_relation> Person_relation { get; set; }

        /// <summary>
        /// Gets or sets the Profess_history
        /// </summary>
        public DbSet<Profess_history> Profess_history { get; set; }

        /// <summary>
        /// Gets or sets the Provinces
        /// </summary>
        public DbSet<Province> Provinces { get; set; }

        /// <summary>
        /// Gets or sets the Ques_ans
        /// </summary>
        public DbSet<Ques_ans> Ques_ans { get; set; }

        /// <summary>
        /// Gets or sets the Regions
        /// </summary>
        public DbSet<Region> Regions { get; set; }

        /// <summary>
        /// Gets or sets the Registers
        /// </summary>
        public DbSet<Register> Registers { get; set; }

        /// <summary>
        /// Gets or sets the Service_cat
        /// </summary>
        public DbSet<Service_cat> Service_cat { get; set; }

        /// <summary>
        /// Gets or sets the Service_cat_rel
        /// </summary>
        public DbSet<Service_cat_rel> Service_cat_rel { get; set; }

        /// <summary>
        /// Gets or sets the Service_request
        /// </summary>
        public DbSet<Service_request> Service_request { get; set; }

        /// <summary>
        /// Gets or sets the Softwares
        /// </summary>
        public DbSet<Software> Softwares { get; set; }

        /// <summary>
        /// Gets or sets the SR_advert
        /// </summary>
        public DbSet<SR_advert> SR_advert { get; set; }

        /// <summary>
        /// Gets or sets the SR_recommend
        /// </summary>
        public DbSet<SR_recommend> SR_recommend { get; set; }

        /// <summary>
        /// Gets or sets the SR_role
        /// </summary>
        public DbSet<SR_role> SR_role { get; set; }

        /// <summary>
        /// Gets or sets the SR_status_hist
        /// </summary>
        public DbSet<SR_status_hist> SR_status_hist { get; set; }

        /// <summary>
        /// Gets or sets the Standards
        /// </summary>
        public DbSet<Standard> Standards { get; set; }

        /// <summary>
        /// Gets or sets the States
        /// </summary>
        public DbSet<State> States { get; set; }

        /// <summary>
        /// Gets or sets the sysdiagrams
        /// </summary>
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        /// <summary>
        /// Gets or sets the Users
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the User_device
        /// </summary>
        public DbSet<User_device> User_device { get; set; }

        /// <summary>
        /// The OnModelCreating
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="DbModelBuilder"/></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new App_feeMap());
            modelBuilder.Configurations.Add(new Bank_accMap());
            modelBuilder.Configurations.Add(new Bank_tranMap());
            modelBuilder.Configurations.Add(new Base_OSMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CommMap());
            modelBuilder.Configurations.Add(new Comp_allocMap());
            modelBuilder.Configurations.Add(new Comp_relMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new DictionaryMap());
            modelBuilder.Configurations.Add(new DocfolderMap());
            modelBuilder.Configurations.Add(new DocumentMap());
            modelBuilder.Configurations.Add(new EntityMap());
            modelBuilder.Configurations.Add(new Enum_listMap());
            modelBuilder.Configurations.Add(new EquipmentMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new Financial_infoMap());
            modelBuilder.Configurations.Add(new FinancingMap());
            modelBuilder.Configurations.Add(new HardwareMap());
            modelBuilder.Configurations.Add(new LicenceMap());
            modelBuilder.Configurations.Add(new Licence_conditionMap());
            modelBuilder.Configurations.Add(new Licence_taxMap());
            modelBuilder.Configurations.Add(new Licence_termMap());
            modelBuilder.Configurations.Add(new License_feeMap());
            modelBuilder.Configurations.Add(new Loc_UnitMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new MunicipalityMap());
            modelBuilder.Configurations.Add(new OffenceMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new Person_citizenMap());
            modelBuilder.Configurations.Add(new Person_credit_histMap());
            modelBuilder.Configurations.Add(new Person_educationMap());
            modelBuilder.Configurations.Add(new Person_employMap());
            modelBuilder.Configurations.Add(new Person_gamblingMap());
            modelBuilder.Configurations.Add(new Person_mil_serviceMap());
            modelBuilder.Configurations.Add(new Person_occ_historyMap());
            modelBuilder.Configurations.Add(new Person_relationMap());
            modelBuilder.Configurations.Add(new Profess_historyMap());
            modelBuilder.Configurations.Add(new ProvinceMap());
            modelBuilder.Configurations.Add(new Ques_ansMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new RegisterMap());
            modelBuilder.Configurations.Add(new Service_catMap());
            modelBuilder.Configurations.Add(new Service_cat_relMap());
            modelBuilder.Configurations.Add(new Service_requestMap());
            modelBuilder.Configurations.Add(new SoftwareMap());
            modelBuilder.Configurations.Add(new SR_advertMap());
            modelBuilder.Configurations.Add(new SR_recommendMap());
            modelBuilder.Configurations.Add(new SR_roleMap());
            modelBuilder.Configurations.Add(new SR_status_histMap());
            modelBuilder.Configurations.Add(new StandardMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new User_deviceMap());
        }
    }
}
