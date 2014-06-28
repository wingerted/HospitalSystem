using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class patientMap : EntityTypeConfiguration<patient>
    {
        public patientMap()
        {
            // Primary Key
            this.HasKey(t => t.PatientID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .HasMaxLength(5);

            this.Property(t => t.Telephone)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("patient", "teamwork");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
        }
    }
}
