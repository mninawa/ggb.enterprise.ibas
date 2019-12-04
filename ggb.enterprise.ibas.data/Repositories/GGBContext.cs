using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ggb.enterprise.ibas.model.Models;
using ggb.enterprise.ibas.common.data;

namespace ggb.enterprise.ibas.data.Models
{
    public class GGBContext : ApplicationContext
    {
        static GGBContext()
        {
            Database.SetInitializer<GGBContext>(null);
        }

		public GGBContext()
			: base("Name=GGBContext")
		{
		}

        public DbSet<Enum_list> Enum_list { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<User_device> User_device { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Enum_listMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new User_deviceMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
