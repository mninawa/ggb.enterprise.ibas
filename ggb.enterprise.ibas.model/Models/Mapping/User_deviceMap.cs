using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ggb.enterprise.ibas.model.Models
{
    public class User_deviceMap : EntityTypeConfiguration<User_device>
    {
        public User_deviceMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties

            this.Property(t => t.Dev_user_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Device_num)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("User_device");
            this.Property(t => t.Identifier).HasColumnName("Device_pers_num");
            this.Property(t => t.Dev_user_name).HasColumnName("Dev_user_name");
            this.Property(t => t.Device_num).HasColumnName("Device_num");
            this.Property(t => t.Device_make).HasColumnName("Device_make");
            this.Property(t => t.Device_type).HasColumnName("Device_type");
        }
    }
}
