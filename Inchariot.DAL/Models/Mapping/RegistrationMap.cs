using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Inchariot.DAL.Models.Mapping
{
    public class RegistrationMap : EntityTypeConfiguration<Registration>
    {
        public RegistrationMap()
        {
            // Primary Key
            this.HasKey(t => t.RID);

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
            this.ToTable("Registration");
            this.Property(t => t.RID).HasColumnName("RID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MobileNo).HasColumnName("MobileNo");
            this.Property(t => t.OTP).HasColumnName("OTP");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Gander).HasColumnName("Gander");
            this.Property(t => t.Dateofbirth).HasColumnName("Dateofbirth");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.DateOn).HasColumnName("DateOn");
        }
    }
}
