using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Inchariot.DAL.Models.Mapping
{
    public class ProfileChangeMap : EntityTypeConfiguration<ProfileChange>
    {
        public ProfileChangeMap()
        {
            // Primary Key
            this.HasKey(t => t.PID);

            // Properties
            this.Property(t => t.firstName)
                .HasMaxLength(50);

            this.Property(t => t.gender)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(100);

            this.Property(t => t.profilephoto)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProfileChange");
            this.Property(t => t.PID).HasColumnName("PID");
            this.Property(t => t.UID).HasColumnName("UID");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.gender).HasColumnName("gender");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.datebirth).HasColumnName("datebirth");
            this.Property(t => t.bio).HasColumnName("bio");
            this.Property(t => t.profilephoto).HasColumnName("profilephoto");

            // Relationships
            this.HasOptional(t => t.aspnet_Profile)
                .WithMany(t => t.ProfileChanges)
                .HasForeignKey(d => d.UID);

        }
    }
}
