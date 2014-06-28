using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class medical_record
    {
        public medical_record()
        {
            this.examine_list = new List<examine_list>();
            this.prescriptions = new List<prescription>();
        }

        public long MedicalRecordID { get; set; }
        public Nullable<long> PatientID { get; set; }
        public Nullable<long> DoctorID { get; set; }
        public string DiseaseDescribe { get; set; }
        public Nullable<System.DateTime> TreatTime { get; set; }
        public virtual doctor doctor { get; set; }
        public virtual ICollection<examine_list> examine_list { get; set; }
        public virtual patient patient { get; set; }
        public virtual ICollection<prescription> prescriptions { get; set; }
    }
}
