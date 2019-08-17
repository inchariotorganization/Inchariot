using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Inchariot.DAL.Models.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.State)
                .HasMaxLength(100);

            this.Property(t => t.Country)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("City");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CityName).HasColumnName("CityName");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Country).HasColumnName("Country");
        }
    }
}
