namespace ggb.enterprise.ibas.data.Models
{
    using ggb.enterprise.ibas.common.data;
    using ggb.enterprise.ibas.model.Models;
    using System.Data.Entity;

    /// <summary>
    /// Defines the <see cref="GGBContext" />
    /// </summary>
    public class GGBContext : ApplicationContext
    {
        /// <summary>
        /// Initializes static members of the <see cref="GGBContext"/> class.
        /// </summary>
        static GGBContext()
        {
            Database.SetInitializer<GGBContext>(null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GGBContext"/> class.
        /// </summary>
        public GGBContext()
            : base("Name=GGBContext")
        {
        }

        /// <summary>
        /// Gets or sets the Enum_list
        /// </summary>
        public DbSet<Enum_list> Enum_list { get; set; }

        /// <summary>
        /// Gets or sets the People
        /// </summary>
        public DbSet<Person> People { get; set; }

        /// <summary>
        /// Gets or sets the User_device
        /// </summary>
        public DbSet<User_device> User_device { get; set; }

        /// <summary>
        /// Gets or sets the Users
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// The OnModelCreating
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="DbModelBuilder"/></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Enum_listMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new User_deviceMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
