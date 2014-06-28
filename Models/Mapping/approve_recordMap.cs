using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class approve_recordMap : EntityTypeConfiguration<approve_record>
    {
        public approve_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.ApproveRecordID);

            // Properties
            this.Property(t => t.ApplyReason)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("approve_record", "teamwork");
            this.Property(t => t.ApproveRecordID).HasColumnName("ApproveRecordID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.ApplyDoctorID).HasColumnName("ApplyDoctorID");
            this.Property(t => t.ApproveDoctorID).HasColumnName("ApproveDoctorID");
            this.Property(t => t.MedicineNumber).HasColumnName("MedicineNumber");
            this.Property(t => t.ApplyReason).HasColumnName("ApplyReason");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.ApproveTime).HasColumnName("ApproveTime");
            this.Property(t => t.Pass).HasColumnName("Pass");

            // Relationships
            this.HasOptional(t => t.doctor)
                .WithMany(t => t.approve_record)
                .HasForeignKey(d => d.ApplyDoctorID);
            this.HasOptional(t => t.doctor1)
                .WithMany(t => t.approve_record1)
                .HasForeignKey(d => d.ApproveDoctorID);
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.approve_record)
                .HasForeignKey(d => d.MedicineID);

        }
    }
}
