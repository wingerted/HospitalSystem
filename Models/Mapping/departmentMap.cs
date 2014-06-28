using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class departmentMap : EntityTypeConfiguration<department>
    {
        public departmentMap()
        {
            // Primary Key
            this.HasKey(t => t.DepartmentID);

            // Properties
            this.Property(t => t.DepartmentName)
                .HasMaxLength(50);

            this.Property(t => t.DepartmentDescribe)
                .HasMaxLength(50);

            this.Property(t => t.DepartmentType)
              .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("department", "teamwork");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.DepartmentName).HasColumnName("DepartmentName");
            this.Property(t => t.DepartmentDescribe).HasColumnName("DepartmentDescribe");
            this.Property(t => t.DepartmentType).HasColumnName("DepartmentType");
        }
    }
}
