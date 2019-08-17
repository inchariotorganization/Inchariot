using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Inchariot.DAL.Models.Mapping
{
    public class ProfileMap : EntityTypeConfiguration<Profile>
    {
        public ProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.PID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Gander)
                .HasMaxLength(50);

            this.Property(t => t.Photo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Profile");
            this.Property(t => t.PID).HasColumnName("PID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MobileNo).HasColumnName("MobileNo");
            this.Property(t => t.OTP).HasColumnName("OTP");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Gander).HasColumnName("Gander");
            this.Property(t => t.Dateofbirth).HasColumnName("Dateofbirth");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.DateOn).HasColumnName("DateOn");
            this.Property(t => t.Bio).HasColumnName("Bio");
        }
    }
}
