using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ggb.enterprise.ibas.model.Models
{
    public class Enum_listMap : EntityTypeConfiguration<Enum_list>
    {
        public Enum_listMap()
        {
            // Primary Key
            this.HasKey(t => t.Identifier);

            // Properties

            this.Property(t => t.Enum_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Enum_value)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Table)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Enum_list");
            this.Property(t => t.Identifier).HasColumnName("Enum_ID");
            this.Property(t => t.Enum_type).HasColumnName("Enum_type");
            this.Property(t => t.Enum_value).HasColumnName("Enum_value");
            this.Property(t => t.Table).HasColumnName("Table");
        }
    }
}
