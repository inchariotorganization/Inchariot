using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Inchariot.DAL.Models.Mapping
{
    public class RideShareMap : EntityTypeConfiguration<RideShare>
    {
        public RideShareMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.MemberCardId)
                .HasMaxLength(300);

            this.Property(t => t.SourceCityId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.DestinationCityId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.Vehicle)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RideShare");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MemberCardId).HasColumnName("MemberCardId");
            this.Property(t => t.TravelStartTime).HasColumnName("TravelStartTime");
            this.Property(t => t.SourceCityId).HasColumnName("SourceCityId");
            this.Property(t => t.DestinationCityId).HasColumnName("DestinationCityId");
            this.Property(t => t.SeatsOffered).HasColumnName("SeatsOffered");
            this.Property(t => t.ContributionPerHead).HasColumnName("ContributionPerHead");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.AC).HasColumnName("AC");
            this.Property(t => t.Vehicle).HasColumnName("Vehicle");
        }
    }
}
