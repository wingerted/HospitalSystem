using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class withdraw_medicine_recordMap : EntityTypeConfiguration<withdraw_medicine_record>
    {
        public withdraw_medicine_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.WithdrawMedicineRecordID);

            // Properties
            // Table & Column Mappings
            this.ToTable("withdraw_medicine_record", "teamwork");
            this.Property(t => t.WithdrawMedicineRecordID).HasColumnName("WithdrawMedicineRecordID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.StaffID).HasColumnName("StaffID");
            this.Property(t => t.MedicineNumber).HasColumnName("MedicineNumber");
            this.Property(t => t.WithdrawMedicineDate).HasColumnName("WithdrawMedicineDate");

            // Relationships
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.withdraw_medicine_record)
                .HasForeignKey(d => d.MedicineID);
            this.HasOptional(t => t.patient)
                .WithMany(t => t.withdraw_medicine_record)
                .HasForeignKey(d => d.PatientID);
            this.HasOptional(t => t.staff)
                .WithMany(t => t.withdraw_medicine_record)
                .HasForeignKey(d => d.StaffID);

        }
    }
}
