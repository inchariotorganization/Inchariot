using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Inchariot.DAL.Models.Mapping
{
    public class CountryMasterMap : EntityTypeConfiguration<CountryMaster>
    {
        public CountryMasterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CountryID, t.Country, t.IsActive, t.CreateDate });

            // Properties
            this.Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CountryMaster");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
