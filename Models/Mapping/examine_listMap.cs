using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class examine_listMap : EntityTypeConfiguration<examine_list>
    {
        public examine_listMap()
        {
            // Primary Key
            this.HasKey(t => t.ExamineListID);

            // Properties
            // Table & Column Mappings
            this.ToTable("examine_list", "teamwork");
            this.Property(t => t.ExamineListID).HasColumnName("ExamineListID");
            this.Property(t => t.MedicalRecordID).HasColumnName("MedicalRecordID");

            // Relationships
            this.HasOptional(t => t.medical_record)
                .WithMany(t => t.examine_list)
                .HasForeignKey(d => d.MedicalRecordID);

        }
    }
}
