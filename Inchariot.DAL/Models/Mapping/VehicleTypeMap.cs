using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Inchariot.DAL.Models.Mapping
{
    public class VehicleTypeMap : EntityTypeConfiguration<VehicleType>
    {
        public VehicleTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VehicleType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.VehicleType1).HasColumnName("VehicleType");
            this.Property(t => t.date).HasColumnName("date");
        }
    }
}
