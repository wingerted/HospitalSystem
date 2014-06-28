using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class charge_recordMap : EntityTypeConfiguration<charge_record>
    {
        public charge_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.ChargeRecordID);

            // Properties
            // Table & Column Mappings
            this.ToTable("charge_record", "teamwork");
            this.Property(t => t.ChargeRecordID).HasColumnName("ChargeRecordID");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.PrescriptionID).HasColumnName("PrescriptionID");
            this.Property(t => t.ExamineListID).HasColumnName("ExamineListID");
            this.Property(t => t.StaffID).HasColumnName("StaffID");
            this.Property(t => t.SumPay).HasColumnName("SumPay");
            this.Property(t => t.ChargeDate).HasColumnName("ChargeDate");

            // Relationships
            this.HasOptional(t => t.examine_list)
                .WithMany(t => t.charge_record)
                .HasForeignKey(d => d.ExamineListID);
            this.HasOptional(t => t.patient)
                .WithMany(t => t.charge_record)
                .HasForeignKey(d => d.PatientID);
            this.HasOptional(t => t.prescription)
                .WithMany(t => t.charge_record)
                .HasForeignKey(d => d.PrescriptionID);
            this.HasOptional(t => t.staff)
                .WithMany(t => t.charge_record)
                .HasForeignKey(d => d.StaffID);

        }
    }
}
